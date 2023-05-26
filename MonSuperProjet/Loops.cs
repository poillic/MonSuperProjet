using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonSuperProjet
{
    public class Loops
    {
        public string ShowOneToTen()
        {
            string result = "";

            for ( int i = 1; i <= 10; i++ )
            {
                result += i.ToString();

                if( i < 10 )
                {
                    result += " ";
                }
            }

            return result;
        }

        public string ShowEvenNumbers(int n )
        {
            string result = "";

            for ( int i = 0; i <= n; i+=2 )
            {
                result += i;

                if( i+1 < n )
                {
                    result += " ";
                }
            }

            return result;
        }

        public int CalculateSum( int n )
        {
            int result = 0;
            int i = 1;

            while( i <= n )
            {
                result += i;
                i++;            }
            return result;
        }

        public int CountVowels( string text )
        {
            int count = 0;
            char[] voyelles = { 'a', 'e', 'i', 'o', 'u' };
            foreach ( char lettre in text.ToLower() )
            {
                if ( voyelles.Contains( lettre ) )
                {
                    count++;
                }
            }
            return count;
        }

        

        public string GeneratePowerOfTwoString( int n )
        {
            string result = "";
            int power = 1;
            int count = 0;

            if( n <= 0 )
            {
                return result;
            }

            do
            {
                result += power.ToString();

                if( count < n - 1 )
                {
                    result += " ";
                }

                power *= 2;
                count++;
            } while ( count < n );

            return result;
        }
    }
}
