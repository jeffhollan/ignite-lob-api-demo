using LOB_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LOB_API.Controllers
{
    public class BranchController : ApiController
    {
        [Swashbuckle.Swagger.Annotations.SwaggerResponse(HttpStatusCode.OK, "List of branches", typeof(List<Branch>))]
        [HttpGet, Route("api/branch")]
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(GenerateResponse.GenerateBranches());
        }

        [Swashbuckle.Swagger.Annotations.SwaggerResponse(HttpStatusCode.OK, "", typeof(Branch))]
        [HttpGet, Route("api/branch/{id}")]
        public HttpResponseMessage GetSingleBranch(string id)
        {
            return Request.CreateResponse(GenerateResponse.GenerateBranch());
        }

        [Swashbuckle.Swagger.Annotations.SwaggerResponse(HttpStatusCode.OK, "", typeof(Branch))]
        [HttpPut, Route("api/branch/{id}")]
        public HttpResponseMessage UpdateBranch(string id, [FromBody] Branch branch)
        {
            return Request.CreateResponse(branch);
        }

        [Swashbuckle.Swagger.Annotations.SwaggerResponse(HttpStatusCode.OK, "", typeof(Branch))]
        [HttpPost, Route("api/branch")]
        public HttpResponseMessage CreateBranch( [FromBody] Branch branch)
        {
            return Request.CreateResponse(branch);
        }
    }
}
