// // <copyright file="Delete_DimensionStructure_Should.cs" company="Andras Csanyi">
// // Copyright (c) Andras Csanyi. All rights reserved.
// //  Licensed under MIT.
// // </copyright>
//
// namespace DigitalLibrary.MasterData.BusinessLogic.Implementations.Tests.DimensionStructure
// {
//     using System;
//     using System.Collections.Generic;
//     using System.Diagnostics.CodeAnalysis;
//     using System.Linq;
//     using System.Threading.Tasks;
//
//     using DigitalLibrary.MasterData.BusinessLogic.Exceptions;
//     using DigitalLibrary.MasterData.BusinessLogic.Implementations.Tests.SourceFormat;
//     using DigitalLibrary.MasterData.DomainModel;
//     using DigitalLibrary.Utils.Guards;
//
//     using FluentAssertions;
//
//     using Xunit;
//
//     [SuppressMessage("ReSharper", "InconsistentNaming", Justification = "Reviewed.")]
//     [ExcludeFromCodeCoverage]
//     [SuppressMessage("ReSharper", "CA1707", Justification = "Reviewed.")]
//     [SuppressMessage("ReSharper", "SA1600", Justification = "Reviewed.")]
//     public class Delete_DimensionStructure_Should : SourceFormatFeature
//     {
//         public Delete_DimensionStructure_Should()
//             : base(TestInfo)
//         {
//         }
//
//         private const string TestInfo = nameof(Delete_DimensionStructure_Should);
//
//         [Fact]
//         public async Task Delete_AnItem()
//         {
//             // Arrange
//             List<DimensionStructure> initList = await _masterDataBusinessLogic.GetDimensionStructuresAsync()
//                .ConfigureAwait(false);
//             DimensionStructure dimensionStructure = new DimensionStructure
//             {
//                 Name = "name",
//                 Desc = "desc",
//                 IsActive = 1,
//             };
//             DimensionStructure dimensionStructureResult = await _masterDataBusinessLogic.AddDimensionStructureAsync(
//                     dimensionStructure)
//                .ConfigureAwait(false);
//
//             DimensionStructure dimensionStructure2 = new DimensionStructure
//             {
//                 Name = "name2",
//                 Desc = "desc2",
//                 IsActive = 1,
//             };
//             DimensionStructure dimensionStructure2Result = await _masterDataBusinessLogic.AddDimensionStructureAsync(
//                     dimensionStructure2)
//                .ConfigureAwait(false);
//
//             // Act
//             await _masterDataBusinessLogic.DeleteDimensionStructureAsync(dimensionStructure2Result)
//                .ConfigureAwait(false);
//
//             // Assert
//             List<DimensionStructure> result = await _masterDataBusinessLogic.GetDimensionStructuresAsync()
//                .ConfigureAwait(false);
//             result.Count.Should().Be(initList.Count + 1);
//             result.Where(p => p.Name == dimensionStructure.Name).ToList().Count.Should().Be(1);
//             result.Where(p => p.Name == dimensionStructure2.Name).ToList().Count.Should().Be(0);
//         }
//
//         [Fact]
//         public void ThrowException_WhenThereIsNoSuchDimensionStructure()
//         {
//             // Arrange
//             DimensionStructure dimensionStructure = new DimensionStructure
//             {
//                 Id = 1000,
//             };
//
//             // Act
//             Func<Task> action = async () =>
//             {
//                 await _masterDataBusinessLogic.DeleteDimensionStructureAsync(dimensionStructure)
//                    .ConfigureAwait(false);
//             };
//
//             // Assert
//             action.Should().ThrowExactly<MasterDataBusinessLogicDeleteDimensionStructureAsyncOperationException>()
//                .WithInnerException<GuardException>();
//         }
//     }
// }

