using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrzelicznikFahrenheit
{
    class Temperature
    {
        public double toCelsjusz(double f)
        {
            return (5.0 / 9.0) * (f - 32);
        }
        public double toFahrenheit(double  c)
        {
            return (9.0 / 5.0) * c + 32;
        }
    }
}
