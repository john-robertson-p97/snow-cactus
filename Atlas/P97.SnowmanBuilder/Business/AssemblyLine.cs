using P97.Microservices.Proxy.Surface.Interfaces;
using P97.SnowmanBuilder.Business.Surface.Interfaces;

namespace P97.SnowmanBuilder.Business
{
    internal sealed class AssemblyLine : IAssemblyLine
    {
        internal AssemblyLine(IMicroserviceProxy microserviceProxy) => _microserviceProxy = microserviceProxy;

        public void BuildSnowman()
        {
            _microserviceProxy.Put(
                $"http://{Display.Microservice.Surface.Definitions.UriInfo.ServiceName}/" +
                        $"{Display.Microservice.Surface.Definitions.UriInfo.Routes.Display}",
                DrawSnowman(
                    _microserviceProxy.Get(
                        $"http://{Warehouse.Microservice.Surface.Definitions.UriInfo.ServiceName}/" +
                                $"{Warehouse.Microservice.Surface.Definitions.UriInfo.Routes.Warehouse}"
                    ).ReadAsStringAsync().Result
                )
            );
        }

        private static string DrawSnowman(string materials)
        {
            const int maxWidth = 13;
            materials = materials.Length <= maxWidth ? materials : materials.Substring(0, maxWidth);
            int leftWidth = maxWidth - ((maxWidth - materials.Length) / 2);
            materials = materials.PadLeft(leftWidth, ' ');
            materials = materials.PadRight(maxWidth, ' ');

            return "   " +
$@"      ___
        /x x\
        \_>_/
      /--   --\
-\----|       |----/-
      \_______/
    /----   ----\
   /             \
   |{materials}|
   \             /
    \___________/";
        }

        private readonly IMicroserviceProxy _microserviceProxy;
    }
}