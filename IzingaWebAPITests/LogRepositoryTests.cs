using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IzingaWebAPI.Controllers;
using IzingaWebAPI.DAL;
using IzingaWebAPI.Models;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace LogRepositoryTests
{
    [TestClass]
    public class LogReaderTests
    {
        LogController TestController = new LogController();
        LogRepository TestRepository = new LogRepository();

        [TestMethod]
        public void LogFileExists()
        {
            string startUpPath = Directory.GetCurrentDirectory();
            Assert.IsTrue(File.Exists(startUpPath + @"\Data\log.txt"));
        }

        [TestMethod]
        public void CanSeperateString()
        {
            string testString = "Test1" + "\t" + "Test2";
            string[] seperatedTestString = TestRepository.SeperateString(testString);

            Assert.AreEqual("Test1", seperatedTestString[0]);
            Assert.AreEqual("Test2", seperatedTestString[1]);
        }

        //Change the path in LogRepository.UpdateList() to the test path when using this test
        [TestMethod]
        public void CanGetDataFromFile()
        {
            List<Event> testList = new List<Event>();
            testList = JsonConvert.DeserializeObject<List<Event>>(TestRepository.GetDataFromLogFile());

            Assert.AreEqual("26-06-2011 05:59:39",  testList[0].Incident.StartTime.ToString());
            Assert.AreEqual("Kristian Andersen",    testList[0].Patient.Name);
            Assert.AreEqual("9177",                 testList[0].Patient.ID);
            Assert.AreEqual("Stue 4, 2s",           testList[0].Patient.Location);
            Assert.AreEqual("Alarmen blev trippet", testList[0].Incident.Description);
            Assert.AreEqual("Liggesensor",          testList[0].Sensor.Type);
            Assert.AreEqual("9040",                 testList[0].Sensor.ID);
            Assert.AreEqual("26-06-2011 05:59:39",  testList[0].Incident.ResetTime.ToString());
            Assert.AreEqual("Demovej 9",            testList[0].Institution.Residence);
            Assert.AreEqual("Frank Elias",          testList[0].Personnel.Name);
            Assert.AreEqual("5565",                 testList[0].Personnel.ID);
            Assert.AreEqual("Afdeling 2",           testList[0].Institution.Department);
        }
    }
}
