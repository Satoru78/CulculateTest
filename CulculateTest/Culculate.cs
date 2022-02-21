using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CulculateTest
{
    public class Culculate
    {
        public static int Addition(int firstnum , int secondnum)
        {
            return firstnum + secondnum;
        }
        public static int Substraction(int firstnum, int secondnum)
        {
            return firstnum - secondnum;
        }
        public static int Multiplicaton(int firstnum , int secondnum)
        {
            return firstnum * secondnum;
        }
        public static int Division(int firstnum , int secondnum)
        {
            if(secondnum == 0)
            {
                return  0;
            }
            else
            {
               return firstnum / secondnum;
            }
        }
    }
}
