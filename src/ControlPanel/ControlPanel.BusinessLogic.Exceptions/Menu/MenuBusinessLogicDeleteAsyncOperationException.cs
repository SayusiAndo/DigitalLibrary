// <copyright file="MenuBusinessLogicDeleteAsyncOperationException.cs" company="Andras Csanyi">
// Copyright (c) Andras Csanyi. All rights reserved.
//  Licensed under MIT.
// </copyright>

namespace DigitalLibrary.ControlPanel.BusinessLogic.Exceptions.Menu
{
    using System;
    using System.Runtime.Serialization;

    public class MenuBusinessLogicDeleteAsyncOperationException : Exception
    {
        public MenuBusinessLogicDeleteAsyncOperationException()
        {
        }

        protected MenuBusinessLogicDeleteAsyncOperationException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public MenuBusinessLogicDeleteAsyncOperationException(string message)
            : base(message)
        {
        }

        public MenuBusinessLogicDeleteAsyncOperationException(string message, Exception innerException)
            : base(message,
            innerException)
        {
        }
    }
}