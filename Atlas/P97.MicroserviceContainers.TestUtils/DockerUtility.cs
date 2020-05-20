using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace P97.MicroserviceContainers.TestUtils
{
    public sealed class DockerUtility
    {
        public DockerUtility(string workingDirectory) => _workingDirectory = workingDirectory;

        public void BuildImage(string nameTag, string dockerfilePath)
        {
            RunProcess(
                SetUpStockProcess(),
                $"docker build -t {nameTag} -f {dockerfilePath} ."
            );
        }

        public void RunDockerCompose() =>
            RunProcess(SetUpStockProcess(), @"docker-compose -f Containers\docker-compose_linux.yaml up -d");

        public List<string> GetRepos()
        {
            Process proc = SetUpStockProcess();
            proc.StartInfo.RedirectStandardOutput = true;

            RunProcess(proc, "docker images");

            return ParseOutRepos(proc.StandardOutput);
        }

        public void StopContainers() =>
            RunProcess(SetUpStockProcess(), "FOR /f \"tokens=*\" %i IN ('docker ps -q') DO docker stop %i");

        public void Prune() => RunProcess(SetUpStockProcess(), "docker system prune -a --force");

        private Process SetUpStockProcess()
        {
            Process proc = new Process();
            proc.StartInfo.FileName = "cmd.exe";
            proc.StartInfo.RedirectStandardInput = true;
            proc.StartInfo.WorkingDirectory = _workingDirectory;
            return proc;
        }

        private void RunProcess(Process proc, string command)
        {
            proc.Start();

            proc.StandardInput.WriteLine(command);

            proc.StandardInput.Flush();
            proc.StandardInput.Close();
            proc.WaitForExit();
        }

        private List<string> ParseOutRepos(StreamReader streamReader)
        {
            var repos = new List<string>();
            string line;

            bool headerEncountered = false;

            while ((line = streamReader.ReadLine()) != null)
            {
                if (line.StartsWith("REPOSITORY "))
                {
                    headerEncountered = true;
                }
                else if (headerEncountered)
                {
                    if (string.IsNullOrWhiteSpace(line))
                    {
                        break;
                    }
                    repos.Add(line.Split(' ')[0]);
                }
            }
            return repos;
        }

        private readonly string _workingDirectory;
    }
}