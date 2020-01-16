using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace DigitalLibrary.MasterData.BusinessLogic.Exceptions.Exceptions
{
    [ExcludeFromCodeCoverage]
    public class MasterDataBusinessLogicNoSuchDimensionValueEntity : Exception
    {
        public MasterDataBusinessLogicNoSuchDimensionValueEntity()
        {
        }

        protected MasterDataBusinessLogicNoSuchDimensionValueEntity(SerializationInfo? info, StreamingContext context) :
            base(info, context)
        {
        }

        public MasterDataBusinessLogicNoSuchDimensionValueEntity(string? message) : base(message)
        {
        }

        public MasterDataBusinessLogicNoSuchDimensionValueEntity(string? message, Exception? innerException) : base(
            message, innerException)
        {
        }
    }
}