namespace Summator.UnitTests
{
    public class SummatorTests
    {
        [Test]

        public void Test_Summator_SumTwoPositiveNumbers()
        {
            var nums = new int[] { 1, 2 };
            var actual = Summator.Sum(nums);

            var expected = 3;

            Assert.AreEqual(expected, actual);
        }
        [Test]

        public void Test_Summator_SumTwoNegativeNumbers()
        {
            var nums = new int[] { -1, -99 };
            var actual = Summator.Sum(nums);

            var expected = -100;

            Assert.AreEqual(expected, actual);
        }
        [Test]

        public void Test_Summator_OneNegative_OnePositive_Numbers()
        {
            var nums = new int[] { 1, -1 };
            var actual = Summator.Sum(nums);

            var expected = 0;
            Assert.AreEqual(expected, actual);
        }
        [Test]

        public void Test_Summator_OneNumber()
        {
            var nums = new int[] { 6 };
            var actual = Summator.Sum(nums);

            var expected = 6;

            Assert.AreEqual(expected, actual);
        }
        [Test]

        public void Test_Summator_ZeroNumber()
        {
            var nums = new int[] { };
            var actual = Summator.Sum(nums);

            var expected = 0;

            Assert.AreEqual(expected, actual);
        }
        [Test]

        public void Test_Summator_BigNumbers()
        {
            var nums = new int[] { 2000000000, 2000000000, 2000000000 };
            var actual = Summator.Sum(nums);

            var expected = 6000000000;

            Assert.AreEqual(expected, actual);
        }
        [Test]

        public void Test_Summator_ThreePositiveNumbers()
        {
            //Arrange
            var nums = new int[] { 1, 2, 88 };
            var expected = 91;

            //Act

            var actual = Summator.Sum(nums);
            //Assert

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test_Average_ThreeNumbers()
        {

            var nums = new int[] { 1, 3, 5 };
            double expected = 3;

            var actual = Summator.Average(nums);


            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_Average_TwoNumbers()
        {

            var nums = new int[] { 1, 2 };
            double expected = 1.5;

            var actual = Summator.Average(nums);


            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_Multiply_TwoPositiveNumbers()
        {

            var nums = new double[] { 3, 2 };
            double expected = 6;

            var actual = Summator.Multiply(nums);


            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_Multiply_OneNegative_OnePositive_Numbers()
        {

            var nums = new double[] { 3, -5 };
            double expected = -15;

            var actual = Summator.Multiply(nums);


            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void Test_Multiply_TwoNegative_Numbers()
        {

            var nums = new double[] { -3, -5 };
            double expected = 15;

            var actual = Summator.Multiply(nums);


            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(new int[] { 1, 2 }, 3)]
        [TestCase(new int[] {1}, 1)]
        [TestCase(new int[] { -3, -8 }, -11)]
        [TestCase(new int[] { 5, 0 }, 5)]
        [TestCase(new int[] {}, 0)]
        [TestCase(new int[] { 1, -1 }, 0)]
        public void Test_Summator_SumDDT(int[] values, long expected)
        {
            var actual = Summator.Sum(values);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(new double[] {3, 2 }, 6)]
        [TestCase(new double[] {3, -5 }, -15)]
        [TestCase(new double[] {-3, -5 }, 15)]
        public void Test_Multiply_SumDDT(double[] values, long expected)
        {
            var actual = Summator.Multiply(values);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
 
    

