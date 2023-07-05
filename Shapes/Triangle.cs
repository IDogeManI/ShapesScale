using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Triangle: ICanGetScale
    {
        private readonly double _a, _b, _c;
        public Triangle(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public double GetScale() =>
            Math.Sqrt(((_a + _b + _c) / 2) * (((_a + _b + _c) / 2) - _a) * (((_a + _b + _c) / 2) - _b) * (((_a + _b + _c) / 2) - _c));
        public bool IsStraight() =>
            _a * _a + _b * _b == _c * _c || _a * _a + _c * _c == _b * _b || _b * _b + _c * _c == _a * _a;
    }
}
