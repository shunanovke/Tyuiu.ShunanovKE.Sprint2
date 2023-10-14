using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShunanovKE.Sprint2.Task3.V3.Lib
{
    public class DataService : ISprint2Task3V3
    {
        public double Calculate(double x)
        {
            double res;
            if (x > 1) res = x * Math.Pow(((x + 1) / (x - 1)), x);
            else
                if (x == 0) res = (Math.Pow(x, 4) - Math.Cos(Math.Pow(x, 5)) + 3) / (Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 12);
            else
                    if (x > -7 && x < 0) res = Math.Pow((1 + (Math.Sqrt(x + 3)) / (Math.Pow(x, 2))), x);
            else
                        if (x < -7) res = x * x + 10 * x - (1 / x);
            else res = 0;

            return Math.Round(res, 3);
        }
    }
}
