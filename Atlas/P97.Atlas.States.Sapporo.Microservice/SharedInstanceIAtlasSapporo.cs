using P97.Atlas.States.Sapporo.Business.Surface.Interfaces;

namespace P97.Atlas.States.Sapporo.Microservice
{
    internal static class SharedInstanceIAtlasSapporo
    {
        internal static IAtlasSapporo IAtlasSapporo { get; } = new ProjectFactory().NewAtlasSapporo();
    }
}