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

            //false positive? 
        }

    }
}
