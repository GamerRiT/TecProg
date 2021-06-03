using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Код_Формы
{
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

    class Circle
    {
        public Circle() { }
        protected double y,y2;

        public double Radius1
        {
            get { return y; }
            set { if (value > 0) y = value; }
        }
        public double Radius2
        {
            get { return y2; }
            set { if (value > 0) y2 = value; }
        }

        public double Area
        {
            get { return Math.PI * y * y; }
        }

    }

    class Cone : Circle
    {
        protected double q;
        public double ConeArea
        {
            get { return q; }
            set { q = Math.PI * y * (Math.Sqrt(y * y + value * value) + y); }
        }
    }

    class Frustum : Circle
    {
        protected double w;
        public double ConeVolume
        {
            get { return w; }
            set { w = 0.33 * value * (y + y2 + Math.Sqrt(y * y2)); }
        }
    }
}
