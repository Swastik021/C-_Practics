using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary.CommonLibrary.OOPS.Inheritance
{
    internal class Paren_ChildRelationship_Inheritance
    {
        //parent child relationship is basically inheritance













    }


    public class Parent
    {
        public int HouseNumber { get; set; }
        public string Property { get; set; }
        public string Address { get; set; }

        public Parent()
        {


        }
        public string BragAboutTheProperty()
        {
            return "See i am so richhhhhhhhh";

        }

    }
    public class Child : Parent
    {
        public string BuildMoreProperty()
        {
            HouseNumber = 123;
            return "";
        }
    }
}