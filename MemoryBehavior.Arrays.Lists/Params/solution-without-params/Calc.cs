using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProj
{
    class Calc
    {
        public static int Soma( int[] arr)
        {
            int res = 0;
            for(int i=0; i<arr.Length; i++)
            {
                res += arr[i];
            }
            return res;
        }
    }
}
