namespace DigitalLibrary.IaC.MasterData.BusinessLogic.Exceptions.Exceptions
{
    using System;
    using System.Runtime.Serialization;

    public class MasterDataBusinessLogicGetDimensionsWithoutStructureAsyncOperationException : Exception
    {
        public MasterDataBusinessLogicGetDimensionsWithoutStructureAsyncOperationException()
        {
        }

        protected MasterDataBusinessLogicGetDimensionsWithoutStructureAsyncOperationException(
            SerializationInfo? info,
            StreamingContext context) : base(info, context)
        {
        }

        public MasterDataBusinessLogicGetDimensionsWithoutStructureAsyncOperationException(string? message) :
            base(message)
        {
        }

        public MasterDataBusinessLogicGetDimensionsWithoutStructureAsyncOperationException(
            string? message,
            Exception? innerException) : base(message, innerException)
        {
        }
    }
}