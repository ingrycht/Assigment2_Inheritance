using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_2_Ingrycht_Alves_Antunes
{
    //inheritance Shapes Abstract Class
    class Rectangle : Shapes, IComparable
    {
       //implement the CompareTo()method
        public int CompareTo(object obj)
        {
            if (obj == null) return 0;
            if (!(obj is Rectangle))
                throw new ArgumentException();

            Rectangle target = obj as Rectangle;
            Console.WriteLine(target.Leng);
            if (this.Leng < target.Leng)
                return -1;
            else if (this.Leng > target.Leng)
                return 1;
            else return 0;
        }
        //adding a virtual void Info() method to the class Shapes
        public virtual void Info()
        {
            //prints “I am an undefined Shape”
            Console.WriteLine("I am a retangle Shape");
        }
        public override double GetArea()
        {
            return Leng*Width;
        }
    }
}