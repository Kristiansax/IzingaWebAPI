using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IzingaWebAPI.Models
{
    public class Patient
    {
        public string Name;
        public string Location;
        public string ID;

        public Patient(string name, string location, string id)
        {
            Name = name;
            Location = location;
            ID = id;
        }
        public Patient()
        {

        }
    }
}