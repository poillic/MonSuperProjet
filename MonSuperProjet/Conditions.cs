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
		return number % 2 == 0 && number > 10f;
    }

	public bool ThreeAndFive( int number )
    {
		return number % 3 == 0 && number % 5 == 0;
    }

	public bool IsMultiple( int number, int multiple )
    {
		return number % multiple == 0;
    }
}
