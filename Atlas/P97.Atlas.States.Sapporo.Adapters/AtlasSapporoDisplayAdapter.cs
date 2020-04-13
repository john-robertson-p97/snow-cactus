using P97.Display.Adapter.Surface.Interfaces;

namespace P97.Atlas.States.Sapporo.Adapters
{
    internal class AtlasSapporoDisplayAdapter : IDisplayAdapter
    {
        internal AtlasSapporoDisplayAdapter(IDisplayAdapter baseDisplayAdapter) => _baseDisplayAdapter = baseDisplayAdapter;

        public void SetDisplay(string value) => _baseDisplayAdapter.SetDisplay(value);

        private readonly IDisplayAdapter _baseDisplayAdapter;
    }
}