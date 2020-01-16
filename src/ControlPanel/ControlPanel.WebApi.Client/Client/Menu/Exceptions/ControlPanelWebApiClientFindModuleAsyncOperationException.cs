using System;
using System.Runtime.Serialization;

namespace DigitalLibrary.ControlPanel.WebApi.Client.Client.Menu.Exceptions
{
    public class ControlPanelWebApiClientFindModuleAsyncOperationException : Exception
    {
        public ControlPanelWebApiClientFindModuleAsyncOperationException()
        {
        }

        protected ControlPanelWebApiClientFindModuleAsyncOperationException(SerializationInfo? info,
                                                                            StreamingContext context) : base(info,
            context)
        {
        }

        public ControlPanelWebApiClientFindModuleAsyncOperationException(string? message) : base(message)
        {
        }

        public ControlPanelWebApiClientFindModuleAsyncOperationException(string? message, Exception? innerException) :
            base(message, innerException)
        {
        }
    }
}