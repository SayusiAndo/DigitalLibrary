using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace DigitalLibrary.MasterData.BusinessLogic.Exceptions.Exceptions
{
    [ExcludeFromCodeCoverage]
    public class MasterDataBusinessLogicAddDimensionAsyncOperationException : Exception
    {
        public MasterDataBusinessLogicAddDimensionAsyncOperationException()
        {
        }

        protected MasterDataBusinessLogicAddDimensionAsyncOperationException(SerializationInfo? info,
                                                                             StreamingContext context) : base(info,
            context)
        {
        }

        public MasterDataBusinessLogicAddDimensionAsyncOperationException(string? message) : base(message)
        {
        }

        public MasterDataBusinessLogicAddDimensionAsyncOperationException(string? message, Exception? innerException) :
            base(message, innerException)
        {
        }
    }
}