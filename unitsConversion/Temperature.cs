using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unitsConversion
{
    public class Temperature
    {
        public static double convertTemperature(double entry, string unitin, string unitout)
        {

            if (unitin.Equals("Celsius") && unitout.Equals("Fahrenheit"))
            {
                return ((entry * 1.8) + 32);
            }

            if (unitin.Equals("Fahrenheit") && unitout.Equals("Celsius"))
            {
                return ((entry - 32) / 1.8);
            }

            if (unitin.Equals("Celsius") && unitout.Equals("Kelvin"))
            {
                return (entry + 273.15);
            }

            if (unitin.Equals("Kelvin") && unitout.Equals("Celsius"))
            {
                return (entry - 273.15);
            }

            if (unitin.Equals("Fahrenheit") && unitout.Equals("Kelvin"))
            {
                return ((entry + 459.67) * (5 / 9));
            }

            if (unitin.Equals("Kelvin") && unitout.Equals("Fahrenheit"))
            {
                return ((entry * (9 / 5)) - 459.67);
            }

            return 0;
        }
    }
}
