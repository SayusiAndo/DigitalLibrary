// <copyright file="MasterDataBusinessLogicGetDimensionStructuresAsyncException.cs" company="Andras Csanyi">
// Copyright (c) Andras Csanyi. All rights reserved.
//  Licensed under MIT.
// </copyright>

namespace DigitalLibrary.MasterData.BusinessLogic.Exceptions
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.Serialization;

    [ExcludeFromCodeCoverage]
    public class MasterDataBusinessLogicGetDimensionStructuresAsyncException : Exception
    {
        public MasterDataBusinessLogicGetDimensionStructuresAsyncException()
        {
        }

        protected MasterDataBusinessLogicGetDimensionStructuresAsyncException(
            SerializationInfo? info,
            StreamingContext context) : base(info, context)
        {
        }

        public MasterDataBusinessLogicGetDimensionStructuresAsyncException(string? message) : base(message)
        {
        }

        public MasterDataBusinessLogicGetDimensionStructuresAsyncException(string? message, Exception? innerException) :
            base(message, innerException)
        {
        }
    }
}