
using LOB_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Logic_App_Trigger.Controllers
{
    public class RunController : ApiController
    {
        private Branch branch = new Branch
        {
            Address = new Address
            {
                state = "WA"
            }
        };
        private string logicAppUrl = @"https://prod-06.eastus.logic.azure.com:443/workflows/aea3bf0e58e141ab8605a7092b63e13c/triggers/manual/run?api-version=2016-06-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=nkmTUAZbMpKUQXqfsLklMqO5aNaqxmMIEUC3ZIdQ0HY";

        [HttpPost]
        public async System.Threading.Tasks.Task<HttpResponseMessage> Post()
        {
            using (var client = new HttpClient())
            {
                return await client.PostAsJsonAsync<Branch>(logicAppUrl, branch);
            }

        }
    }
}
