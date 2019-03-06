using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AwesomeCalculator;
using NUnit.Framework;


namespace CalcAppTest

{
    [TestFixture]
    class CalcTests
    {
        [Test]
        public void GetAddition_Input4point5and8point0_Returns12point5()
        {

            //Arrange
            double number1 = 4.5;
            double number2 = 8.0;

            double expectedResult = number1 + number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetAddition();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetAddition_Input50point5and10point0_Returns60point5()
        {

            //Arrange
            double number1 = 50.5;
            double number2 = 10.0;

            double expectedResult = number1 + number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetAddition();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]

        public void GetAddition_Input90and30_Returns120()
        {

            //Arrange
            int number1 = 90;
            int number2 = 30;

            int expectedResult = number1 + number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetAddition();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetSubtraction_Input15and10_Returns5()
        {

            //Arrange
            int number1 = 15;
            int number2 = 10;

            int expectedResult = number1 - number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetSubtraction();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetSubtraction_Input20point5and15point5_Returns10()
        {

            //Arrange
            double number1 = 20.5;
            double number2 = 15.5;

            double expectedResult = number1 - number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetSubtraction();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetSubtraction_Inputp25oint8and5point3_Returns20point5()
        {

            //Arrange
            double number1 = 25.8;
            double number2 = 5.3;

            double expectedResult = number1 - number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetSubtraction();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetMultiplication_Input3and3_Returns9()
        {

            //Arrange
            double number1 = 3;
            double number2 = 3;

            double expectedResult = number1 * number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetMultiplication();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetMultiplication_Input10and5_Returns50()
        {

            //Arrange
            double number1 = 10;
            double number2 = 5;

            double expectedResult = number1 * number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetMultiplication();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetMultiplication_Input2point5and9_Returns22point5()
        {

            //Arrange
            double number1 = 2.5;
            double number2 = 9;

            double expectedResult = number1 * number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetMultiplication();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetDivision_Input12and12_Returns1()
        {

            //Arrange
            double number1 = 12;
            double number2 = 12;

            double expectedResult = number1 * number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetDivision();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetDivision_Input40and10_Returns4()
        {

            //Arrange
            double number1 = 40;
            double number2 = 10;

            double expectedResult = number1 * number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetDivision();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetDivision_Input100and10_Returns10()
        {

            //Arrange
            double number1 = 100;
            double number2 = 10;

            double expectedResult = number1 * number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetDivision();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetDivision_Input1and3_Returns0point333()
        {

            //Arrange
            double number1 = 1;
            double number2 = 3;

            double expectedResult = number1 * number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetDivision();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetDivision_Input2and1_Returns2()
        {

            //Arrange
            double number1 = 2;
            double number2 = 1;

            double expectedResult = number1 * number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetDivision();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetDivision_Input9and3_Returns3()
        {

            //Arrange
            double number1 = 9;
            double number2 = 3;

            double expectedResult = number1 * number2;

            Calc testCalc = new Calc(number1, number2);

            //Act
            double actualResult = testCalc.GetDivision();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
