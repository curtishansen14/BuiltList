using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BuildList;

namespace CustomListTests
{
    [TestClass]
    public class CustomListTests
 
    {
        //*******************Add Tests*************************
        
        [TestMethod]
        public void Add_OneInt_AddInt()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            

            int expected = 11;

            //Act
            list.Add(11);

            //Assert
            Assert.AreEqual(expected, list[0]);
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

        [TestMethod]
        public void Add_Count_updateCount()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 1;

            //Act
            list.Add(expected);
            //Assert
            Assert.AreEqual(expected, list.Count);
        }

        [TestMethod]

        public void Add_ExistingArrary_AddtoExistingList()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 1;
            int filler = 4;
            //Act
            list.Add(filler);
            list.Add(filler);
            list.Add(filler);
            list.Add(1);
            //Assert
            Assert.AreEqual(expected, list[3]);
        }

        [TestMethod]

        public void Add_GreaterThanCapacity_AddCapacity()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int filler = 3;
            int expected = 1;
            //Act
            list.Add(filler);
            list.Add(filler);
            list.Add(filler);
            list.Add(filler);
            list.Add(filler);
            list.Add(filler);
            list.Add(1);
            //Assert
            Assert.AreEqual(expected, list[6]);

        }
        //************************Remove Tests**********************************

        [TestMethod]
        public void Remove_OneInt_RemoveInt()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 10, 9, 8, 7, 8 };

            int expected = 7;

            //Act
            list.Remove(8);

            //Assert
            Assert.AreEqual(expected, list[2]);
        }

        [TestMethod]
        public void Remove_OneInt_CheckSecondInt()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 10, 9, 8, 7, 8 };

            int expected = 8;

            //Act
            list.Remove(8);

            //Assert
            Assert.AreEqual(expected, list[3]);
        }

        [TestMethod]
        public void Remove_Widget_RemoveWidget()
        {
            //Arrange
            Widget widget = new Widget();
            Widget thing = new Widget();
            Widget doodad = new Widget();
            CustomList<Widget> list = new CustomList<Widget>() { widget, thing, doodad, thing };


            //Act
            list.Remove(thing);

            //Assert
            Assert.AreEqual(doodad, list[1]);
        }

        [TestMethod]
        public void Remove_Widget_CheckForSecond()
        {
            //Arrange
            Widget widget = new Widget();
            Widget thing = new Widget();
            Widget doodad = new Widget();
            CustomList<Widget> list = new CustomList<Widget>() { widget, thing, doodad, thing };


            //Act
            list.Remove(thing);

            //Assert
            Assert.AreEqual(thing, list[2]);
        }

        [TestMethod]
        public void Remove_Count_updateCount()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 10, 9, 8, 7, 8 };
            int expected = 4;

            //Act
            list.Remove(8);
            //Assert
            Assert.AreEqual(expected, list.Count);
        }

        [TestMethod]

        public void Remove_BoolYes_RemoveBool()
        {
            //if this test removes something it returns true 
            // if it doesn't returns false

            // Arrange
            Widget widget = new Widget();
            Widget thing = new Widget();
            Widget doodad = new Widget();
            CustomList<Widget> list = new CustomList<Widget>() { widget, thing, doodad, thing };
            bool expected = true;

            //Act

            bool result = list.Remove(doodad);
            //Assert 
            Assert.AreEqual(expected, result);
               
        }
        //*********************Over Ride to String************************

        [TestMethod]

        public void toString_OverideInt_List()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4, 5 };
            string expected = "1";

            //Act
            list.ToString();

            //Assert 
            Assert.AreEqual(expected, list[0]);
        }

        [TestMethod]

        public void toString_OverideObject_list()
        {
            //Arrange

            //Act

            //Assert 
        }
    }
}
