using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchKata.Logic
{
    public class BinarySearch
    {

        public int Chop_Sequential(int number, int[] arrNumbers)
        {
            Array.Sort(arrNumbers);
            int length = arrNumbers.Length;
            int min = 0;
            int max = length-1;
            int mid;

            while (min <= max)
            {
                mid = (max + min)/2;
                if (arrNumbers[mid] == number)
                    return mid;
                else
                {
                    if (number < arrNumbers[mid])
                    {
                        max = mid - 1;
                    }
                    else
                    {
                        min = mid + 1;
                    }
                }
            }

            return -1;
        }
    }
}
