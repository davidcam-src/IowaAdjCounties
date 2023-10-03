using IowaAdjCounties.entities;
using Microsoft.AspNetCore.Mvc;


namespace IowaAdjCounties.Controllers
{
    [ApiController]
    [Route("api/checkAdjacency")]
    public class MainController : ControllerBase
    {
        private readonly CountyDbContext _context;

        public MainController(CountyDbContext context)
        {
            _context = context;
        }


        // CheckAdjacency:
            // Summary ----
            // Checks if two counties are adjacent based on their FIPS codes. Returns a boolean value. 
            // Params ----
            // countyCode1: FIPS code of the first county
            // countyCode2: FIPS code of the second county
        [HttpGet]
        public ActionResult<bool> CheckAdjacency(int countyCode1, int countyCode2)
        {
            // Story, Greene, Tama Codes
            int[] relevantCountyCodes = { 169, 73, 171 };

            if (!relevantCountyCodes.Contains(countyCode1) && 
                !relevantCountyCodes.Contains(countyCode2))
            {
                return BadRequest("Either countyCode1 or countyCode2 must correspond to Story, Greene or Tama.");
            }

            bool isAdjacent = _context.CountyAdjacency.Any(ca =>
                    (ca.CountyID == countyCode1 && ca.AdjacentCountyID == countyCode2) ||
                    (ca.CountyID == countyCode2 && ca.AdjacentCountyID == countyCode1));

            if (isAdjacent)
            {
                return Ok(true);
            }
            else {
                return Ok(false);
            }
        }
    }
}