using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShunanovKE.Sprint2.Task2.V27.Lib
{
    public class DataService : ISprint2Task2V27
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool ans = false;

            if ((y == 3) && ((x == 9) || (3 <= x && x <= 5))) ans = true;

            if ((y == 4) && ((x == 9) || (3 <= x && x <= 5))) ans = true;

            if ((y == 5) && ((3 <= x && x <= 9))) ans = true;

            if ((y == 6) && ((x == 13) || (x == 3) || (6 <= x && x <= 9))) ans = true;

            if ((y == 7) && ((x == 13) || (6 <= x && x <= 9))) ans = true;

            if ((y == 8) && ((6 <= x && x <= 13))) ans = true;

            if ((y == 9) && ((x == 6) || (9 <= x && x <= 12))) ans = true;

            if ((y == 10) && ((x == 6) || (9 <= x && x <= 12))) ans = true;

            if ((y == 11) && ((3 <= x && x <= 6) || (9 <= x && x <= 12))) ans = true;

            if ((y == 12) && ((9 <= x && x <= 12))) ans = true;

            if ((y == 13) && ((10 <= x && x <= 12))) ans = true;

            return ans;
        }
    }
}
