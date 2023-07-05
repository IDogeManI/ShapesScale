using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : ICanGetScale
    {
        private double _r;
        public Circle(double r)
        {
            _r = r;
        }
        public double GetScale() =>
            Math.PI * _r * _r;
    }
}
