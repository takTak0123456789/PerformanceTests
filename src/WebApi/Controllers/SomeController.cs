using LegacyLib.Dto;
using LegacyLib.Service;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class SomeController : ApiController
    {
        [HttpPost]
        public IHttpActionResult Post([FromBody] RequestDto request)
        {
            var someLegacyService = new SomeLegacyService();
            return Ok(someLegacyService.CalculateSomething(request));
        }
    }

}
