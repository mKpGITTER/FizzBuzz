namespace FizzBuzz
{
    public class FizzBuzzClass
    {
        public string CheckFizzOrBuzz(int i)
        {
            return (i % 3 == 0 && i % 5 == 0) ? "FizzBuzz" : 
                (i % 3 == 0 ? "Fizz" : 
                (i % 5 == 0 ? "Buzz" : i.ToString()));
        }

    }
}
