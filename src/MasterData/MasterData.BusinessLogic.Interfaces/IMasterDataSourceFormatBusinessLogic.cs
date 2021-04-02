// <copyright file="IMasterDataBusinessLogic.SourceFormat.cs" company="Andras Csanyi">
// Copyright (c) Andras Csanyi. All rights reserved.
//  Licensed under MIT.
// </copyright>

namespace DigitalLibrary.MasterData.BusinessLogic.Interfaces
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    using DigitalLibrary.MasterData.DomainModel;

    /// <summary>
    ///     MasterDataBusinessLogic interface for <see cref="SourceFormat" />s.
    /// </summary>
    public interface IMasterDataSourceFormatBusinessLogic
    {
        /// <summary>
        ///     Adds a <see cref="DimensionStructureNode" /> to <see cref="SourceFormat" /> as
        ///     root dimension structure node.
        /// </summary>
        /// <param name="sourceFormatId">Source format id.</param>
        /// <param name="dimensionStructureNodeId">Dimension structure id.</param>
        /// <param name="cancellationToken"><see cref="CancellationToken"/>.</param>
        /// <returns>
        /// <see cref="Task"/> representing result of asynchronous operation.
        /// </returns>
        /// <exception cref="MasterDataBusinessLogicSourceFormatDatabaseOperationException">
        ///     An error happened during database operation.
        /// </exception>
        Task AddRootDimensionStructureNodeAsync(
            long sourceFormatId,
            long dimensionStructureNodeId,
            CancellationToken cancellationToken = default);

        /// <summary>
        ///     Adds a new <see cref="SourceFormat" /> to the system.
        /// </summary>
        /// <param name="sourceFormat">New SourceFormant.</param>
        /// <param name="cancellationToken">
        ///     <see cref="CancellationToken" /> token.
        /// </param>
        /// <returns>
        ///     Returns a <see cref="Task" /> representing the result of asynchronous operation.
        /// </returns>
        /// <exception cref="MasterDataBusinessLogicSourceFormatDatabaseOperationException">
        ///     An error happened during database operation.
        /// </exception>
        Task<SourceFormat> AddAsync(
            SourceFormat sourceFormat,
            CancellationToken cancellationToken = default);

        Task<long> CountSourceFormatsAsync();

        /// <summary>
        ///     Deletes the defined <see cref="SourceFormat" /> from the system.
        ///     The Id property of the provided instance defines which <see cref="SourceFormat" /> is going to be
        ///     deleted.
        /// </summary>
        /// <param name="target">
        ///     The <see cref="SourceFormat" /> object going to be deleted.
        /// </param>
        /// <param name="cancellationToken"><see cref="CancellationToken" />.</param>
        /// <returns>
        ///     Returns a <see cref="Task{TResult}" /> representing the result of an asynchronous operation.
        /// </returns>
        /// <exception cref="MasterDataBusinessLogicSourceFormatDatabaseOperationException">
        ///     An error happened during database operation.
        /// </exception>
        Task DeleteAsync(
            SourceFormat target,
            CancellationToken cancellationToken = default);

        /// <summary>
        ///     Finds and returns with a <see cref="SourceFormat" /> by Id.
        /// </summary>
        /// <param name="sourceFormat">Contains the Id of the queried <see cref="SourceFormat" />.</param>
        /// <param name="cancellationToken"><see cref="CancellationToken" />.</param>
        /// <returns>
        ///     Returns a <see cref="Task{TResult}" /> representing the result of an asynchronous operation.
        /// </returns>
        /// <exception cref="MasterDataBusinessLogicSourceFormatDatabaseOperationException">
        ///     An error happened during database operation.
        /// </exception>
        Task<SourceFormat> GetByIdAsync(
            SourceFormat sourceFormat,
            CancellationToken cancellationToken = default);

        /// <summary>
        ///     Returns <see cref="SourceFormat" /> which has both active and inactive
        ///     <see cref="DimensionStructureNode" />s and
        ///     <see cref="DimensionStructure" />s attached too.
        /// </summary>
        /// <param name="sourceFormat">Queryobject.</param>
        /// <returns>SourceFormat or null.</returns>
        Task<SourceFormat> GetSourceFormatByIdWithAllDimensionStructuresAndNodesAsync(SourceFormat sourceFormat);

        /// <summary>
        ///     Returns with <see cref="SourceFormat" /> which has only <see cref="DimensionStructureNode" />s
        ///     where the <see cref="DimensionStructure" /> is active.
        /// </summary>
        /// <param name="querySourceFormat">Query object.</param>
        /// <returns>SourceFormat or null.</returns>
        Task<SourceFormat> GetSourceFormatByIdWithActiveOnlyDimensionStructuresInTheTreeAsync(
            SourceFormat querySourceFormat);

        /// <summary>
        ///     Returns with <see cref="SourceFormat" /> which has the <see cref="DimensionStructure" /> tree
        ///     attached. It includes both active and inactive nodes.
        /// </summary>
        /// <param name="querySourceFormat">SourceFormat query object.</param>
        /// <returns>SourceFormat or null.</returns>
        Task<SourceFormat> GetSourceFormatByIdWithDimensionStructureNodeTreeAsync(SourceFormat querySourceFormat);

        /// <summary>
        ///     Returns with <see cref="SourceFormat" /> which brings its root <see cref="DimensionStructure" />.
        /// </summary>
        /// <param name="querySourceFormat">Query object.</param>
        /// <returns>Result or null.</returns>
        Task<SourceFormat> GetSourceFormatByIdWithRootDimensionStructureAsync(SourceFormat querySourceFormat);

        /// <summary>
        ///     It returns a <see cref="SourceFormat" /> without its related entities.
        /// </summary>
        /// <param name="sourceFormat">SourceFormat query object.</param>
        /// <returns>The result.</returns>
        Task<SourceFormat> GetSourceFormatByNameAsync(SourceFormat sourceFormat);

        /// <summary>
        ///     Returns with <see cref="SourceFormat" /> which contains the full <see cref="DimensionStructure" />
        ///     tree.
        /// </summary>
        /// <param name="sourceFormat">SourceFormat query object.</param>
        /// <returns>The result.</returns>
        Task<SourceFormat> GetSourceFormatByNameWithFullDimensionStructureTreeAsync(SourceFormat sourceFormat);

        /// <summary>
        ///     It returns a <see cref="SourceFormat" /> with its RootDimensionStructure attached.
        /// </summary>
        /// <param name="sourceFormat">SourceFormat query object.</param>
        /// <returns>The result.</returns>
        Task<SourceFormat> GetSourceFormatByNameWithRootDimensionStructureAsync(SourceFormat sourceFormat);

        /// <summary>
        ///     Returns list of <see cref="SourceFormat" /> which includes both active and inactive ones.
        /// </summary>
        /// <param name="cancellationToken"> <see cref="CancellationToken" />. </param>
        /// <returns>
        ///     Returns with a <see cref="Task{TResult}" /> which contains a <see cref="List{T}" /> containing
        ///     the <see cref="SourceFormat" /> objects available in the system.
        /// </returns>
        /// <exception cref="MasterDataBusinessLogicSourceFormatDatabaseOperationException">
        ///     An error happened during database operation.
        /// </exception>
        Task<List<SourceFormat>> GetSourceFormatsAsync(CancellationToken cancellationToken = default);

        /// <summary>
        ///     Updates t<see cref="SourceFormat" /> stored in the system.
        /// </summary>
        /// <param name="sourceFormat">
        ///     Instance of <see cref="SourceFormat" /> where the Id identifies the <see cref="SourceFormat" />
        ///     going to be updated. Other parameters this payload object represents the new values.
        /// </param>
        /// <param name="cancellationToken"><see cref="CancellationToken" />.</param>
        /// <returns>
        ///     Returns a <see cref="Task{TResult}" /> representing the result of an asynchronous operation.
        /// </returns>
        /// <exception cref="MasterDataBusinessLogicSourceFormatDatabaseOperationException">
        ///     An error happened during database operation.
        /// </exception>
        Task<SourceFormat> UpdateAsync(
            SourceFormat sourceFormat,
            CancellationToken cancellationToken = default);

        /// <summary>
        ///     Returns with <see cref="SourceFormat" /> with its <see cref="DimensionStructure" /> tree attached.
        ///     It contains only the active tree.
        /// </summary>
        /// <param name="sourceFormatId">SourceFormat id.</param>
        /// <param name="cancellationToken">
        ///     <see cref="CancellationToken" />Cancellation token.
        /// </param>
        /// <returns>
        ///     A task contains the SourceFormat.
        /// </returns>
        /// <exception cref="MasterDataBusinessLogicSourceFormatDatabaseOperationException">
        ///     An error happened during database operation.
        /// </exception>
        Task<SourceFormat> GetSourceFormatByIdWithActiveDimensionStructureTreeAsync(
            long sourceFormatId,
            CancellationToken cancellationToken = default);

        /// <summary>
        ///     Returns with <see cref="DimensionStructureNode" /> which represents a node in the tree which
        ///     describes a document structure.
        /// </summary>
        /// <param name="sourceFormatId">
        ///     <see cref="SourceFormat" /> id.
        /// </param>
        /// <param name="dimensionStructureId">
        ///     <see cref="DimensionStructure" /> id.
        /// </param>
        /// <param name="cancellationToken">
        ///     <see cref="CancellationToken" /> token.
        /// </param>
        /// <returns>
        ///     Task containing <see cref="DimensionStructure" />.
        /// </returns>
        /// <exception cref="MasterDataBusinessLogicSourceFormatDatabaseOperationException">
        ///     Error happened during database operation.
        /// </exception>
        Task<DimensionStructureNode> GetNodeAsync(
            long sourceFormatId,
            long dimensionStructureId,
            CancellationToken cancellationToken = default);

        /// <summary>
        ///     Queries the active <see cref="SourceFormat" />s from the database and returns a list of them.
        /// </summary>
        /// <param name="cancellationToken">
        ///     <see cref="CancellationToken" />
        /// </param>
        /// <returns>
        ///     Returns a <see cref="Task{TResult}" /> contains a <see cref="List{T}" /> of <see cref="SourceFormat" />s
        ///     objects. All of them active.
        ///     If there are no active <see cref="SourceFormat" /> in the system it returns with an empty list.
        /// </returns>
        /// <exception cref="MasterDataBusinessLogicSourceFormatDatabaseOperationException">
        ///     Error happened during database operation.
        /// </exception>
        Task<List<SourceFormat>> GetActivesAsync(CancellationToken cancellationToken = default);

        /// <summary>
        ///     Queries the inactive <see cref="SourceFormat" />s from the database and returns a list of them.
        /// </summary>
        /// <param name="cancellationToken">
        ///     <see cref="CancellationToken" />
        /// </param>
        /// <returns>
        ///     Returns a <see cref="Task{TResult}" /> containing a <see cref="List{T}" /> of <see cref="SourceFormat" />s
        ///     objects. All of them inactive.
        ///     If there is not inactive <see cref="SourceFormat" /> in the system, then it returns with an empty
        ///     <see cref="List{T}" />.
        /// </returns>
        /// <exception cref="MasterDataBusinessLogicSourceFormatDatabaseOperationException">
        ///     Error happened during database operation.
        /// </exception>
        Task<List<SourceFormat>> GetInActives(CancellationToken cancellationToken = default);

        /// <summary>
        ///     Inactivates the given <see cref="SourceFormat" />.
        /// </summary>
        /// <param name="sourceFormat">
        ///     The <see cref="SourceFormat" /> going to be inactivated.
        /// </param>
        /// <param name="cancellationToken"><see cref="CancellationToken" />.</param>
        /// <returns><see cref="Task" /> represents the operation result.</returns>
        /// <exception cref="MasterDataBusinessLogicSourceFormatDatabaseOperationException">
        ///     Error happened during database operation.
        /// </exception>
        Task InactivateAsync(
            SourceFormat sourceFormat,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Removes root <see cref="DimensionStructureNode"/> of <see cref="SourceFormat"/> from the data structure.
        /// The <see cref="DimensionStructureNode"/> is not going to be deleted, only removed from
        /// <see cref="SourceFormat"/>.
        /// </summary>
        /// <param name="sourceFormat">The <see cref="SourceFormat"/>
        ///     where the <see cref="DimensionStructureNode"/> going to be removed.</param>
        /// <param name="cancellationToken"><see cref="CancellationToken"/>.</param>
        /// <returns><see cref="Task"/> representing result of async operations.</returns>
        /// <exception cref="MasterDataBusinessLogicSourceFormatDatabaseOperationException">
        ///     Error happened during database operation.
        /// </exception>
        Task RemoveRootDimensionStructureNodeAsync(
            SourceFormat sourceFormat,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Appends the given <see cref="DimensionStructureNode"/> to given <see cref="DimensionStructureNode"/> as
        /// child in the context of <see cref="SourceFormat"/>. 
        /// </summary>
        /// <param name="toBeAddedId">
        ///     Id of the to be added <see cref="DimensionStructureNode"/> entity.
        /// </param>
        /// <param name="parentId">
        ///     Id of the future parent <see cref="DimensionStructureNode"/> entity.
        /// </param>
        /// <param name="sourceFormatId">
        ///     Id of the <see cref="SourceFormat"/> entity which owns the tree.
        /// </param>
        /// <param name="cancellationToken"><see cref="CancellationToken"/>.</param>
        /// <returns>
        ///     Returns <see cref="Task"/> representing result of an asynchronous operation.
        /// </returns>
        /// <exception cref="MasterDataBusinessLogicSourceFormatDatabaseOperationException">
        ///     Error happened during database operation.
        /// </exception>
        Task AppendDimensionStructureNodeToTreeAsync(
            long toBeAddedId,
            long parentId,
            long sourceFormatId,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Removes <see cref="DimensionStructureNode"/> from the DimensionStructureNode tree within <see cref="SourceFormat"/>.
        /// The node is going to be deleted from database as it only has a single connection.
        /// </summary>
        /// <param name="id">Id of object to be removed.</param>
        /// <param name="parentId">Id of parent object.</param>
        /// <param name="sourceFormatId">Id of SourceFormat.</param>
        /// <param name="cancellationToken"><see cref="CancellationToken"/>.</param>
        /// <returns>Returns <see cref="Task"/> representing result of asynchronous operation.</returns>
        /// <exception cref="MasterDataBusinessLogicSourceFormatDatabaseOperationException">
        ///     Error happened during database operation.
        /// </exception>
        Task DeleteDimensionStructureNodeFromTreeAsync(
            long id,
            long parentId,
            long sourceFormatId,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns a <see cref="DimensionStructureNode"/> entity identified by the passed Id value.
        /// It returns null if there is no entity with specified id.
        ///
        /// The returned entity contains its parent too.
        /// </summary>
        /// <param name="nodeId">Id identifies the entity should be returned.</param>
        /// <param name="cancellationToken"><see cref="CancellationToken"/>.</param>
        /// <returns>
        /// Returns <see cref="Task{TResult}"/> representing result of asynchronous operation. The
        /// <see cref="Task{TResult}"/> includes either a null, if there is no entity with specified id,
        /// or with <see cref="DimensionStructureNode"/> entity which includes its parent.
        /// </returns>
        /// <exception cref="MasterDataDimensionStructureNodeBusinessLogicException">
        ///     Whatever issue happens.
        /// </exception>
        Task<DimensionStructureNode> GetDimensionStructureNodeByIdWithParentAsync(
            long nodeId,
            CancellationToken cancellationToken = default);
    }
}