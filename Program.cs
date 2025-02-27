namespace CSharpLearning
{
  public class Program
  {
    public static void Main()
    {
      Console.Clear();

      string numberString = "0";
      decimal.TryParse(numberString, out decimal decimalNumber);

      Console.WriteLine(decimalNumber);
    }
  }
}