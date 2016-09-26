
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
        private static List<string> updatedProperties;
       
        private string logicAppUrl = @"https://prod-06.eastus.logic.azure.com:443/workflows/aea3bf0e58e141ab8605a7092b63e13c/triggers/manual/run?api-version=2016-06-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=nkmTUAZbMpKUQXqfsLklMqO5aNaqxmMIEUC3ZIdQ0HY";

        [HttpPost]
        public async System.Threading.Tasks.Task<HttpResponseMessage> Post()
        {
            updatedProperties = new List<string>();
            updatedProperties.Add("Business_Start_Date");
            Branch branch = new Branch
            {
                Title = "Ignite",
                Manager_Name = "Jeff Hollan",
                Manager_Email = "Jeff.Hollan@microsoft.com",
                Business_Start_Date = new DateTime(2016, 09, 26),
                Address = new Address
                {
                    Address_Line_1 = "123 Ignite Way",
                    city = "Atlanta",
                    state = "GA"
                },
                
                Lease_Start_Date = new DateTime(2016, 09, 1),
                Lease_End_Time = new DateTime(2017, 09, 1),
                UpdatedProperties = updatedProperties
            };
            using (var client = new HttpClient())
            {
                await client.PostAsJsonAsync<Branch>(logicAppUrl, branch);
            }
            return Request.CreateResponse(branch);

        }
    }
}
