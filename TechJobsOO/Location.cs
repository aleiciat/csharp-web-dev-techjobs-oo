using System;
namespace TechJobsOO
{
    public class Location : JobField
    {

        public Location(string value) : base(value)
        {

        }


/*        public override bool Equals(object obj)
        {
            return obj is Location location &&
                   Id == location.Id;
        }

        public override string ToString()
        {
            if (Value == "" || Value == " " || Value == null)
            {
                return " \n Location : " + "_______ " + "Data not available" + "\n";
            }
            else
            {
                return " \n Location : " + Value + "\n";
            }
        }*/
    }
}
