using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job idJobs = new Job();
            Job nextIdJobs = new Job();
            Assert.IsTrue((idJobs.Id + 1) == nextIdJobs.Id);
        }
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job sampleJob = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));
            Assert.IsTrue(sampleJob.Name == "Product tester");
            Assert.IsTrue(sampleJob.EmployerName.Value == "ACME");
            Assert.IsTrue(sampleJob.EmployerLocation.Value == "Desert");
            Assert.IsTrue(sampleJob.JobType.Value == "Quality Control");
            Assert.IsTrue(sampleJob.JobCoreCompetency.Value == "Persistence");
        }

        //public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency)

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job sampleJob = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));
            Job testJob = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));
            Assert.IsFalse(sampleJob.Equals(testJob));
/*            string firstName = testJob.Name;
            string firstEmployerName = testJob.EmployerName.Value;
            string firstEmployerLocation = testJob.EmployerLocation.Value;
            string firstJobType = testJob.JobType.Value;
            string firstJobCoreCompetency = testJob.JobCoreCompetency.Value;
            Assert.AreEqual("testName", firstName);
            Assert.AreEqual("employerName", firstEmployerName);
            Assert.AreEqual("employerLocation", firstEmployerLocation);
            Assert.AreEqual("jobType", firstJobType);
            Assert.AreEqual("jobCoreCompetency", firstJobCoreCompetency);*/
        }

        [TestMethod]
        public void JobReturnsBlankLine()
        {
            Job thisJob = new Job("testName", new Employer(""), new Location("employerLocation"), new PositionType("jobType"), new CoreCompetency("jobCoreCompetency"));
            //string blankLine = thisJob.EmployerName.ToString();
            //Assert.IsTrue(blankLine.ToString().Contains("\n"));
            string strobj = thisJob.ToString();
            char firstchar = strobj[0];
            char lastchar = strobj[strobj.Length-1];
            Assert.IsTrue(firstchar == lastchar);
        }

        [TestMethod]
        public void ContainsLabelDataAndNewLine()
        {
            Job thisJob = new Job("testName", new Employer("employerName"), new Location("employerLocation"), new PositionType("jobType"), new CoreCompetency("jobCoreCompetency"));
            string labelData = $"\n ID : {thisJob.Id} \n Name : {thisJob.Name} \n Employer : {thisJob.EmployerName.Value} \n Location : {thisJob.EmployerLocation.Value} \n Position Type : {thisJob.JobType.Value} \n Core Competency : {thisJob.JobCoreCompetency.Value} \n";
            Assert.AreEqual(labelData, thisJob.ToString());
            /* Assert.IsTrue(labelData.ToString().Contains(":"));
            Assert.IsTrue(labelData.ToString().Contains(thisJob.EmployerName.Value));
            Assert.IsTrue(labelData.ToString().Contains("\n"));*/
        }

        [TestMethod]
        public void DataNotAvailable()
        {
            Job thisJob = new Job("", new Employer(""), new Location(""), new PositionType("jobType"), new CoreCompetency("jobCoreCompetency"));
            string labelData = $"\n ID : {thisJob.Id} \n Name : Data not available \n Employer : Data not available \n Location : Data not available \n Position Type : {thisJob.JobType.Value} \n Core Competency : {thisJob.JobCoreCompetency.Value} \n";
            Assert.AreEqual(labelData, thisJob.ToString());
        }

/*        [TestMethod]
        public void OnlyContainsIdField()
        {
            Job emptyJob = new Job("", new Employer(), new Location(), new PositionType(), new CoreCompetency());
            Assert.IsTrue(emptyJob.ToString().Contains("Oops"));
        }*/
    }
}
