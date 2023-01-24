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
        public void Test_Multiply_TwoNumbers()
        {

            var nums = new double[] { 3, 2 };
            double expected = 6;

            var actual = Summator.Multiply(nums);


            Assert.That(actual, Is.EqualTo(expected));
        }
    }



}
 
    

