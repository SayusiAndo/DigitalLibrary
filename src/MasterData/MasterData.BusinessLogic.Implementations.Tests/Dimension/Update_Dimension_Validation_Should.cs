// // <copyright file="Update_Dimension_Validation_Should.cs" company="Andras Csanyi">
// // Copyright (c) Andras Csanyi. All rights reserved.
// //  Licensed under MIT.
// // </copyright>
//
// namespace DigitalLibrary.MasterData.BusinessLogic.Implementations.Tests.Dimension
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
//     public class Update_Dimension_Validation_Should : SourceFormatFeature
//     {
//         public Update_Dimension_Validation_Should()
//             : base(TestInfo)
//         {
//         }
//
//         private const string TestInfo = nameof(Update_Dimension_Validation_Should);
//
//         [Theory]
//         [MemberData(
//             nameof(MasterData_Dimension_Validation_TestData.UpdateDimensionAsync_Validation),
//             MemberType = typeof(MasterData_Dimension_Validation_TestData))]
//         public void ThrowException_WhenInputIsInvalid(
//             long id,
//             string name,
//             string desc,
//             int isActive)
//         {
//             // Arrange
//             Dimension dimension = new Dimension
//             {
//                 Id = id,
//                 Name = name,
//                 Description = desc,
//                 IsActive = isActive,
//             };
//
//             // Act
//             Func<Task> action = async () =>
//             {
//                 await _masterDataBusinessLogic.UpdateDimensionAsync(dimension).ConfigureAwait(false);
//             };
//
//             // Assert
//             action.Should().ThrowExactly<MasterDataBusinessLogicUpdateDimensionAsyncOperationException>()
//                .WithInnerException<ValidationException>();
//         }
//
//         [Fact]
//         public void ThrowException_WhenInputsAreNull()
//         {
//             // Arrange
//
//             // Act
//             Func<Task> action = async () =>
//             {
//                 await _masterDataBusinessLogic.UpdateDimensionAsync(null)
//                    .ConfigureAwait(false);
//             };
//
//             // Assert
//             action.Should().ThrowExactly<MasterDataBusinessLogicUpdateDimensionAsyncOperationException>()
//                .WithInnerException<GuardException>();
//         }
//     }
// }

