using System;

public class Conditions
{
    public bool IsPositive( int number )
    {
        return number >= 0;
    }

	public bool IsEven( int number )
	{
		return (number%2) == 0; 
	}

	public float Bigger( float number1, float number2 )
    {
        if (number1 >= number2) return number1;
        else return number2;
    }

    public bool CompareThreeNumbers( int a, int b, int c )
    {
        return a == b || a == c;
    }

	public bool OddAndMoreTen( int number )
    {
		return number >= 10 && ! IsEven(number);
    }

	public bool ThreeAndFive( int number )
    {
		return number % 15 == 0;
    }

	public bool IsMultiple( int number, int multiple )
    {
		return number % multiple == 0;
    }

    public bool IsInRange( int number, int min, int max )
    {
        return min <= number && number <= max;
    }

    public bool IsLeapYear( int year )
    {
        if (year % 4 == 0)
        {
            if ( year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    return true;
                }
                return false;
            }
            return true;
        }
        return false;
    }

    public bool IsTriangleRectangle( int a, int b, int c )
    {
       return c*c == a*a + b*b;
    }

    public bool IsVowel( char letter )
    {
        return letter == 'a' || letter == 'A' || letter == 'e' || letter == 'E' || letter == 'i' || letter == 'I' || letter == 'o' || letter == 'O' || letter == 'u' || letter == 'U' || letter == 'y' || letter == 'Y';
    }

    public int MaxOfThreeNumbers( int a, int b, int c )
    {
        int max = a;
        if (b > max) max = b;
        if (c > max) max = c;
        return max;
    }
}
