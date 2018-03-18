using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_2_Ingrycht_Alves_Antunes
{
    class Test
    {
        public static void Main()
        {
            Rectangle shape1 = new Rectangle();
            shape1.Leng = 2;
            shape1.Width = 4;
            Console.WriteLine("shape1 object => Length: {0}\tWidth: {1}\tArea: {2}",
                shape1.Leng, shape1.Width, shape1.GetArea());
            Console.WriteLine();
            Rectangle shape2 = new Rectangle();
            shape2.Leng = 7;
            shape2.Width = 8;
            Console.WriteLine("shap2 object => Length: {0}\tWidth: {1}\tArea: {2}",
                shape2.Leng, shape2.Width, shape2.GetArea());

            if(shape1.GetArea().CompareTo(shape2.GetArea())< 0)
            {
                Console.WriteLine("\nShape1 is smaller");
            }
            else if(shape1.GetArea().CompareTo(shape2.GetArea()) > 0)
            {
                Console.WriteLine("\nShape1 is bigger");
            }
            else
                Console.WriteLine("\nShape1 and Shape2 are the same");
        }
    }
}
