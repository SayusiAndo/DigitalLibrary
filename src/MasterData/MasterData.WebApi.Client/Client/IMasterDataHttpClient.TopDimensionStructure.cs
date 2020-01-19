namespace DigitalLibrary.MasterData.WebApi.Client
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using DomainModel;

    public partial interface IMasterDataHttpClient
    {
        Task<List<DimensionStructure>> GetTopDimensionStructuresAsync();

        Task<DimensionStructure> ModifyTopDimensionStructureAsync(DimensionStructure dimensionStructure);

        Task<DimensionStructure> AddTopDimensionStructureAsync(DimensionStructure dimensionStructure);

        Task DeleteTopDimensionStructureAsync(DimensionStructure dimensionStructure);
    }
}