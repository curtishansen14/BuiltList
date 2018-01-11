using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BuildList;

namespace BuildListTest
{
    [TestClass]
    public class AddTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            Add add = new Add();
            Box<int> box = new Box<int>();


            //Act
            add = add.add()

            //Assert
            Assert.AreSame(box, )
        }
    }
}
