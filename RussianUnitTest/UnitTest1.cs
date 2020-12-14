using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RussianUnitTest
{
    [TestClass]
    public class UnitTest1 //code for testing method
    {
        Russianbullet.RBclass game = new Russianbullet.RBclass();
        
        [TestMethod]
        public void TestMethod1()
        {
            int result = game.ShootingAway(); //testing for shootaway

            Assert.IsTrue(result < 3);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int result = game.Fire(); //testing for fire

            Assert.IsTrue(result < 5);

        }
    }
}
