using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IzingaWebAPI.Models;

namespace IzingaWebAPI.Models
{
    public class Event
    {
        public Incident Incident;
        public Institution Institution;
        public Patient Patient;
        public Personnel Personnel;
        public Sensor Sensor;

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