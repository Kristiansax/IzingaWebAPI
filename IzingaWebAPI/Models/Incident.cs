using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IzingaWebAPI.Models
{
    public class Incident
    {
        public string Description;
        public DateTime StartTime;
        public DateTime ResetTime;

        public Incident(string description, DateTime startTime, DateTime resetTime)
        {
            Description = description;
            StartTime = startTime;
            ResetTime = resetTime;
        }
    }
}