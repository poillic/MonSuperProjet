using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MonSuperProjet;

namespace TestProject1
{
    [TestClass]
    public class TestsMaths
    {
        [TestMethod]
        public void A_ClassVariable()
        {
            Maths m = new Maths();
            Assert.AreEqual( 10, m.age );
            Assert.AreEqual( 10.3f, m.time );
            Assert.AreEqual( "Toto", m.name );
            Assert.AreEqual( false, m.isOk );
        }

        [TestMethod]
        public void B_Add()
        {
            Maths m = new Maths();
            Assert.AreEqual( 6, m.Add( 4, 2 ) );
            Assert.AreEqual( -10, m.Add( 10, -20 ) );
        }

        [TestMethod]
        public void C_Substract()
        {
            Maths m = new Maths();
            Assert.AreEqual( 10, m.Substract( 12, 2 ) );
            Assert.AreEqual( 725, m.Substract( 735, 10 ) );
            Assert.AreEqual( -725, m.Substract( 10, 735 ) );
        }

        [TestMethod]
        public void D_Multiply()
        {
            Maths m = new Maths();
            Assert.AreEqual( 24f, m.Multiply( 12f, 2f ) );
            Assert.AreEqual( 7350f, m.Multiply( 735f, 10f ) );
        }

        [TestMethod]
        public void E_Divide()
        {
            Maths m = new Maths();
            Assert.AreEqual( 6f, m.Divide( 12f, 2f ) );
            Assert.AreEqual( 73.5f, m.Divide( 735f, 10f ) );
        }

        [TestMethod]
        public void F_Modulo()
        {
            Maths m = new Maths();
            Assert.AreEqual( 1, m.Modulo( 15, 2 ) );
            Assert.AreEqual( 3, m.Modulo( 27, 6 ) );
        }

        [TestMethod]
        public void G_Double()
        {
            Maths m = new Maths();
            Assert.AreEqual( 154f, m.Double( 77f ) );
            Assert.AreEqual( 11f, m.Double( 5.5f ) );
        }

        [TestMethod]
        public void H_RectanglePerimeter()
        {
            Maths m = new Maths();
            Assert.AreEqual( 46f, m.RectanglePerimeter( 20f, 3f ) );
            Assert.AreEqual( 60f, m.RectanglePerimeter( 20f, 10f ) );
        }

        [TestMethod]
        public void I_RectangleArea()
        {
            Maths m = new Maths();
            Assert.AreEqual( 60f, m.RectangleArea( 20f, 3f ) );
            Assert.AreEqual( 200f, m.RectangleArea( 20f, 10f ) );
        }

        [TestMethod]
        public void J_CalculateAge()
        {
            Maths m = new Maths();
            int age = 26;
            Assert.AreEqual( age, m.CalculateAge( DateTime.Now.Year - age ) );
            age = 89;
            Assert.AreEqual( age, m.CalculateAge( DateTime.Now.Year - age ) );
        }

        [TestMethod]
        public void K_CalculateBMI()
        {
            Maths m = new Maths();

            Assert.AreEqual( 32.65306f, m.CalculateBMI(1.75f, 100f), 0.01f );
            Assert.AreEqual( 28.344671f, m.CalculateBMI( 1.68f, 80f ), 0.01f );
        }

        [TestMethod]
        public void L_CelsiusToFahrenheit()
        {
            Maths m = new Maths();

            Assert.AreEqual( 59f, m.CelsiusToFahrenheit( 15f ), 0.01f );
            Assert.AreEqual( 42.8f, m.CelsiusToFahrenheit( 6f ), 0.01f );
            Assert.AreEqual( 86f, m.CelsiusToFahrenheit( 30f ), 0.01f );
        }

        [TestMethod]
        public void M_FahrenheitToCelsius()
        {
            Maths m = new Maths();

            Assert.AreEqual( 15f, m.FahrenheitToCelsius( 59f ), 0.01f );
            Assert.AreEqual( 6f, m.FahrenheitToCelsius( 42.8f ), 0.01f );
            Assert.AreEqual( 30f, m.FahrenheitToCelsius( 86f ), 0.01f );
        }

        [TestMethod]
        public void Ex_AddZ()
        {
            Maths m = new Maths();
            Assert.AreEqual( "MarioZ", m.AddZ( "Mario" ) );
            Assert.AreEqual( "BatmanZ", m.AddZ( "Batman" ) );
        }
    }

    [TestClass]
    public class TestConditions
    {
        [TestMethod]
        public void A_IsPositive()
        {
            Conditions c = new Conditions();
            Assert.IsTrue( c.IsPositive( 12 ) );
            Assert.IsFalse( c.IsPositive( -120 ) );
            Assert.IsTrue( c.IsPositive( 97 ) );
            Assert.IsFalse( c.IsPositive( -67 ) );
        }

        [TestMethod]
        public void B_IsEven()
        {
            Conditions c = new Conditions();
            Assert.IsTrue( c.IsEven( 12 ) );
            Assert.IsTrue( c.IsEven( -120 ) );
            Assert.IsFalse( c.IsEven( 97 ) );
            Assert.IsFalse( c.IsEven( -67 ) );
        }

        [TestMethod]
        public void C_Bigger()
        {
            Conditions c = new Conditions();
            Assert.AreEqual( 24f, c.Bigger( 24f, 12f ) );
            Assert.AreEqual( 24f, c.Bigger( 12f, 24f ) );
            Assert.AreEqual( 12.3f, c.Bigger( 12.3f, -12.4f ) );
        }

        [TestMethod]
        public void CompareThreeNumbers()
        {
            Conditions c = new Conditions();
            Assert.IsTrue( c.CompareThreeNumbers( 24, 12, 24 ) );
            Assert.IsFalse( c.CompareThreeNumbers( 12, 24, 15 ) );
            Assert.IsTrue( c.CompareThreeNumbers(-5, -5, 5 ) );
            Assert.IsFalse( c.CompareThreeNumbers( -12, 12, 15 ) );
        }

        [TestMethod]
        public void C_OddAndMoreTen()
        {
            Conditions c = new Conditions();
            Assert.IsTrue( c.OddAndMoreTen( 13 ) );
            Assert.IsTrue( c.OddAndMoreTen( 1157 ) );
            Assert.IsFalse( c.OddAndMoreTen( 10 ) );
            Assert.IsFalse( c.OddAndMoreTen( 12 ) );
            Assert.IsFalse( c.OddAndMoreTen( -9 ) );
        }

        [TestMethod]
        public void D_ThreeAndFive()
        {
            Conditions c = new Conditions();
            Assert.IsTrue( c.ThreeAndFive( 15 ) );
            Assert.IsTrue( c.ThreeAndFive( 450 ) );
            Assert.IsFalse( c.ThreeAndFive( 3 ) );
            Assert.IsFalse( c.ThreeAndFive( 5 ) );
            Assert.IsFalse( c.ThreeAndFive( -9 ) );
        }

        [TestMethod]
        public void E_IsMultiple()
        {
            Conditions c = new Conditions();
            Assert.IsTrue( c.IsMultiple( 15, 3 ) );
            Assert.IsTrue( c.IsMultiple( 450, 15 ) );
            Assert.IsFalse( c.IsMultiple( 3, 16 ) );
            Assert.IsFalse( c.IsMultiple( 5, 2 ) );
            Assert.IsFalse( c.IsMultiple( -9, 6 ) );
        }

        [TestMethod]
        public void E_IsInRange()
        {
            Conditions c = new Conditions();
            Assert.IsTrue( c.IsInRange( 15, 3, 20 ) );
            Assert.IsTrue( c.IsInRange( 450, 449, 500 ) );
            Assert.IsFalse( c.IsInRange( 3, 16, 32 ) );
            Assert.IsFalse( c.IsInRange( 5, -5, 4 ) );
            Assert.IsFalse( c.IsInRange( -9, 6, 10 ) );
        }

        [TestMethod]
        public void IsLeapYear()
        {
            Conditions c = new Conditions();
            Assert.IsTrue( c.IsLeapYear( 2024 ) );
            Assert.IsTrue( c.IsLeapYear( 2016 ) );
            Assert.IsFalse( c.IsLeapYear( 2022 ) );
            Assert.IsFalse( c.IsLeapYear( 2023 ) );
            Assert.IsFalse( c.IsLeapYear( 1995 ) );
        }

        [TestMethod]
        public void MaxOfThreeNumbers()
        {
            Conditions c = new Conditions();
            Assert.AreEqual( 3, c.MaxOfThreeNumbers( 1,2,3 ) );
            Assert.AreEqual( 3, c.MaxOfThreeNumbers( 2,3,1 ) );
            Assert.AreEqual( 3, c.MaxOfThreeNumbers( 3,2,1 ) );
            Assert.AreEqual( 3, c.MaxOfThreeNumbers( 2,1,3 ) );
            Assert.AreEqual( 3, c.MaxOfThreeNumbers( 3,1,2 ) );
        }

        [TestMethod]
        public void F_IsTriangleRectangle()
        {
            Conditions c = new Conditions();

            Assert.IsTrue( c.IsTriangleRectangle( 3,4,5 ) );
            Assert.IsTrue( c.IsTriangleRectangle( 5,12,13 ) );
            Assert.IsTrue( c.IsTriangleRectangle( 6,8,10 ) );
            Assert.IsFalse( c.IsTriangleRectangle( 1,8,5 ) );
            Assert.IsFalse( c.IsTriangleRectangle( 7,8,5 ) );
        }

        [TestMethod]
        public void G_IsVowel()
        {
            Conditions c = new Conditions();

            Assert.IsTrue( c.IsVowel( 'a') );
            Assert.IsTrue( c.IsVowel( 'E' ) );
            Assert.IsTrue( c.IsVowel( 'U' ) );
            Assert.IsFalse( c.IsVowel( 'b' ) );
            Assert.IsFalse( c.IsVowel( 'z' ) );
        }


    }

    [TestClass]
    public class TestLoops
    {
        [TestMethod]
        public void ShowOneToTen()
        {
            Loops l = new Loops();
            Assert.AreEqual( "1 2 3 4 5 6 7 8 9 10", l.ShowOneToTen() );
        }

        [TestMethod]
        public void A_ShowEvenNumbers()
        {
            Loops l = new Loops();
            Assert.AreEqual( "0 2 4 6", l.ShowEvenNumbers( 6 ) );
            Assert.AreEqual( "0 2 4 6", l.ShowEvenNumbers( 7 ) );
            Assert.AreEqual( "0 2 4 6 8 10 12", l.ShowEvenNumbers( 13 ) );
        }

        [TestMethod]
        public void B_CalculateSum()
        {
            Loops l = new Loops();
            Assert.AreEqual( 21, l.CalculateSum( 6 ) );
            Assert.AreEqual( 28, l.CalculateSum( 7 ) );
            Assert.AreEqual( 91, l.CalculateSum( 13 ) );
        }

        [TestMethod]
        public void V_CalculateFactorial()
        {
            Loops l = new Loops();
            Assert.AreEqual( 720, l.CalculateFactorial( 6 ) );
            Assert.AreEqual( 5040, l.CalculateFactorial( 7 ) );
            Assert.AreEqual( 3628800, l.CalculateFactorial( 10 ) );
        }

        [TestMethod]
        public void C_CountVowel()
        {
            Loops l = new Loops();
            Assert.AreEqual( 2, l.CountVowels( "Calcul" ) );
            Assert.AreEqual( 3, l.CountVowels( "Voyelles" ) );
            Assert.AreEqual( 4, l.CountVowels( "CountVowel" ) );
        }

        [TestMethod]
        public void T_PrintStars()
        {
            Loops l = new Loops();
            Assert.AreEqual( "*", l.PrintStars( 1 ) );
            Assert.AreEqual( "****", l.PrintStars( 4 ) );
            Assert.AreEqual( "******", l.PrintStars( 6 ) );
            Assert.AreEqual( "", l.PrintStars( 0 ) );
        }

        [TestMethod]
        public void T_AlternativePrint()
        {
            Loops l = new Loops();
            Assert.AreEqual( "n", l.AlternativePrint( 1, 'n', 'a') );
            Assert.AreEqual( "bnbn", l.AlternativePrint( 4, 'b', 'n' ) );
            Assert.AreEqual( "lmlmlm", l.AlternativePrint( 6, 'l', 'm' ) );
            Assert.AreEqual( "xdxdxdxdx", l.AlternativePrint( 9, 'x', 'd' ) );
            Assert.AreEqual( "", l.AlternativePrint( 0, 'p', 'm' ) );
        }

        [TestMethod]
        public void GeneratePowerOfTwoString()
        {
            Loops l = new Loops();
            Assert.AreEqual( "1", l.GeneratePowerOfTwoString( 1 ) );
            Assert.AreEqual("1\n2\n4\n8", l.GeneratePowerOfTwoString( 4 ) );
            Assert.AreEqual("1\n2\n4\n8\n16\n32", l.GeneratePowerOfTwoString( 6 ) );
            Assert.AreEqual( "", l.GeneratePowerOfTwoString( 0 ) );
        }
    }

    [TestClass]
    public class TestArrays
    {
        [TestMethod]
        public void A_CalculateSumFloat()
        {
            Arrays a = new Arrays();

            Assert.AreEqual( 10f, a.CalculateSum( new float[]{ 1f, 2f, 3f, 4f } ) );
            Assert.AreEqual( 7f, a.CalculateSum( new float[]{ 0.3f, -0.3f, 3f, 4f } ) );
            Assert.AreEqual( -7f, a.CalculateSum( new float[]{ 0.3f, -0.3f, -3f, -4f } ) );
        }

        [TestMethod]
        public void A_CalculateSumInt()
        {
            Arrays a = new Arrays();

            Assert.AreEqual( 10, a.CalculateSum( new int[] { 1, 2, 3, 4 } ) );
            Assert.AreEqual( -10, a.CalculateSum( new int[] { -1, -2, -3, -4 } ) );
            Assert.AreEqual( -7, a.CalculateSum( new int[] { 3, -3, -3, -4 } ) );
        }

        [TestMethod]
        public void B_BiggestNumber()
        {
            Arrays a = new Arrays();
            Assert.AreEqual( 4, a.BiggestNumber( new int[] { 1, 2, 3, 4 } ) );
            Assert.AreEqual( -1, a.BiggestNumber( new int[] { -1, -2, -3, -4 } ) );
            Assert.AreEqual( 4, a.BiggestNumber( new int[] { 3, -3, 3, 4 } ) );
            Assert.AreEqual( 3, a.BiggestNumber( new int[] { 3, -3, -3, -4 } ) );
            Assert.AreEqual( 3, a.BiggestNumber( new int[] { 3, -3, -3, -4 } ) );
        }

        [TestMethod]
        public void D_FindMinimum()
        {
            Arrays a = new Arrays();
            Assert.AreEqual( 1, a.FindMinimum( new int[] { 1, 2, 3, 4 } ) );
            Assert.AreEqual( -4, a.FindMinimum( new int[] { -1, -2, -3, -4 } ) );
            Assert.AreEqual( -3, a.FindMinimum( new int[] { 3, -3, 3, 4 } ) );
            Assert.AreEqual( -4, a.FindMinimum( new int[] { 3, -3, -3, -4 } ) );
            Assert.AreEqual( -4, a.FindMinimum( new int[] { 3, -3, -3, -4 } ) );
        }

        [TestMethod]
        public void C_LongestWord()
        {
            Arrays a = new Arrays();
            Assert.AreEqual( "aa", a.LongestWord( new string[] { "a", "aa" } ) );
            Assert.AreEqual( "a", a.LongestWord( new string[] { "a", "b" } ) );
            Assert.AreEqual( "Bowser", a.LongestWord( new string[] { "Mario", "Luigi", "Bowser" } ) );
            Assert.AreEqual( "Matsumoto", a.LongestWord( new string[] { "Hamada", "Yamasaki", "Endo", "Tanaka", "Matsumoto" } ) );
        }

        [TestMethod]
        public void D_ReverseArray()
        {
            Arrays a = new Arrays();

            CollectionAssert.AreEqual( new int[] { 2, 1 }, a.ReverseArray( new int[] { 1, 2 } ) );
            CollectionAssert.AreEqual( new int[] { 8,6,4 }, a.ReverseArray( new int[] { 4,6,8 } ) );
            CollectionAssert.AreEqual( new int[] { 4650,65,-15 }, a.ReverseArray( new int[] { -15,65,4650 } ) );
        }

        [TestMethod]
        public void D_CountOccurrences()
        {
            Arrays a = new Arrays();
            Assert.AreEqual( 1, a.CountOccurrences( new int[] { 1, 2, 3, 4 }, 1 ) );
            Assert.AreEqual( 1, a.CountOccurrences( new int[] { -1, -2, -3, -4 }, -4 ) );
            Assert.AreEqual( 2, a.CountOccurrences( new int[] { 3, -3, 3, 4 }, 3 ) );
            Assert.AreEqual( 1, a.CountOccurrences( new int[] { 3, -3, -3, -4 }, 3 ) );
            Assert.AreEqual( 3, a.CountOccurrences( new int[] { 2,4,5,2,2,6,7 },2 ) );
        }
    }
}
