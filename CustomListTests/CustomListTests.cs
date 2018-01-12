using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BuildList;

namespace CustomListTests
{
    [TestClass]
    public class CustomListTests
 
    {
        
        [TestMethod]
        public void Add_OneInt_AddInt()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            

            int expected = 11;

            //Act
            list.Add(11);

            //Assert
            Assert.AreSame(expected, list[0]);
        }

        public void Add_ManyInts_Add10Ints()
        {

            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 7;
            //Act
            list.Add(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

            //Assert
            Assert.AreSame(expected, list[6]);
        }

        public void Add_OneString_AddString()
        {

            //Arrange
            CustomList<string> list = new CustomList<string>();
            string expected = "Bonjour";
            //Act
            list.Add("Bonjour");
            //Assert
            Assert.AreSame(expected, list[0]);
        }



    }
}
