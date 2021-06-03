using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Код_Формы
{  
    interface Imarea
    {
       double Area(params int[] operands);

    }
    class Point
    {
        public Point() { }
        protected double x, y;
        public double pointX
        {
            get { return x; }
            set { if (value > 0) x = value; }
        }
        public double pointY
        {
            get { return y; }
            set { if (value > 0) y = value; }
        }

    }

    class Circle : Imarea
    {
        public Circle() { }

        double Imarea.Area(params int[] operands)
        {
            return Math.PI * operands[0] * operands[0]; 
        }
    }

    class Cone : Imarea
    {
        double Imarea.Area(params int[] operands)
        {
            return Math.PI * operands[0] * (Math.Sqrt(operands[0] * operands[0] + operands[1] * operands[1]) + operands[0]);
        }
   
    }

    class Frustrum : Imarea
    {
        double Imarea.Area(params int[] operands)
        {
            return  0.33 * operands[2] * (operands[0] + operands[1] + Math.Sqrt(operands[0] * operands[1]));
        }

    }

}
