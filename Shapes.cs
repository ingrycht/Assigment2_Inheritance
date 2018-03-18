using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_2_Ingrycht_Alves_Antunes
{
    //create an abstract class
    abstract class Shapes
    {
        //encapsulated class members Length and Width with getters and setters
        public double Leng { get; set; }
        public double Width { get; set; }

        //adding a virtual void Info() method to the class Shapes
        public virtual void Info()
        {
            //prints “I am an undefined Shape”
            Console.WriteLine("I am an undefined Shape");
        }

        //created an abstract method GetArea() 
        public abstract double GetArea(); 
    }
}
