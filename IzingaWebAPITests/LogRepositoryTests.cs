using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IzingaWebAPI.Controllers;
using IzingaWebAPI.DAL;
using IzingaWebAPI.Models;
using System.Collections.Generic;

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

        [TestMethod]
        public void CanGetDataFromFile()
        {
            List<Event> TestList = new List<Event>();
            TestList = TestRepository.GetDataFromLogFile();

            //Assert.AreEqual("26-06-2011 05:59:39", TestList[1].Incident.StartTime);
            //Assert.AreEqual("Kristian Andersen", TestList[1].Patient.Name);
            //Assert.AreEqual("9177", TestList[1].Patient.ID);
            //Assert.AreEqual("Stue 4, 2s", TestList[1].Patient.Location);
            //Assert.AreEqual("Alarmen blev trippet", TestList[1].Incident.Description);
            //Assert.AreEqual("Liggesensor", TestList[1].Sensor.Type);
            //Assert.AreEqual("9040", TestList[1].Sensor.ID);
            //Assert.AreEqual("26-06-2011 05:59:39", TestList[1].Incident.ResetTime);
            //Assert.AreEqual("Demovej 9", TestList[1].Institution.Residence);
            //Assert.AreEqual("Frank Elias", TestList[1].Personnel.Name);
            //Assert.AreEqual("5565", TestList[1].Personnel.ID);
            //Assert.AreEqual("Afdeling 2", TestList[1].Institution.Department);
        }
    }
}
