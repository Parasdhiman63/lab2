using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ass8040;
using NUnit.Framework;

namespace Test8040
{
    [TestFixture]

    class Test8040
    {
        [Test]

        public void GetLength_input10_expectLengthEquals10()

        {
            //Arrange
            int len = 10;
            int wid = 8;
             Rectangle testRectangle = new Rectangle(len, wid);

            //Act
            int length = testRectangle.GetLength();

            //Assert
            Assert.AreEqual(length, len);
            
        }

        [Test]
        public void GetWidth_input8_expectWidthEquals8()

        {
            //Arrange
            int len = 10;
            int wid = 8;
            Rectangle testRectangle = new Rectangle(len, wid);

            //Act
            int width = testRectangle.GetWidth();

            //Assert
            Assert.AreEqual(width, wid);

        }
        [Test]
        public void SetWidth_input20_expectWidthEquals20()

        {
            //Arrange
            int len = 10;
            int wid = 20;
            Rectangle testRectangle = new Rectangle(len, wid);

            //Act
            int width = testRectangle.SetWidth(wid);

            //Assert
            Assert.AreEqual(width, wid);

        }
        [Test]
        public void SetLength_input10_expectWidthEquals10()

        {
            //Arrange
            int len = 10;
            int wid = 20;
            Rectangle testRectangle = new Rectangle(len, wid);

            //Act
            int length = testRectangle.SetLength(len);

            //Assert
            Assert.AreEqual(length,len);

        }
        [Test]
        public void GetPerimeter_inputlength25andwidth15_expectPerimeterEquals80()

        {
            //Arrange
            int len = 25;
            int wid = 15;
            Rectangle testRectangle = new Rectangle(len, wid);

            //Act
            int Perimeter = testRectangle.GetPerimeter();

        }
        [Test]
        public void GetArea_inputlength30andwidth5_expectWidthEquals150()

        {
            //Arrange
            int len = 30;
            int wid = 5;
            Rectangle testRectangle = new Rectangle(len, wid);

            //Act
            int Area = testRectangle.GetArea();

        }


    }
}
