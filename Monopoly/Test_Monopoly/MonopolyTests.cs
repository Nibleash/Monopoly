using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly;

namespace Test_Monopoly
{
    [TestClass]
    public class MonopolyTests
    {
        [TestMethod]
        public void TestDicesAreEquals1()
        {
            Monopoly.Dices d = new Monopoly.Dices();
            d.Rolls[0] = 1;
            d.Rolls[1] = 1;
            bool res = d.AreEquals();

            Assert.AreEqual(res, true);
        }

        [TestMethod]
        public void TestDicesAreEquals2()
        {
            Monopoly.Dices d = new Monopoly.Dices();
            d.Rolls[0] = 1;
            d.Rolls[1] = 4;
            bool res = d.AreEquals();

            Assert.AreEqual(res, false);
        }
    }


    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void DicesToString1()
        {
            Monopoly.Dices d = new Dices();
            d.Rolls[0] = 1;
            d.Rolls[1] = 2;
            d.Sum = 3;
            string res = d.toString();

            string expectedRes = "Dice n°1 -> 1 || Dice n°2 -> 2\nTotal -> 3\n";


            Assert.AreEqual(res, expectedRes);
        }

        [TestMethod]
        public void DicesToString2()
        {
            Monopoly.Dices d = new Dices();
            d.Rolls[0] = 1;
            d.Rolls[1] = 2;
            d.Sum = 3;
            string res = d.toString();

            string expectedRes = "Dice n°1 -> 1|| Dice n°2 -> 2\nTotal -> 3\n";


            Assert.AreNotEqual(res, expectedRes);
        }
    }



    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void PlayerToString1()
        {
            Monopoly.Player p = new Monopoly.Player("Jeff", "Bold Billionaire");
            string res = p.toString();

            string expectedRes = "Player Jeff also called The Bold Billionaire.";


            Assert.AreEqual(res, expectedRes);
        }

        [TestMethod]
        public void PlayerToString2()
        {
            Monopoly.Player p = new Monopoly.Player("Jeff", "Bold Billionaire");
            string res = p.toString();

            string expectedRes = "Player Jeff alsocalled The Bold Billionaire";


            Assert.AreNotEqual(res, expectedRes);
        }
    }
}
