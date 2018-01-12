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


        [TestMethod]


        public void Add_Widget_AddWidget()
        {
            //Arrange
            Widget expected;
            expected = new Widget();

            CustomList<Widget> list = new CustomList<Widget>();

            //Act
            list.Add(expected);

            //Assert
            Assert.AreSame(expected, list[0]);
        }
        // what does the add do?
        // add to an already existing list
        // change count 

        [TestMethod]
        public void Add_Count_updateCount()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 1;
            int thing = 3;
            //Act
            list.Kount(list.Add(expected));
            //Assert
            Assert.AreSame(expected, list.Kount(thing));
        }

        [TestMethod]
        public void Add_UpdateExisting_AddtoExistingList()
        {

        }
    }
}
