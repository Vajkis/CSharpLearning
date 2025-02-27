namespace CSharpLearning
{
  public class Program
  {
    public static void Main()
    {
      Console.Clear();

      int num = 3;
      string text2 = "Number is " + num;

      bool isOpen = false;
      string text4 = "Doors is " + isOpen;

      int price = 5;
      string text6 = $"Apple cost {price}€";


      Console.WriteLine("Press button");
      ConsoleKeyInfo info = Console.ReadKey();
      Console.WriteLine();
      Console.WriteLine(info.Key);
    }
  }
}