namespace P97.Atlas.States.Phoenix.DataAccess
{
    internal class OutgoingCall
    {
        internal OutgoingCall(OutgoingCallType type, string uri)
        {
            Type = type;
            Uri = uri;
        }

        internal OutgoingCallType Type { get; }

        internal string Uri { get; }
    }
}