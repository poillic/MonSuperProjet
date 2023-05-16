using System;

public class Conditions
{
	public bool EvenOdd( int number )
	{
		return number % 2 == 0; 
	}

	public float Bigger( float number1, float number2 )
    {
		return number1 >= number2 ? number1 : number2;
    }

	public bool OddAndMoreTen( int number )
    {
		return number % 2 == 1 && number > 10f;
    }

	public bool ThreeAndFive( int number )
    {
		return number % 3 == 0 && number % 5 == 0;
    }

	public bool IsMultiple( int number, int multiple )
    {
		return number % multiple == 0;
    }

	public bool IsTriangleRectangle( int a, int b, int c )
    {
        if ( a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a )
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool IsVowel( char letter )
    {
        letter = char.ToLower( letter );
        if ( letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u' )
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
