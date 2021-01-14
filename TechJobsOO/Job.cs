using System;
namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            /*            string id = Id.ToString();
                        string employerName = EmployerName.Value;
                        string employerLocation = EmployerLocation.Value;
                        string jobType = JobType.Value;
                        string jobCoreCompetency = JobCoreCompetency.Value;*/
            /*
                                return $"\n ID : {Id} \n " +
                                    $"Name : {Name} \n " +
                                    $"Employer : {EmployerName} \n " +
                                    $"Location : {EmployerLocation} \n " +
                                    $"Position Type : {JobType} \n " +
                                    $"Core Competency : {JobCoreCompetency} \n ";
                    */
           if (Name == "")
            {
                Name = "Data not available";
            }
            if (EmployerName.Value == "")
            {
                EmployerName.Value = "Data not available";
            }
            if (EmployerLocation.Value == "")
            {
                EmployerLocation.Value = "Data not available";
            }
            if (JobType.Value == "")
            {
                JobType.Value = "Data not available";
            }
            if (JobCoreCompetency.Value == "")
            {
                JobCoreCompetency.Value = "Data not available";
            }

            string labelData = $"\n ID : {Id} \n Name : {Name} \n Employer : {EmployerName.Value} \n Location : {EmployerLocation.Value} \n Position Type : {JobType.Value} \n Core Competency : {JobCoreCompetency.Value} \n";
            return labelData;        
        }
    }
}
