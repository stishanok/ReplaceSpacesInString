using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Replace.Replace;

namespace ReplaceTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void ReplaceSpaces_A_BC_DF_ADS_10()
        {
            //arrange
            string str = "A BC DF ADS";
            int lenght = 10;
            string expected = "A%20BC%20DF%20AD";

            //act
            string actual = ReplaceSpaces(str, lenght);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReplaceSpaces_A_BC_DF_ADS_9()
        {
            //arrange
            string str = "A   BC DF ADS";
            int lenght = 9;
            string expected = "A%20%20%20BC%20DF";

            //act
            string actual = ReplaceSpaces(str, lenght);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReplaceSpaces_A_BC_DF_ADS_0()
        {
            //arrange
            string str = "A   BC DF ADS";
            int lenght = 0;
            string expected = "";

            //act
            string actual = ReplaceSpaces(str, lenght);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReplaceSpaces_A_BC_DF_ADS_22()
        {
            //arrange
            string str = "A BC DF ADS";
            int lenght = 22;

            //act + assert
            Assert.ThrowsException<ArgumentException>(() => ReplaceSpaces(str, lenght));
        }

        [TestMethod]
        public void ReplaceSpaces_A_BC_DF_ADS_Minus1()
        {
            //arrange
            string str = "A BC DF ADS";
            int lenght = -1;

            //act + assert
            Assert.ThrowsException<ArgumentException>(() => ReplaceSpaces(str, lenght));
        }

        [TestMethod]
        public void ReplaceSpaces_Null_22()
        {
            //arrange
            string str = null;
            int lenght = 22;

            //act + assert
            Assert.ThrowsException<ArgumentNullException>(() => ReplaceSpaces(str, lenght));
        }
    }
}