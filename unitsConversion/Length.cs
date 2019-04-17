using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace unitsConversion
{
    public class Length
    {
        public const double meter = 1.0;
        public const double km = 1000.0;
        public const double mile = 1609.344;
        public const double inch = 0.0254;
        public const double foot = 0.3048;

        public static double convertLength(double entry, string unitin, string unitout)
        {
            double unit1 = 0.0;
            double unit2 = 0.0;

            switch (unitin)
            {
                case "Meter":
                    unit1 = meter;
                    break;

                case "KM":
                    unit1 = km;
                    break;

                case "Mile":
                    unit1 = mile;
                    break;

                case "Inch":
                    unit1 = inch;
                    break;

                case "Foot":
                    unit1 = foot;
                    break;

                default:
                    break;
            }

            switch (unitout)
            {
                case "Meter":
                    unit2 = meter;
                    break;

                case "KM":
                    unit2 = km;
                    break;

                case "Mile":
                    unit2 = mile;
                    break;

                case "Inch":
                    unit2 = inch;
                    break;

                case "Foot":
                    unit2 = foot;
                    break;

                default:
                    break;
            }

            return entry * (unit1 / unit2);
        }
    }
}
