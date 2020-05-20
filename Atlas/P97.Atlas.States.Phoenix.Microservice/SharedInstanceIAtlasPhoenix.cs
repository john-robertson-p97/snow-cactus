using P97.Atlas.States.Phoenix.Business.Surface.Interfaces;

namespace P97.Atlas.States.Phoenix.Microservice
{
    internal static class SharedInstanceIAtlasPhoenix
    {
        internal static IAtlasPhoenix IAtlasPhoenix { get; } = new ProjectFactory().NewAtlasPhoenix();
    }
}