using System;
using System.IO;
using NUnit.Framework;

namespace TriviaGame
{
    public class GameRunnerTest
    {
        private StringWriter _writer;

        [SetUp]
        public void Setup()
        {
            _writer = new StringWriter();
            Console.SetOut(_writer);
        }

        [TearDown]
        public void TearDown()
        {
            _writer.Close();
            Console.Out.Close();
            Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));
        }

        [Test]
        public void GoldenMasterTest()
        {
            for (int i = 0; i < 10000; i++)
            {
                GameRunner.Main(new string[] { i.ToString() });

                var expectedContent = _writer.ToString();
                var actualContent = GoldenMaster.GetResult(i);

                Assert.That(actualContent, Is.EqualTo(expectedContent));

                _writer.GetStringBuilder().Clear();
            }
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        [TestCase(6)]
        [TestCase(7)]
        [TestCase(8)]
        [TestCase(9)]
        [TestCase(10)]
        public void IsEven(int number)
        {
            var isEven = number % 2 == 0;

            Assert.IsTrue(isEven);
        }
    }
}
