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
        public void A_EvenOdd()
        {
            Conditions c = new Conditions();
            Assert.IsTrue( c.EvenOdd( 12 ) );
            Assert.IsTrue( c.EvenOdd( -120 ) );
            Assert.IsFalse( c.EvenOdd( 97 ) );
            Assert.IsFalse( c.EvenOdd( -67 ) );
        }

        [TestMethod]
        public void B_Bigger()
        {
            Conditions c = new Conditions();
            Assert.AreEqual( 24f, c.Bigger( 24f, 12f ) );
            Assert.AreEqual( 24f, c.Bigger( 12f, 24f ) );
            Assert.AreEqual( 12.3f, c.Bigger( 12.3f, -12.4f ) );
        }

        [TestMethod]
        public void C_OddAndMoreTen()
        {
            Conditions c = new Conditions();
            Assert.IsTrue( c.OddAndMoreTen( 12 ) );
            Assert.IsTrue( c.OddAndMoreTen( 1156 ) );
            Assert.IsFalse( c.OddAndMoreTen( 10 ) );
            Assert.IsFalse( c.OddAndMoreTen( 11 ) );
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

    }
}
