using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unitsConversion
{
    public class Mass
    {
        public const double kilograms = 1.0;
        public const double grams = 1000.0;
        public const double pounds = 2.20462262185;
        public const double ounces = 35.2739619;

        public static double convertMass(double entry, string unitin, string unitout)
        {
            double unit1 = 0.0;
            double unit2 = 0.0;

            switch (unitin)
            {
                case "Kilograms":
                    unit1 = kilograms;
                    break;

                case "Grams":
                    unit1 = grams;
                    break;

                case "Pounds":
                    unit1 = pounds;
                    break;

                case "Ounces":
                    unit1 = ounces;
                    break;

                default:
                    break;
            }

            switch (unitout)
            {
                case "Kilograms":
                    unit2 = kilograms;
                    break;

                case "Grams":
                    unit2 = grams;
                    break;

                case "Pounds":
                    unit2 = pounds;
                    break;

                case "Ounces":
                    unit2 = ounces;
                    break;

                default:
                    break;
            }

            return entry * (unit2 / unit1);
        }
    }
}
