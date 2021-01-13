using System;
namespace TechJobsOO
{
    public class PositionType : JobField
    {

        public PositionType(string value) : base(value)
        {

        }


        public override bool Equals(object obj)
        {
            return obj is PositionType type &&
                   Id == type.Id;
        }

/*        public override string ToString()
        {
            if (Value == "" || Value == " " || Value == null)
            {
                return " \n Position Type : " + "_______ " + "Data not available" + "\n";
            }
            else
            {
                return " \n Position Type : " + Value + "\n";
            }
        }*/

    }
}
