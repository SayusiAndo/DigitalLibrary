// // <copyright file="Add_DimensionStructure_Validation_Should.cs" company="Andras Csanyi">
// // Copyright (c) Andras Csanyi. All rights reserved.
// //  Licensed under MIT.
// // </copyright>
//
// namespace DigitalLibrary.MasterData.BusinessLogic.Implementations.Tests.DimensionStructure
// {
//     using System;
//     using System.Diagnostics.CodeAnalysis;
//     using System.Threading.Tasks;
//
//     using DigitalLibrary.MasterData.BusinessLogic.Exceptions;
//     using DigitalLibrary.MasterData.BusinessLogic.Implementations.Tests.SourceFormat;
//     using DigitalLibrary.MasterData.DomainModel;
//     using DigitalLibrary.MasterData.Validators.TestData;
//     using DigitalLibrary.Utils.Guards;
//
//     using FluentAssertions;
//
//     using FluentValidation;
//
//     using Xunit;
//
//     [SuppressMessage("ReSharper", "InconsistentNaming", Justification = "Reviewed.")]
//     [ExcludeFromCodeCoverage]
//     [SuppressMessage("ReSharper", "CA1707", Justification = "Reviewed.")]
//     [SuppressMessage("ReSharper", "SA1600", Justification = "Reviewed.")]
//     public class Add_DimensionStructure_Validation_Should : SourceFormatFeature
//     {
//         public Add_DimensionStructure_Validation_Should()
//             : base(TestInfo)
//         {
//         }
//
//         private const string TestInfo = nameof(Add_DimensionStructure_Validation_Should);
//
//         [Theory]
//         [MemberData(
//             nameof(MasterData_DimensionStructure_Validation_TestData.AddDimensionStructure_Validation_TestData),
//             MemberType = typeof(MasterData_DimensionStructure_TestData))]
//         public void ThrowException_WhenInputIsInvalid(
//             long id,
//             string name,
//             string desc,
//             int isActive)
//         {
//             // Arrange
//             DimensionStructure dimensionStructure = new DimensionStructure
//             {
//                 Id = id,
//                 Name = name,
//                 Desc = desc,
//                 IsActive = isActive,
//             };
//
//             // Act
//             Func<Task> action = async () =>
//             {
//                 await _masterDataBusinessLogic.AddDimensionStructureAsync(dimensionStructure).ConfigureAwait(false);
//             };
//
//             // Assert
//             action.Should().ThrowExactly<MasterDataBusinessLogicAddDimensionStructureAsyncOperationException>()
//                .WithInnerException<ValidationException>();
//         }
//
//         [Fact]
//         public void ThrowException_WhenInputIsNull()
//         {
//             // Arrange
//
//             // Act
//             Func<Task> action = async () =>
//             {
//                 await _masterDataBusinessLogic.AddDimensionStructureAsync(null).ConfigureAwait(false);
//             };
//
//             // Assert
//             action.Should().ThrowExactly<MasterDataBusinessLogicAddDimensionStructureAsyncOperationException>()
//                .WithInnerException<GuardException>();
//         }
//     }
// }

