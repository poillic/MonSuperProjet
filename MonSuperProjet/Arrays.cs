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
            float res = 0;

            foreach ( float n in array )
            {
                res += n;
            }

            return res;
        }

        public int CalculateSum( int[] array )
        {
            int res = 0;

            foreach ( int n in array )
            {
                res += n;
            }

            return res;
        }

        public int BiggestNumber( int[] array )
        {
            int res = array[ 0 ];

            for ( int i = 1; i < array.Length; i++ )
            {
                if( array[i] > res )
                {
                    res = array[ i ];
                }
            }

            return res;
        }

        public int FindMinimum( int[] array )
        {
            int res = array[ 0 ];

            for ( int i = 1; i < array.Length; i++ )
            {
                if( array[ i ] < res  )
                {
                    res = array[ i ];
                }
            }

            return res;
        }

        public string LongestWord( string[] array )
        {
            string res = array[ 0 ];

            for ( int i = 1; i < array.Length; i++ )
            {
                if( array[i].Length > res.Length )
                {
                    res = array[ i ];
                }
            }

            return res;
        }

        public int[] ReverseArray( int[] array )
        {
            int left = 0;
            int right = array.Length - 1;

            while( left < right )
            {
                int tmp = array[ left ];
                array[ left ] = array[ right ];
                array[ right ] = tmp;
                left++;
                right--;
            }

            return array;
        }

        public int CountOccurrences( int[] array, int number )
        {
            int res = 0;

            foreach ( int n in array )
            {
                if ( n == number )
                {
                    res++;
                }
            }

            return res;
        }
    }

}
