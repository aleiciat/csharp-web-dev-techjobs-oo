using System;
namespace TechJobsOO
{
    public class CoreCompetency : JobField
    {

        public CoreCompetency(string value) : base(value)
        {

        }


        public override bool Equals(object obj)
        {
            return obj is CoreCompetency competency &&
                   Id == competency.Id;
        }

/*        public override string ToString()
        {
            if (Value == "" || Value == " " || Value == null)
            {
                return " \n Core Competency : " + "_______ " + "Data not available" + "\n";
            }
            else
            {
                return " \n Core Competency : " + Value + "\n";
            }
        }*/
    }
}
