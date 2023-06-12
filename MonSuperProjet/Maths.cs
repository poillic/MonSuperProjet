using System;

namespace MonSuperProjet
{
	public class Maths
	{
		public int age = 10;
		public float time = 10.3f;
		public string name = "Toto";
		public bool isOk = false;

		public int Add( int A, int B )
		{
			return A+B;
		}

		public int Substract( int A, int B )
        {
			return A-B;
        }

		public float Multiply( float A, float B )
		{
			return A*B;
		}

		public float Divide( float A, float B )
        {
			return A/B;
        }

		public int Modulo( int A, int B )
        {
			return A%B;
        }

		public float Double( float number )
        {
			return 2*number;
        }

		public float RectanglePerimeter( float width, float height )
		{
			return Double(width) + Double(height);
		}

		public float RectangleArea( float width, float height )
		{
			return width*height;
		}

		public int CalculateAge( int birthyear )
        {
			return DateTime.Now.Year - birthyear;

		}

		public float CalculateBMI( float height, float mass )
		{
			return mass / (height*height);
		}

		public float CelsiusToFahrenheit( float celsius )
        {
			return celsius * 9 / 5 + 32;
        }

		public float FahrenheitToCelsius( float fahrenheit )
		{
			return (fahrenheit - 32) * 5/9;
		}

		public string AddZ( string word )
        {
			return word + "Z";
        }
	}
}
