using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShunanovKE.Sprint2.Task6.V10.Lib
{
    public class DataService : ISprint2Task6V10
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            switch (n)
            {
                case 1:
                    switch (m)
                    {
                        case 1: return "31.12." + Convert.ToString(g-1);
                        case 2:
                        case 4:
                        case 6:
                        case 8:
                        case 9:
                        case 11: return "31." + Convert.ToString(m-1) + '.' + Convert.ToString(g);
                        case 3: return "28.2." + Convert.ToString(g);
                        default: return "30." + Convert.ToString(m - 1) + '.' + Convert.ToString(g);
                    }

                default: return Convert.ToString(n - 1) + '.' + Convert.ToString(m) + '.' + Convert.ToString(g);
            }
        }
    }
}
