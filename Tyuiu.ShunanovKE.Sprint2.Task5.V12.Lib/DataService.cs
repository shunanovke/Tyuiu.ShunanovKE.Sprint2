using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShunanovKE.Sprint2.Task5.V12.Lib
{
    public class DataService : ISprint2Task5V12
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            string res = "";
            switch (n)
            {
                case 1:
                    if (m == 1) res = "31.12." + Convert.ToString(g - 1);

                    else if (m == 2 || m == 4 || m == 6 || m == 8 || m == 9 || m == 11) res = "31." + Convert.ToString(m - 1) + '.' + Convert.ToString(g);

                    else if (m == 3) res = "29.2." + Convert.ToString(g);

                    else res = "30." + Convert.ToString(m - 1) + '.' + Convert.ToString(g);
                    break;
                default:
                    res = Convert.ToString(n - 1) + '.' + Convert.ToString(m) + '.' + Convert.ToString(g);
                    break;
            }
            return res;
        }
    }
}
