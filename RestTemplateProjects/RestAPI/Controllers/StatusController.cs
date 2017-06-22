

namespace RestAPI.Controllers
{
    using System.Web.Http;

    /// <summary>
    /// Status Controller To Verify Endpoint Status
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    [RoutePrefix("api")]
    public class StatusController : ApiController
    {
        /// <summary>
        /// Gets the status.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("status")]
        public IHttpActionResult GetStatus()
        {
            var response = "RestAPI v0.1";

            return this.Ok(response);
        }
    }
}