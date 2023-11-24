using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment20Day15
{
    public  class ArrayClass
    {
        public void Sum(int[] arr)
        {
            int sum = 0;
            foreach(int i in arr)
            {
                sum += i;
            }
            Console.WriteLine("Sum of the given arr is: "+sum);
        }

        public void Avg(int[] arr)
        {
            int sum = 0;
            foreach(int i in arr)
            {
                sum += i;
            }
            Console.WriteLine("Average of the array is: "+sum/arr.Length);
        }
        
    }
}
