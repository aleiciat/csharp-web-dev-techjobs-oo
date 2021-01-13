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
            Assert.IsTrue(sampleJob.EmployerName.Value.Equals("ACME"));
            Assert.IsTrue(sampleJob.EmployerLocation.Value.Equals("Desert"));
            Assert.IsTrue(sampleJob.JobType.Value.Equals("Quality Control"));
            Assert.IsTrue(sampleJob.JobCoreCompetency.Value.Equals("Persistence"));
        }

        //public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency)

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job testJob = new Job("testName", new Employer("employerName"), new Location("employerLocation"), new PositionType("jobType"), new CoreCompetency("jobCoreCompetency"));
            string firstName = testJob.Name;
            string firstEmployerName = testJob.EmployerName.Value;
            string firstEmployerLocation = testJob.EmployerLocation.Value;
            string firstJobType = testJob.JobType.Value;
            string firstJobCoreCompetency = testJob.JobCoreCompetency.Value;
            Assert.AreEqual("testName", firstName);
            Assert.AreEqual("employerName", firstEmployerName);
            Assert.AreEqual("employerLocation", firstEmployerLocation);
            Assert.AreEqual("jobType", firstJobType);
            Assert.AreEqual("jobCoreCompetency", firstJobCoreCompetency);
        }

        [TestMethod]
        public void JobReturnsBlankLine()
        {
            Job thisJob = new Job("testName", new Employer(""), new Location("employerLocation"), new PositionType("jobType"), new CoreCompetency("jobCoreCompetency"));
            string blankLine = thisJob.EmployerName.ToString();
            Assert.IsTrue(blankLine.ToString().Contains("_______"));
        }

        [TestMethod]
        public void ContainsLabelDataAndNewLine()
        {
            Job thisJob = new Job("testName", new Employer("employerName"), new Location("employerLocation"), new PositionType("jobType"), new CoreCompetency("jobCoreCompetency"));
            string labelData = thisJob.EmployerName.ToString();
            Assert.IsTrue(labelData.ToString().Contains(":"));
            Assert.IsTrue(labelData.ToString().Contains(thisJob.EmployerName.Value));
            Assert.IsTrue(labelData.ToString().Contains("\n")); 
        }

        [TestMethod]
        public void DataNotAvailable()
        {
            Job aJob = new Job(" ", new Employer(""), new Location(""), new PositionType(""), new CoreCompetency(""));
            string dataAvailablity = aJob.EmployerName.ToString();
            Assert.IsTrue(dataAvailablity.ToString().Contains("Data not available"));
        }

/*        [TestMethod]
        public void OnlyContainsIdField()
        {
            Job emptyJob = new Job("", new Employer(), new Location(), new PositionType(), new CoreCompetency());
            Assert.IsTrue(emptyJob.ToString().Contains("Oops"));
        }*/
    }
}
