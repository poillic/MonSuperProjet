using Microsoft.VisualStudio.TestTools.UnitTesting;
using MonSuperProjet;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Ex1_ClassVariable()
        {
            Maths m = new Maths();
            Assert.AreEqual( 10, m.age );
            Assert.AreEqual( 10.3f, m.time );
            Assert.AreEqual( "Toto", m.name );
            Assert.AreEqual( false, m.isOk );
        }

        [TestMethod]
        public void Ex2_Add()
        {
            Maths m = new Maths();
            Assert.AreEqual( 6, m.Add( 4, 2 ) );
            Assert.AreEqual( -10, m.Add( 10, -20 ) );
        }

        [TestMethod]
        public void Ex3_Substract()
        {
            Maths m = new Maths();
            Assert.AreEqual( 10, m.Substract( 12, 2 ) );
            Assert.AreEqual( 725, m.Substract( 735, 10 ) );
            Assert.AreEqual( -725, m.Substract( 10, 735 ) );
        }

        [TestMethod]
        public void Ex4_Multiply()
        {
            Maths m = new Maths();
            Assert.AreEqual( 24f, m.Multiply( 12f, 2f ) );
            Assert.AreEqual( 7350f, m.Multiply( 735f, 10f ) );
        }

        [TestMethod]
        public void Ex5_Divide()
        {
            Maths m = new Maths();
            Assert.AreEqual( 6f, m.Divide( 12f, 2f ) );
            Assert.AreEqual( 73.5f, m.Divide( 735f, 10f ) );
        }

        [TestMethod]
        public void Ex6_Modulo()
        {
            Maths m = new Maths();
            Assert.AreEqual( 1, m.Modulo( 15, 2 ) );
            Assert.AreEqual( 3, m.Modulo( 27, 6 ) );
        }

        [TestMethod]
        public void Ex7_Double()
        {
            Maths m = new Maths();
            Assert.AreEqual( 154f, m.Double( 77f ) );
            Assert.AreEqual( 11f, m.Double( 5.5f ) );
        }

        [TestMethod]
        public void Ex8_RectanglePerimeter()
        {
            Maths m = new Maths();
            Assert.AreEqual( 46f, m.RectanglePerimeter( 20f, 3f ) );
            Assert.AreEqual( 60f, m.RectanglePerimeter( 20f, 10f ) );
        }

        [TestMethod]
        public void Ex9_RectangleArea()
        {
            Maths m = new Maths();
            Assert.AreEqual( 60f, m.RectangleArea( 20f, 3f ) );
            Assert.AreEqual( 200f, m.RectangleArea( 20f, 10f ) );
        }

        [TestMethod]
        public void Ex_AddZ()
        {
            Maths m = new Maths();
            Assert.AreEqual( "MarioZ", m.AddZ( "Mario" ) );
            Assert.AreEqual( "BatmanZ", m.AddZ( "Batman" ) );
        }
    }
}
