using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GuidAsAService.Models;

namespace GuidAsAService.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void guidIsNotNull()
        {
            //arrange
            newGuid myGuid = new newGuid(); 

            //act 
            
            //assert
            Assert.IsNotNull(myGuid);

        }



    }
}
