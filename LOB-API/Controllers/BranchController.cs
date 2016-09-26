using LOB_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TRex.Metadata;

namespace LOB_API.Controllers
{
    public class BranchController : ApiController
    {
        [Metadata("Get branches", "Lists all registered branches")]
        [Swashbuckle.Swagger.Annotations.SwaggerResponse(HttpStatusCode.OK, "List of branches", typeof(List<Branch>))]
        [HttpGet, Route("api/branch")]
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(GenerateResponse.GenerateBranches());
        }

        [Metadata("Get branch", "Retreive a branch by ID")]
        [Swashbuckle.Swagger.Annotations.SwaggerResponse(HttpStatusCode.OK, "", typeof(Branch))]
        [HttpGet, Route("api/branch/{id}")]
        public HttpResponseMessage GetSingleBranch(string id)
        {
            return Request.CreateResponse(GenerateResponse.GenerateBranch());
        }

        [Metadata("Update branch", "Update a branch by ID")]
        [Swashbuckle.Swagger.Annotations.SwaggerResponse(HttpStatusCode.OK, "", typeof(Branch))]
        [HttpPut, Route("api/branch/{id}")]
        public HttpResponseMessage UpdateBranch(string id, [FromBody] Branch branch)
        {
            return Request.CreateResponse(branch);
        }

        [Metadata("Create branch", "Register a new branch")]
        [Swashbuckle.Swagger.Annotations.SwaggerResponse(HttpStatusCode.OK, "", typeof(Branch))]
        [HttpPost, Route("api/branch")]
        public HttpResponseMessage CreateBranch( [FromBody] Branch branch)
        {
            return Request.CreateResponse(branch);
        }
    }
}
