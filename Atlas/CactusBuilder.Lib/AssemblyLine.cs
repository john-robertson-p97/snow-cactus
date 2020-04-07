using CactusBuilder.Lib.Surface.Interfaces;
using System.Threading.Tasks;

namespace CactusBuilder.Lib
{
    internal sealed class AssemblyLine : IAssemblyLine
    {
        internal AssemblyLine(IWarehouseAdapter warehouseAdapter, IDisplayAdapter displayAdapter)
        {
            _warehouseAdapter = warehouseAdapter;
            _displayAdapter = displayAdapter;
        }

        public void BuildCactus()
        {
            string cactus = DrawCactus(Task.Run(async () => await _warehouseAdapter.GetMaterialsAsync()).Result);
            _displayAdapter.SetDisplay($"\"{cactus.Replace("\r\n", "\\n").Replace("\n", "\\n").Replace("\\", "\\\\")}\"");
        }

        private static string DrawCactus(string materials)
        {
            const int maxWidth = 22;
            materials = materials.Length <= maxWidth ? materials : materials.Substring(0, maxWidth);
            int leftWidth = maxWidth - ((maxWidth - materials.Length) / 2);
            materials = materials.PadLeft(leftWidth, ' ');
            materials = materials.PadRight(maxWidth, ' ');
            return "  " +
$@"        ____
         /    \
         |    |
 ___     |    |     ___
/   \    |    |    /   \
|   |    |    \    |   |
|   |    /    \    |   |
|   \___/      \___/   |
\{materials}/
 \-------\    /-------/
         |    |
         |    |
         |    |
         |    |";
        }

        private readonly IWarehouseAdapter _warehouseAdapter;
        private readonly IDisplayAdapter _displayAdapter;
    }
}