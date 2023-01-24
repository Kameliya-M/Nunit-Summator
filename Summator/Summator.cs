using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summator
{
    public static class Summator
    {
        public static long Sum(int[] arr)
        {
            long sum = 0;
            for (long i = 0; i < arr.Length; i++)
            {
                sum += arr[i];

            }
            return sum;
        }
        public static double Average(int[] arr)
        {
            double sum = 0;
            for (long i = 0; i < arr.Length; i++)
            {
                sum += arr[i];

            }
            return sum / arr.Length;
        }
        public static double Multiply(double[] arr)
        {
            double result = 0;

            if (arr.Length > 0)
            {
                result = arr[0];
            }

            for (int i = 1; i < arr.Length; i++)
            {

                result *= arr[i];
            }

            return result;
        }
    }
    }

