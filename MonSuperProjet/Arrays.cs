using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonSuperProjet
{
    public class Arrays
    {
        public float CalculateSum( float[] array )
        {
            float ans = 0f;
            foreach (float number in array)
            {
                ans += number;
            }
            return ans;
        }

        public int CalculateSum( int[] array )
        {
            int ans = 0;
            foreach (int number in array)
            {
                ans += number;
            }
            return ans;
        }

        public int BiggestNumber( int[] array )
        {
            int max = array[0];
            for (int i =1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        public int FindMinimum( int[] array )
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }

        public string LongestWord( string[] array )
        {
            string maxString = array[0];
            int maxLength = maxString.Length;
            for (int i=1; i < array.Length; i++)
            {
                if (array[i].Length > maxLength)
                {
                    maxString = array[i];
                    maxLength = maxString.Length;
                }
            }
            return maxString;
        }

        public int[] ReverseArray( int[] array )
        {
            int len = array.Length;
            int[] ans = new int[len];
            for (int i =0; i<len; i++)
            {
                ans[i] = array[len - i - 1];
            }
            return ans;
        }

        public int CountOccurrences( int[] array, int number )
        {
            int ans = 0;
            foreach (int currentNumber in array)
            {
                if (currentNumber == number) ans++;
            }

            return ans;
        }
    }

}
