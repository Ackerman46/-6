using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практ6
{
    internal class CheckArray
    {
        static public bool CheckArrays(int[] array)
        {
            bool hasDifferentSigns = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (i > 0 && Math.Sign(array[i]) != Math.Sign(array[i - 1]))
                {
                    return false;
                    break;
                }
            }
            return true;
        }
    }
}
