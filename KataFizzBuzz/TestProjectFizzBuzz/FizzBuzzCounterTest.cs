using KataFizzBuzz;
using NUnit.Framework;
using Moq;
using System.Collections.Generic;
using System.Linq;

namespace TestProjectFizzBuzz
{
    public class Tests
    {

        IFizzBuzzCounter _sut;


        [SetUp]
        public void Setup()
        {
            //var mock = new Mock<IFizzBuzzCounter>();
            //mock.Setup(x => x.Translate(3)).Returns("Fizz");
            //mock.Setup(x => x.Translate(5)).Returns("Buzz");
            //mock.Setup(x => x.Translate(15)).Returns("FizzBuzz");
            //mock.Setup(x => x.Translate(1)).Returns("1");
            //mock.Setup(x => x.Translate(2)).Returns("2");
            //mock.Setup(x => x.Translate(4)).Returns("4");
            //_sut = mock.Object;
            _sut = new FizzBuzzCounter();

        }

        [TestCase(1, ExpectedResult = "1")]
        [TestCase(2, ExpectedResult = "2")]
        [TestCase(3, ExpectedResult = "Fizz")]
        [TestCase(4, ExpectedResult = "4")]
        [TestCase(5, ExpectedResult = "Buzz")]
        [TestCase(15, ExpectedResult = "FizzBuzz")]
        public string TestFizzBuzz(int input) => _sut.Translate(input);

        [Test]        
        public void TestFizzBuzzCounter()
        {
            var expected = new List<string> { "1", "2", "Fizz" }; //continuous until your input number... o try to make a new test
            var actual = _sut.Counter(3);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestFizzBuzzCounter2()
        {            
            List<string> actual = _sut.Counter(30);
            Assert.AreEqual(8, actual.Where(x => x == "Fizz").Count());
            Assert.AreEqual(4, actual.Where(x => x == "Buzz").Count());
            Assert.AreEqual(2, actual.Where(x => x == "FizzBuzz").Count());
        }


    }
}
