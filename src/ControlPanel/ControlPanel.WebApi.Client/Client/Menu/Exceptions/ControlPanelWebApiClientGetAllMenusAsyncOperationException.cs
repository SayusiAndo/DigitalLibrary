// <copyright file="ControlPanelWebApiClientGetAllMenusAsyncOperationException.cs" company="Andras Csanyi">
// Copyright (c) Andras Csanyi. All rights reserved.
//  Licensed under MIT.
// </copyright>

namespace DigitalLibrary.ControlPanel.WebApi.Client.Menu.Exceptions
{
    using System;
    using System.Runtime.Serialization;

    public class ControlPanelWebApiClientGetAllMenusAsyncOperationException : Exception
    {
        public ControlPanelWebApiClientGetAllMenusAsyncOperationException()
        {
        }

        protected ControlPanelWebApiClientGetAllMenusAsyncOperationException(SerializationInfo info,
                                                                             StreamingContext context)
            : base(info, context)
        {
        }

        public ControlPanelWebApiClientGetAllMenusAsyncOperationException(string message)
            : base(message)
        {
        }

        public ControlPanelWebApiClientGetAllMenusAsyncOperationException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}