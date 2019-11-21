//****************************************************************
// Programmer: Grace Toyer CIT014747
// Date: 21/08/2019
// Software: Microsoft Visual Studio 2019 Community Edition
// Platform: Microsoft Windows 10 Professional 64-bit
// Purpose: Session 13 Demo. Dynamic linked library. Basic arithmetic calculations.
//******************************************************************

namespace Calculations
{
    public class Equations
    {
        public double Addition (double x = 0, double y = 0)
        {
            return x + y;
        }

        public double Subtraction (double x = 0, double y = 0)
        {
            return x - y;
        }

        public double Multiplication (double x = 0, double y = 0)
        {
            return x * y;
        }

        public double Division (double x = 0, double y = 0)
        {
            return x / y;
        }
    }
}
