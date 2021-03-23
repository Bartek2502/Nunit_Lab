using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Nunit_Lab;

namespace ClassLibrary1
{


    [TestFixture]
    public class DivisibleNbTests
    {
        static DivisibleNb  x;
        [SetUp]
        public static void Initialise()
        {
            x = new DivisibleNb();
        }
        [Test]
        public void Test1()
        {
            Assert.AreEqual(true, x.isDivisible(12, 4, 3));
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual(false, x.isDivisible(3, 3, 4));
        }
        [Test]
        public void Test3()
        {
            Assert.AreEqual(false, x.isDivisible(8, 3, 4));
        }

    }


}
