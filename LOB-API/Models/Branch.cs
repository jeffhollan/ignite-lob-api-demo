using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LOB_API.Models
{
    public class Branch
    {
        
        public string Title { get; set; }
        public string Phone_Number { get; set; }
        public DateTime Business_Start_Date { get; set; }
        public string Manager_Name { get; set; }
        public string Manager_Email { get; set; }
        public string Manager_Phone { get; set; }
        
        public DateTime Lease_Start_Date { get; set; }
        public DateTime Lease_End_Time { get; set; }


        public List<string> UpdatedProperties { get; set; }
        public string id { get; set; }
        public Address Address { get; set; }
    }

    public class Address
    {
        public string Address_Line_1 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
    }
}