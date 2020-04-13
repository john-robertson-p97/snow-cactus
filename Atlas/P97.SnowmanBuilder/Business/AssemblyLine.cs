using P97.Display.Adapter.Surface.Interfaces;
using P97.SnowmanBuilder.Business.Surface.Interfaces;
using P97.Warehouse.Adapter.Surface.Interfaces;
using System.Threading.Tasks;

namespace P97.SnowmanBuilder.Business
{
    internal sealed class AssemblyLine : IAssemblyLine
    {
        internal AssemblyLine(IWarehouseAdapter warehouseAdapter, IDisplayAdapter displayAdapter)
        {
            _warehouseAdapter = warehouseAdapter;
            _displayAdapter = displayAdapter;
        }

        public void BuildSnowman()
        {
            string snowman = DrawSnowman(Task.Run(async () => await _warehouseAdapter.GetMaterialsAsync()).Result);
            _displayAdapter.SetDisplay(snowman.Replace("\r\n", "\\n").Replace("\n", "\\n").Replace("\\", "\\\\"));
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

        private readonly IWarehouseAdapter _warehouseAdapter;
        private readonly IDisplayAdapter _displayAdapter;
    }
}