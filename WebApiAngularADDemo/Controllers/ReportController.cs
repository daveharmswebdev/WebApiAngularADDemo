using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web.Resource;

namespace WebApiAngularADDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [RequiredScope(RequiredScopesConfigurationKey = "AzureAd:scopes")]
    public class ReportController : ControllerBase
    {
        [HttpGet("[action]")]
        public IActionResult GetReportNoAuth()
        {
            return Ok(new {message = "Test No Auth"});
        }
        
        [HttpGet("[action]")]
        [Authorize]
        public IActionResult GetReportAuth()
        {
            return Ok(new {message = "Test Auth"});
        }
        
        [HttpGet("[action]")]
        [Authorize(Roles = "Manager")]
        public IActionResult GetReportManager()
        {
            return Ok(new {message = "Test Manager"});
        }
    }
}