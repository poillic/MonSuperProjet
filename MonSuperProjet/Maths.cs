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
			return A + B;
		}

		public int Substract( int A, int B )
        {
			return A - B;
        }

		public float Multiply( float A, float B )
		{
			return A * B;
		}

		public float Divide( float A, float B )
        {
			return A / B;
        }

		public int Modulo( int A, int B )
        {
			return A % B;
        }

		public float Double( float number )
        {
			return Multiply( number, 2 );
        }

		public float RectanglePerimeter( float width, float height )
		{
			return ( width + height ) * 2f;
		}

		public float RectangleArea( float width, float height )
		{
			return width * height;
		}

		public string AddZ( string word )
        {
			return word + "Z";
        }
	}
}
