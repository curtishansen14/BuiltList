using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BuildList;

namespace CustomListTests
{
    [TestClass]
    public class CustomListTests
    {
        [TestMethod]
        public void Add_OneNumber_AddIndex()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 11;

            //Act
            list.Add(11);

            //Assert
            Assert.AreSame(expected, list[0]);
            

        }
    }
}
