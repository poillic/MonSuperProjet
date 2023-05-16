using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonSuperProjet
{
    public class Loops
    {
        public string ShowEvenNumbers(int n )
        {
            string result = "";

            for ( int i = 0; i <= n; i+=2 )
            {
                result += i+" ";
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
    }
}
