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
        [HttpGet, Route("api/branch")]
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(GenerateResponse.GenerateBranches());
        }

        [HttpGet, Route("api/branch/{id}")]
        public HttpResponseMessage GetSingleBranch(string id)
        {
            return Request.CreateResponse(GenerateResponse.GenerateBranch());
        }

        [HttpPut, Route("api/branch/{id}")]
        public HttpResponseMessage UpdateBranch(string id, [FromBody] Branch branch)
        {
            return Request.CreateResponse(branch);
        }

        [HttpPost, Route("api/branch")]
        public HttpResponseMessage CreateBranch( [FromBody] Branch branch)
        {
            return Request.CreateResponse(branch);
        }
    }
}
