using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using IzingaWebAPI.Models;
using Newtonsoft.Json;
using System.Globalization;

namespace IzingaWebAPI.DAL
{
    public class LogRepository
    {
        public List<Event> Events = new List<Event>();

        public List<Event> GetDataFromLogFile()
        {
            UpdateList();

            return Events;
        }

        //Grabs .txt file from path (change to database call) and seperates each line by tabs using SeperateString()
        //Adds these Events to the 'Events' list and exports them to a JSON file
        private void UpdateList()
        {
            //Live
            //string[] data = File.ReadAllLines(HttpRuntime.AppDomainAppPath + @"\bin\Data\log.txt");
            //Testing
            string[] data = File.ReadAllLines(Environment.CurrentDirectory + @"\Data\log.txt");

            bool firstLine = true;
            foreach (string item in data)
            {
                if (firstLine == true)
                {
                    firstLine = false;
                }
                else
                {
                    string[] seperatedItem = SeperateString(item);

                    Institution institution = new Institution(seperatedItem[11], seperatedItem[8]);
                    Patient patient = new Patient(seperatedItem[1], seperatedItem[3], seperatedItem[2]);
                    Personnel personnel = new Personnel(seperatedItem[9], seperatedItem[10]);
                    Sensor sensor = new Sensor(seperatedItem[5], seperatedItem[6]);
                    Incident incident = new Incident(seperatedItem[4],
                                                     DateTime.ParseExact(
                                                        "dd-MM-yyyy HH:mm:ss",
                                                        seperatedItem[0],
                                                        CultureInfo.InvariantCulture),
                                                     DateTime.ParseExact(
                                                        "dd-MM-yyyy HH:mm:ss",
                                                        seperatedItem[7],
                                                        CultureInfo.InvariantCulture));

                    Event _event = new Event(incident, institution, patient, personnel, sensor);
                    Events.Add(_event);
                }
            }
            JSON_IO<Event>.Write(Events, Environment.CurrentDirectory + @"\Data\logfile.json");

        }

        //Seperates a string into a string[] splitting at tabs(\t)
        public string[] SeperateString(string input)
        {
            return input.Split('\t');
        }
    }
}