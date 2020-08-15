// <copyright file="IMasterDataHttpClient.Sourceformat.cs" company="Andras Csanyi">
// Copyright (c) Andras Csanyi. All rights reserved.
//  Licensed under MIT.
// </copyright>

namespace DigitalLibrary.MasterData.WebApi.Client
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using DigitalLibrary.MasterData.DomainModel;

    public partial interface IMasterDataHttpClient
    {
        /// <summary>
        ///     Adds a new Source Format.
        /// </summary>
        /// <param name="sourceFormat">The new Source Format.</param>
        /// <returns>
        ///     <para>200 Ok and newly created Source Format object.</para>
        ///     <para>If error happens returns 400 Bad Request and exception details.</para>
        /// </returns>
        Task<SourceFormat> AddSourceFormatAsync(SourceFormat sourceFormat);

        /// <summary>
        ///     Deletes the given Source Format.
        /// </summary>
        /// <param name="sourceFormat">Source format to be deleted.</param>
        /// <returns>
        ///     <para>Returns 200 Ok.</para>
        ///     <para>If error happens returns 400 Bad Request and exception details.</para>
        /// </returns>
        Task DeleteSourceFormatAsync(SourceFormat sourceFormat);

        Task<SourceFormat> GetSourceFormatById(SourceFormat sourceFormat);

        /// <summary>
        ///     Returns list of Source Formats.
        /// </summary>
        /// <returns>
        ///     <para>200 Ok and list of Source Formats.</para>
        ///     <para>If error happens returns 400 Bad Request and exception details.</para>
        /// </returns>
        Task<List<SourceFormat>> GetSourceFormatsAsync();

        Task<SourceFormat> GetSourceFormatWithFullDimensionStructureTreeAsync(SourceFormat querySourceFormat);

        /// <summary>
        ///     Updates existing Source Format.
        /// </summary>
        /// <param name="sourceFormat">Source Format object with Id and new details.</param>
        /// <returns>
        ///     <para>200 Ok and updated Source Format.</para>
        ///     <para>If error happens returns 400 Bad Request and exception details.</para>
        /// </returns>
        Task<SourceFormat> UpdateSourceFormatAsync(SourceFormat sourceFormat);
    }
}