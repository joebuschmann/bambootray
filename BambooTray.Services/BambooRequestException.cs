using System;
using System.Runtime.Serialization;

namespace BambooTray.Services
{

    // ReSharper disable ClassNeverInstantiated.Global
    // ReSharper disable UnusedAutoPropertyAccessor.Global
    // ReSharper disable UnusedMember.Global

    [Serializable]
    public class BambooRequestException : Exception
    {
        public BambooRequestException()
        {
        }

        public BambooRequestException(string message)
            : base(message)
        {
        }

        public BambooRequestException(string message, Exception inner)
            : base(message, inner)
        {
        }

        protected BambooRequestException(
            SerializationInfo info,
            StreamingContext context)
            : base(info, context)
        {
        }
    }
}