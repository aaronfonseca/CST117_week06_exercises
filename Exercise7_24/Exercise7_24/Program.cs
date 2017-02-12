using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* A company has five stores. Input the weekly sales 
 * for each store. Determine which stores have sales 
 * in the top half of the sales range. To find the 
 * range of sales, first find the maximum and 
 * minimum sales. The range is the maximum minus 
 * the minimum. */

namespace Exercise7_24
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] salesArray = new double[5];
            Console.Write("Store 1 sales Total: ");
            salesArray[0] = Double.Parse(Console.ReadLine());
            Console.Write("Store 2 sales Total: ");
            salesArray[1] = Double.Parse(Console.ReadLine());
            Console.Write("Store 3 sales Total: ");
            salesArray[2] = Double.Parse(Console.ReadLine());
            Console.Write("Store 4 sales Total: ");
            salesArray[3] = Double.Parse(Console.ReadLine());
            Console.Write("Store 5 sales Total: ");
            salesArray[4] = Double.Parse(Console.ReadLine());

            double range = findRange(salesArray);

            string[] topSales = findHighValues(salesArray, range);

            for (int i = 0; i < topSales.Length; i++)
            {
                Console.WriteLine(topSales[i]);
            }
            Console.ReadKey();
            
        }

        public static double findMin(double[] array)
        {
            double min = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0)
                    min = array[i];
                else if (array[i] < min)
                    min = array[i];
            }
            return min;
        }

        public static double findMax(double[] array)
        {
            double max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0)
                    max = array[i];
                else if (array[i] > max)
                    max = array[i];
            }
            return max;
        }

        public static double findRange(double[] array)
        {
            double minValue = findMin(array);
            double maxValue = findMax(array);
            double range = maxValue - minValue;

            return range;
        }

        public static string[] findHighValues(double[] array, double value)
        {
            string[] temp = new string[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= value)
                    temp[i] = "Store" + i;
            }
            return temp;
        }

        public static double[] addValueToArray(double[] array, double value)
        {
            double[] temp = new double[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                temp[i] = array[i];
            }

            temp[array.Length] = value;

            return temp;
        }
    }
}
