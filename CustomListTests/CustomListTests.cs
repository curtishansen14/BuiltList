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

        [TestMethod]

        public void Add_byte_Addbyte()
        {
            //Arrange
            CustomList<byte> list = new CustomList<byte>();
            byte expected = 255;
            //Act
            list.Add(255);
            //Assert
            Assert.AreSame(expected, list[0]);
        }

        [TestMethod]

        public void Add_char_Addchar()
        {
            //Arrange
            CustomList<char> list = new CustomList<char>();
            char expected = '\x0058';
            //Act
            list.Add('\x0058');
            //Assert
            Assert.AreSame(expected, list[0]);
        }

        [TestMethod]

        public void Add_decimal_Adddecimal()
        {
            //Arrange
            CustomList<decimal> list = new CustomList<decimal>();
            decimal expected = Decimal.MaxValue;
            //Act
            list.Add(Decimal.MaxValue);
            //Assert
            Assert.AreSame(expected, list[0]);
        }

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

    }
}
