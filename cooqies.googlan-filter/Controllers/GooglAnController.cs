using System.Web.Http;
using cooqies.googlan_filter.Filters;

namespace cooqies.googlan_filter.Controllers
{
    public class GooglAnController : ApiController
    {
        [GooglAnFilter]
        [HttpGet]
        public IHttpActionResult Index()
        {
            return Ok("Google Analytics is watching you.");
        }
    }
}
