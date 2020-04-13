using P97.Display.Adapter.Surface.Interfaces;
using P97.Display.Microservice.Surface.Definitions;
using System.Net.Http;
using System.Text;

namespace P97.Atlas.States.Phoenix.Adapters
{
    public class AtlasPhoenixDisplayAdapter : IDisplayAdapter
    {
        public AtlasPhoenixDisplayAdapter(IDisplayAdapter baseDisplayAdapter) => _baseDisplayAdapter = baseDisplayAdapter;

        public void SetDisplay(string value) => _baseDisplayAdapter.SetDisplay(value);

        private readonly IDisplayAdapter _baseDisplayAdapter;
    }
}