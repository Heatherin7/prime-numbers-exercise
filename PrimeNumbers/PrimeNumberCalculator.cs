namespace PrimeNumbers
{
  public class PrimeNumberCalculator
  {
    /// <summary>
    /// Returns true if the value argument is a prime number, otherwise returns false.
    /// </summary>
    public bool IsPrime(int value)
    {
      if (value < 0)
      {
        value = value * -1;
      }

      if (value == 0 || value == 1)
      {
        return false;
      }

      for (int i = 2; i <= value / 2; i++)
      {
        if (value % i == 0)
        {
          return false;
        }
      }

      return true;
    }
  }
}