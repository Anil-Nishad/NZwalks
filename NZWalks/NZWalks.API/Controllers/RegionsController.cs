using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Models.Domain;
using NZWalks.API.Repository;

namespace NZWalks.API.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    // or [Route("Region")]
    public class RegionsController : Controller
    {
        private readonly IRegionRepository regionRepository;

        //public IActionResult Index()
        //{
        //    return View();
        //}

        public RegionsController(IRegionRepository regionRepository)
        {
            this.regionRepository = regionRepository;
        }

        [HttpGet]
        public IActionResult GetAllRegions() 
        {
            var regions =  regionRepository.GetAll();

           //var regions = new List<Region>()
           //{ 
           //    new Region
           //    {
           //         Id = Guid.NewGuid(),
           //         Name= "Wellington",
           //         Code = "WLG",
           //         Area = 227755,
           //         Lat = -1.8822,
           //         Long = 299.88,
           //         Population = 500000
           //    },
           //    new Region
           //    {
           //         Id = Guid.NewGuid(),
           //         Name= "Auckland",
           //         Code = "AUCK",
           //         Area = 227755,
           //         Lat = -1.8822,
           //         Long = 299.88,
           //         Population = 500000
           //    }
           //};
            return Ok(regions);
        }
    }
}
