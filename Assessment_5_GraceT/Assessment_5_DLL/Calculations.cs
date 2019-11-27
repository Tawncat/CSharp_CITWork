//****************************************************************
// Programmer: Grace Toyer CIT014747
// Date: 25/08/2019
// Software: Microsoft Visual Studio 2019 Community Edition
// Platform: Microsoft Windows 10 Professional 64-bit
// Purpose: Assessment 5. Dynamic linked library. Formulas for the speed calculation app (Assessment_5_1).
//******************************************************************
using System;

namespace Calculations
{
    public class Formulas
    {
        public double Miles(double x = 0, int round = 0)
        {
            return Math.Round(x / 1.609, round);
        }

        public double Feet(double x = 0, int round = 0)
        {
            return Math.Round(x * 3280.84, round);
        }

        public double Metre(double x = 0, int round = 0)
        {
            return Math.Round(x * 999.999, round);//approximate
        }

        public double Knot(double x = 0, int round = 0)
        {
            return Math.Round(x / 1.852, round);
        }
        public double Mach(double x = 0, int round = 0)
        {
            return Math.Round(x * 0.00081699346405229, round);
        }
    }
}
