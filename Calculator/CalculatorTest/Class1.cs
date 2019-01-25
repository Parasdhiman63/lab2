using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Calculator;

namespace CalculatorTest
{
    public class Class1
    {
        [TestFixture]
        class CalcTests
        { 
            [Test]
            public void GetAddition_Input3point4and5point6_Returns9point0()
            { //Arrange
                double number1 = 3.4;
                double number2 = 5.6;
                double expectedResult = number1 + number2;
                Calc testCalc = new   Calc(number1, number2);
                //Act
                double actualResult = testCalc.GetAddition();
                //Assert 
                Assert.AreEqual(expectedResult, actualResult);}
        }

            
    
        [Test]
        public void GetAddition_Input500and1_Returns501()
        { //Arrange
            double number1 = 500;
            double number2 = 1;
            double expectedResult = number1 + number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetAddition();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetAddition_Input205and100_Returns305()
        { //Arrange
            double number1 = 205;
            double number2 = 100;
            double expectedResult = number1 + number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetAddition();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetMultiplication_Input6and2_Returns12()
        { //Arrange
            double number1 = 6;
            double number2 = 2;
            double expectedResult = number1 * number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetMultiplication();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetMultiplication_Input3and15_Returns45()
        { //Arrange
            double number1 = 3;
            double number2 = 15;
            double expectedResult = number1 * number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetMultiplication();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetMultiplication_Input100and200_Returns20000()
        { //Arrange
            double number1 = 100;
            double number2 = 200;
            double expectedResult = number1 * number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetMultiplication();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetSubtraction_Input1point5and2point5_Returns1point0()
        { //Arrange
            double number1 = 1.5;
            double number2 = 2.5;
            double expectedResult = number1 - number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetSubtraction();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetSubtraction_Input5point3and8_Returns2point7()
        { //Arrange
            double number1 = 5.3;
            double number2 = 8;
            double expectedResult = number1 - number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetSubtraction();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetSubtraction_Input66and200_Returns134()
        { //Arrange
            double number1 = 66;
            double number2 = 200;
            double expectedResult = number1 - number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetSubtraction();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetDivision_Input0and77_Returns0()
        { //Arrange
            double number1 = 0;
            double number2 = 77;
            double expectedResult = number1 / number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetDivision();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetDivision_Input33and22_Returns1point5()
        { //Arrange
            double number1 = 33;
            double number2 = 22;
            double expectedResult = number1 / number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetDivision();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetDivision_Input150and100_Returns15()
        { //Arrange
            double number1 = 150;
            double number2 = 100;
            double expectedResult = number1 / number2;
            Calc testCalc = new Calc(number1, number2);
            //Act
            double actualResult = testCalc.GetDivision();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

    }

}

