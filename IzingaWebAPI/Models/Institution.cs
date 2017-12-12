using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IzingaWebAPI.Models
{
    public class Institution
    {
        public string Department;
        public string Residence;

        public Institution(string department, string residence)
        {
            Department = department;
            Residence = residence;
        }
        public Institution()
        {

        }
    }
}