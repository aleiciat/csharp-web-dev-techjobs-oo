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

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job firstJob = new Job();
            string firstName = firstJob.Name;
            string firstEmployerName = firstJob.EmployerName.Value;
            string firstEmployerLocation = firstJob.EmployerLocation.Value;
            string firstJobType = firstJob.JobType.Value;
            string firstJobCoreCompetency = firstJob.JobCoreCompetency.Value;
            Job secondJob = new Job();
            string secondName = firstJob.Name;
            string secondEmployerName = secondJob.EmployerName.Value;
            string secondEmployerLocation = secondJob.EmployerLocation.Value;
            string secondJobType = secondJob.EmployerLocation.Value;
            string secondJobCoreCompetency = secondJob.JobCoreCompetency.Value;
            Assert.AreEqual(firstJob, secondJob);
        }
/*
        [TestMethod]
        public void JobReturnsBlankLine()
        {
            Job line = new Job();
            Assert.IsTrue( );
        }*/
    }
}
