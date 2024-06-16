using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dcit_assignment2_10979469
{
    public class Rectangle:Shape
    {
        public override void GetArea() 
        {
            string area = "length * breadth"; /*implementing real values we use int type*/
            Console.WriteLine(area);
        }
    }
}
