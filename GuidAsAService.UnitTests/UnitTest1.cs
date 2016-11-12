using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GuidAsAService.Models;
using System.Text.RegularExpressions;

namespace GuidAsAService.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        GuidService myObj = new GuidService();
        

        [TestMethod]
        public void guidIsNotNull()
        {
            //arrange


            //act 
            var result = myObj.createGuid();

            //assert
            Assert.IsNotNull(result);

        }

        [TestMethod]
        public void guidIsRightLength()
        {
            //arrange


            //act 
            var result = myObj.createGuid();

            //assert
            Assert.AreEqual(result.Length, 36);
        }

        [TestMethod]
        public void guidRegexTest()
        {
            //arrange

            //act
            string pattern = @"[a-fA-F0-9]{8}(?:-[a-fA-F0-9]{4}){3}-[a-fA-F0-9]{12}";
            string input = myObj.createGuid();

            bool result;
            if (Regex.IsMatch(input, pattern))
            {
                result = true;
            } else
            {
                result = false;
            }

            //assert
            Assert.IsTrue(result);
        }
    }
}
