using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShunanovKE.Sprint2.Task4.V24.Lib
{
    public class DataService : ISprint2Task4V24
    {
        public double Calculate(double x, double y)
        {
            double z = ((x + 2) > (y + 24)) ? (x * Math.Pow((y + 1) / (x + 2), x)) : ((y * y + Math.Cos(x * x) + 9) / (x * x - Math.Sin(y * y) + 12));
            return Math.Round(z,3);
        }
    }
}
