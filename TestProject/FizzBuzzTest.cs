using FizzBuzz;

namespace TestProject
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void TestOneToHundred()
        {
            //Arrange
            var fizzBuzz = new FizzBuzzClass();

            //Act
            for (int i = 1; i <= 100; i++)
            {
                var result = fizzBuzz.CheckFizzOrBuzz(i);

                if (i % 3 == 0 && i % 5 == 0)
                {
                    Assert.AreEqual(result, "FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Assert.AreEqual(result, "Fizz");
                }
                else if (i % 5 == 0)
                {
                    Assert.AreEqual(result, "Buzz");
                }
                else
                {
                    Assert.AreEqual(result, i.ToString());
                }

            }
        }
    }
}