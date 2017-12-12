using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IzingaWebAPI.Models
{
    public class Personnel
    {
        public string Name;
        public string ID;

        public Personnel(string name, string id)
        {
            Name = name;
            ID = id;
        }
        public Personnel()
        {

        }
    }
}