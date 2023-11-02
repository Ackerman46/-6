using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практ6
{
    internal class FillArray
    {
        static public int[] FillArrays(int[] array, Random rnd)
        {
            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-10,10);
            }
            return array;
        }
    }
}
