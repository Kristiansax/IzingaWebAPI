using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IzingaWebAPI.Models;

namespace IzingaWebAPI.Models
{
    public class Event
    {
        public Incident Incident { get; set; }
        public Institution Institution { get; set; }
        public Patient Patient { get; set; }
        public Personnel Personnel { get; set; }
        public Sensor Sensor { get; set; }

        public Event(Incident incident, Institution institution, Patient patient, Personnel personnel, Sensor sensor)
        {
            Incident = incident;
            Institution = institution;
            Patient = patient;
            Personnel = personnel;
            Sensor = sensor;
        }
    }
}