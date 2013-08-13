namespace Halltom.Bamboo.Tray.Services
{
    using System;
    using System.Runtime.Serialization;

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