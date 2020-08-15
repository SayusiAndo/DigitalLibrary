// <copyright file="MenuModifyOperationException.cs" company="Andras Csanyi">
// Copyright (c) Andras Csanyi. All rights reserved.
//  Licensed under MIT.
// </copyright>

namespace DigitalLibrary.ControlPanel.BusinessLogic.Exceptions.Menu
{
    using System;
    using System.Runtime.Serialization;

    public class MenuModifyOperationException : Exception
    {
        public MenuModifyOperationException()
        {
        }

        protected MenuModifyOperationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public MenuModifyOperationException(string message) : base(message)
        {
        }

        public MenuModifyOperationException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}