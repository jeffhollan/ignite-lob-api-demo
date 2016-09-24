using LOB_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOB_API
{
    public static class GenerateResponse
    {
        public static List<Branch> GenerateBranches()
        {
            var branches = new List<Branch>();
            for(int x = 0; x < 200; x++)
            {
                branches.Add(GenerateBranch());
            }
            return branches;
        }

        public static Branch GenerateBranch()
        {
            return new Branch
            {
                Address = new Models.Address
                {
                    Address_Line_1 = "123 Logic Apps Ave",
                    city = "Atlanata",
                    state = "GA",
                    zip = "98052"
                },
                Name = "Main Branch",
                Phone_Number = "425 555 5555",
                Manager_Email = "jeff.hollan@microsoft.com",
                Manager_Name = "Jeff Hollan",
                Manager_Phone = "801 368 2822",
                Close_Hour = "17:00",
                Open_Hour = "8:00",
                Lease_End_Time = new DateTime(2017, 12, 15),
                Lease_Start_Date = new DateTime(2016, 12, 16)
            };
        }
    }
}