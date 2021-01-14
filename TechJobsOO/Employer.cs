using System;
namespace TechJobsOO
{
    public class Employer : JobField
    {

        public Employer(string value) : base(value)
        {

        }

       /* public override bool Equals(object obj)
        {
            return obj is Employer employer &&
                   Id == employer.Id;
        }

        public override string ToString()
        {
            if (Value == "" || Value == " " || Value == null)
            {
                return " \n Employer : " + "_______ " + "Data not available" + "\n";
            }
            else
            {
                return " \n Employer : " + Value + "\n";
            }
        }*/
    }
}
