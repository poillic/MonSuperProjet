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
            string ans = "";
            for (int i = 1; i<10; i++)
            {
                ans += i + " ";
            }
            ans += 10;
            return ans;
        }

        public string ShowEvenNumbers(int n )
        {
            string ans = "0";
            for (int i = 2; i<n+1; i+=2)
            {
                ans += " " + i;
            }
            return ans;
        }

        public int CalculateSum( int n )
        {
            int sum = 0;
            int i = 1;
            while (i < n + 1)
            {
                sum += i;
                i++;
            }
            return sum;
        }

        public int CalculateFactorial( int n )
        {
            int ans = 1;
            for (int i = 2; i<n+1; i++)
            {
                ans *= i;
            }
            return ans;
        }

        public int CountVowels( string text )
        {
            int ans = 0;
            foreach (char letter in text)
            {
                foreach (char voyel in "aeiouAEIOU")
                {
                    if (letter == voyel) ans++;
                }
            }
            return ans;
        }

        public string PrintStars( int n )
        {
            string ans = "";
            for (int i =0; i<n; i++)
            {
                ans += "*";
            }
            return ans;
        }

        public string AlternativePrint( int n, char first, char second )
        {
            string ans = "";

            bool parity = true;
            for (int i=0; i<n; i++)
            {
                if (parity) ans += first;
                else ans += second;
                parity = ! parity;
            }
            return ans;
        }

        public string GeneratePowerOfTwoString( int n )
        {
            string ans = "";
            if (n == 0) return ans;
            else if (n == 1) return "1";
            int power = 1;
            int i = 1;
            do
            {
                ans += power + "\n";
                power *= 2;
                i++;
            } while (i < n);
            return ans + power;
        }
    }
}
