using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProgram
{
    internal class Linecomparison
    {
         int x1,y1,x2,y2;

        public Linecomparison(int x1,int y1,int x2,int y2)
        {
            this.x1 = x1;
            this.y1 = y1;   
            this.x2 = x2;
            this.y2 = y2;
            Console.WriteLine("line coordinates are :(x1,y1) =({0},{1}) \n (x2,y2)=({2},{3})",this.x1,this.y1,this.x2,this.y2);
        }

        public double findlength()
        {
            double length=Math.Sqrt( (this.x2 - this.x1)^2 + (this.y2 - this.y1)^2 );
            Console.WriteLine("length of line is :" + length);
            return length;

        }
    }
}
