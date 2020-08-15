// <copyright file="MenuGetAllAsyncOperationException.cs" company="Andras Csanyi">
// Copyright (c) Andras Csanyi. All rights reserved.
//  Licensed under MIT.
// </copyright>

namespace DigitalLibrary.ControlPanel.BusinessLogic.Exceptions.Menu
{
    using System;
    using System.Runtime.Serialization;

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