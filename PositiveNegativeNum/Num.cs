using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositiveNegativeNum
{
    public class Num
    {
        public bool IsPositive(double n)
        {
            bool result = false;
            if (n < 0)
            {
                result = false;
            }
            if (n > 0)
            {
                result = true;
            }
            if (n == 0)
            {
                throw new ArgumentException("0!");
            }
            return result;
        }
    }
}
