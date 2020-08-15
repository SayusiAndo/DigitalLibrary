// <copyright file="MasterDataBusinessLogicGetSourceFormatByIdWithDimensionStructureTreeAsyncOperationException.cs" company="Andras Csanyi">
// Copyright (c) Andras Csanyi. All rights reserved.
//  Licensed under MIT.
// </copyright>

namespace DigitalLibrary.MasterData.BusinessLogic.Exceptions
{
    using System;
    using System.Runtime.Serialization;

    public class MasterDataBusinessLogicGetSourceFormatByIdWithDimensionStructureTreeAsyncOperationException
        : Exception
    {
        public MasterDataBusinessLogicGetSourceFormatByIdWithDimensionStructureTreeAsyncOperationException()
        {
        }

        protected MasterDataBusinessLogicGetSourceFormatByIdWithDimensionStructureTreeAsyncOperationException(
            SerializationInfo? info,
            StreamingContext context) : base(info, context)
        {
        }

        public MasterDataBusinessLogicGetSourceFormatByIdWithDimensionStructureTreeAsyncOperationException(
            string? message) : base(message)
        {
        }

        public MasterDataBusinessLogicGetSourceFormatByIdWithDimensionStructureTreeAsyncOperationException(
            string? message,
            Exception? innerException) : base(message, innerException)
        {
        }
    }
}