// Digital Library project
// https://github.com/SayusiAndo/DigitalLibrary
// Copyright (c) Andras Csanyi. All rights reserved.
// Licensed under MIT License

namespace DigitalLibrary.ControlPanel.BusinessLogic.Exceptions.Module
{
    using System;
    using System.Runtime.Serialization;

    public class ModuleDoesNotExistsException : Exception
    {
        public ModuleDoesNotExistsException()
        {
        }

        protected ModuleDoesNotExistsException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public ModuleDoesNotExistsException(string message)
            : base(message)
        {
        }

        public ModuleDoesNotExistsException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}