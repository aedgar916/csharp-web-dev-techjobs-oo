using System;
namespace TechJobsOO
{
    public class CoreCompetency
    {
        //private int id;

        private static int nextId = 1;
        //private string value;

        // TODO: Change the fields to auto-implemented properties.
        public int Id { get; set; }
        public string Value { get; set; }

        public CoreCompetency()
        {
            Id = nextId;
            //id = nextId;
            nextId++;
        }

        public CoreCompetency(string v) : this()
        {
            Value = v;
            // value = v;
        }

        public override bool Equals(object obj)
        {
            //return obj is CoreCompetency competency &&
            //       id == competency.id;
            return obj is CoreCompetency competency &&
                   Id == competency.Id;
        }

        public override int GetHashCode()
        {
            //return HashCode.Combine(id);
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            //return value;
            return Value;
        }
    }
    
}
