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


        //        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job firstJob = new Job("testName", new Employer("employerName"), new Location("employerLocation"), new PositionType("jobType"), new CoreCompetency("jobCoreCompetency"));
            string firstName = firstJob.Name;
            string firstEmployerName = firstJob.EmployerName.Value;
            string firstEmployerLocation = firstJob.EmployerLocation.Value;
            string firstJobType = firstJob.JobType.Value;
            string firstJobCoreCompetency = firstJob.JobCoreCompetency.Value;
            Assert.AreEqual("testName", firstName);
            Assert.AreEqual("employerName", firstEmployerName);
            Assert.AreEqual("employerLocation", firstEmployerLocation);
            Assert.AreEqual("jobType", firstJobType);
            Assert.AreEqual("jobCoreCompetency", firstJobCoreCompetency);
        }

        [TestMethod]
        public void JobReturnsBlankLine()
        {
            Job thisJob = new Job("testName", new Employer("employerName"), new Location("employerLocation"), new PositionType("jobType"), new CoreCompetency("jobCoreCompetency"));
            string blankLine = thisJob.EmployerName.ToString();
            Assert.IsTrue(blankLine.ToString().Contains("_______"));
        }
    }
}
