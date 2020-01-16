using System;
using System.Runtime.Serialization;

namespace DigitalLibrary.ControlPanel.BusinessLogic.Exceptions.Menu
{
    public class MenuGetAllAsyncOperationException : Exception
    {
        public MenuGetAllAsyncOperationException()
        {
        }

        protected MenuGetAllAsyncOperationException(SerializationInfo info, StreamingContext context) : base(info,
            context)
        {
        }

        public MenuGetAllAsyncOperationException(string message) : base(message)
        {
        }

        public MenuGetAllAsyncOperationException(string message, Exception innerException) : base(message,
            innerException)
        {
        }
    }
}