using System;
using System.Collections.Generic;

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

        // TODO: Add the two necessary constructors.

        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) :
            this()
        {
            Name = name;
            EmployerName= employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        // TODO: Generate Equals() and GetHashCode() methods.

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
            string info = $"\nId: {Id}\n";

            if (Name == "")
            {
                info += "Name: Data Not Available\n";
            }
            else
            {
                info += $"Name: {Name}\n";
            }

            if (EmployerName.Value == "")
            {
                info += "Employer: Data Not Available\n";
            }
            else
            {
                info += $"Employer: {EmployerName.Value}\n";
            }

            if (EmployerLocation.Value == "")
            {
                info += "Location: Data Not Available\n";
            }
            else
            {
                info += $"Location: {EmployerLocation.Value}\n";
            }

            if (JobType.Value == "")
            {
                info += "Position Type: Data Not Available\n";
            }
            else
            {
                info += $"Position Type: {JobType.Value}\n";
            }

            if (JobCoreCompetency.Value == "")
            {
                info += "Core Competency: Data Not Available\n";
            }
            else
            {
                info += $"Core Competency: {JobCoreCompetency.Value}\n";
            }

            return info;
            
        }
    }
}
