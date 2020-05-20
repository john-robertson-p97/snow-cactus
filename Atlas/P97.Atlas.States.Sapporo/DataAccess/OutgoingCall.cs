using System;

namespace P97.Atlas.States.Sapporo.DataAccess
{
    internal class OutgoingCall
    {
        internal OutgoingCall(OutgoingCallType type, string uri) : this(type, uri, x => x) { }

        internal OutgoingCall(OutgoingCallType type, string uri, Func<string, string> transformEventType)
        {
            Type = type;
            Uri = uri;
            TransformEventType = transformEventType;
        }

        internal OutgoingCallType Type { get; }

        internal string Uri { get; }

        internal Func<string, string> TransformEventType { get; }
    }
}