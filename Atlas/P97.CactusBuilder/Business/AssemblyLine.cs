using P97.CactusBuilder.Business.Surface.Interfaces;
using P97.Microservices.Proxy.Surface.Interfaces;

namespace P97.CactusBuilder.Business
{
    internal sealed class AssemblyLine : IAssemblyLine
    {
        internal AssemblyLine(IMicroserviceProxy microserviceProxy) => _microserviceProxy = microserviceProxy;

        public void BuildCactus()
        {
            _microserviceProxy.Put(
                $"http://{Display.Microservice.Surface.Definitions.UriInfo.ServiceName}/" +
                        $"{Display.Microservice.Surface.Definitions.UriInfo.Routes.Display}",
                DrawCactus(
                    _microserviceProxy.Get(
                        $"http://{Warehouse.Microservice.Surface.Definitions.UriInfo.ServiceName}/" +
                                $"{Warehouse.Microservice.Surface.Definitions.UriInfo.Routes.Warehouse}"
                    ).ReadAsStringAsync().Result
                )
            );
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

        private readonly IMicroserviceProxy _microserviceProxy;
    }
}