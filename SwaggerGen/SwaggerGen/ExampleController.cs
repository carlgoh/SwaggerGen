using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SwaggerGen
{
    [Route("example")]
    [ApiController]
    public class ExampleController : ControllerBase
    {
        [HttpGet]
        public ActionResult<Occupant> GetTodoItems()
        {
            return new Occupant();
        }
    }
    
    public class Occupant
    {
        public string OccupantNumber { get; set; }
        public string Property { get; set; }
        public string OccupantName { get; set; }
        public string LandUse { get; set; }
        public string LocalGovDescription { get; set; }
        public string SiteValue { get; set; }
        public string CaptialValue { get; set; }
        public string NotionalValue { get; set; }
        public string NotionalCapitalValue { get; set; }
        public string NotionalType { get; set; }
    }
}