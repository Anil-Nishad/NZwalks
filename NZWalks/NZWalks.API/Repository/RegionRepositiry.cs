using NZWalks.API.Data;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Repository
{
    public class RegionRepositiry : IRegionRepository
    {
        private readonly NZWalksDbContext nZWalksDbContext;

        public RegionRepositiry(NZWalksDbContext nZWalksDbContext)
        {
            this.nZWalksDbContext = nZWalksDbContext;
        }
        public IEnumerable<Region> GetAll()
        {
            // throw new NotImplementedException();
            return nZWalksDbContext.Regions.ToList();
        }
    }
}
