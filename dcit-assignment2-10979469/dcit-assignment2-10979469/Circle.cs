using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dcit_assignment2_10979469
{
    public  class Circle:Shape
    {
        public override void GetArea()
        {
            string area = "1/2 base*height" ; /*if we're implementing real value we use an int*/
            Console.WriteLine(area);
        }
    }
}
