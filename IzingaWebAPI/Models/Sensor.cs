using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IzingaWebAPI.Models
{
    public class Sensor
    {
        public string Type { get; set; }
        public string ID { get; set; }

        public Sensor(string type, string id)
        {
            Type = type;
            ID = id;
        }

        public Sensor()
        {

        }
    }
}