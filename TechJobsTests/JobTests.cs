using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        //[TestMethod]
        //public void EmptyTest()
        //{
        //    Assert.AreEqual(true, true);
        //}

        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();

            Assert.AreEqual(true, job1.Id != job2.Id);
            Assert.AreEqual(1, job2.Id - job1.Id);
        }


        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.AreNotEqual(null, job.Id);
            Assert.AreEqual("Product tester", job.Name);
            Assert.AreEqual("ACME", job.EmployerName.Value);
            Assert.AreEqual("Desert", job.EmployerLocation.Value);
            Assert.AreEqual("Quality control", job.JobType.Value);
            Assert.AreEqual("Persistence", job.JobCoreCompetency.Value);
       
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.AreEqual(false, job1.Equals(job2));
        }

        [TestMethod]
        public void TestToStringBeginsAndEndsWithBlankLines()
        {
            Job job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.AreEqual(true, job.ToString().StartsWith("\n"));
            Assert.AreEqual(true, job.ToString().EndsWith("\n"));
        }

        [TestMethod]
        public void TestToStringFieldsAreLabeled()
        {
            Job job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.AreEqual(true, job.ToString().Contains($"Id: {job.Id}"));
            Assert.AreEqual(true, job.ToString().Contains("Name: Product tester"));
            Assert.AreEqual(true, job.ToString().Contains("Employer: ACME"));
            Assert.AreEqual(true, job.ToString().Contains("Location: Desert"));
            Assert.AreEqual(true, job.ToString().Contains("Position Type: Quality control"));
            Assert.AreEqual(true, job.ToString().Contains("Core Competency: Persistence"));
        }

        [TestMethod]
        public void TestForDataNotAvailable()
        {
            Job job = new Job("", new Employer(""), new Location(""), new PositionType(""),new CoreCompetency(""));

            Assert.AreEqual(true, job.ToString().Contains("Name: Data Not Available"));
            Assert.AreEqual(true, job.ToString().Contains("Employer: Data Not Available"));
            Assert.AreEqual(true, job.ToString().Contains("Location: Data Not Available"));
            Assert.AreEqual(true, job.ToString().Contains("Position Type: Data Not Available"));
            Assert.AreEqual(true, job.ToString().Contains("Core Competency: Data Not Available"));
        }
    }
}
