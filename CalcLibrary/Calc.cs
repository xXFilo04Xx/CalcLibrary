using System;

namespace CalcLibrary
{
    public static class Calc
    {
        public static double RadQ(double num)
        {
            double resp = 0;
            if (num >= 0)
            {
                resp = Math.Sqrt(num);
            }
            else
            {
                resp = double.NaN;
                
            }
            return resp;
        }

        public static double Vertx(double a, double b)
        {
            double vx = double.NaN;
            if (a != 0)
                vx = -b / (2 * a);

            return vx;



        }

        public static double Verty(double a, double b, double c)
        {
            double vy = double.NaN;
            double del = 0;
            if (a != 0)
            {
                del = (b * b) - 4 * a * c;
                vy = -del / (4 * a);
            }
            return vy;



        }
    }
}
