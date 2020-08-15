// <copyright file="MasterDataValidatorFacadeArgumentNullException.cs" company="Andras Csanyi">
// Copyright (c) Andras Csanyi. All rights reserved.
//  Licensed under MIT.
// </copyright>

namespace DigitalLibrary.MasterData.Validators
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.Serialization;

    [ExcludeFromCodeCoverage]
    public class MasterDataValidatorFacadeArgumentNullException : Exception
    {
        public MasterDataValidatorFacadeArgumentNullException()
        {
        }

        protected MasterDataValidatorFacadeArgumentNullException(SerializationInfo? info, StreamingContext context)
            : base(info, context)
        {
        }

        public MasterDataValidatorFacadeArgumentNullException(string? message)
            : base(message)
        {
        }

        public MasterDataValidatorFacadeArgumentNullException(string? message, Exception? innerException)
            : base(
            message, innerException)
        {
        }
    }
}