using System;
using DateTimeExtension;

namespace ApplicationConsoleDateTimeExtensions
{
  internal class Program
  {
    static void Main()
    {
      Action<string> Display = Console.WriteLine;
      Display("DateTime extensions usage sample");
      DateTime today = DateTime.Today;
      Display($"The first day of the month is {DateTimeExtensionClass.StartOfMonth(today)}");
      Display($"The last day of the month is {DateTimeExtensionClass.EndOfMonth(today)}");
      Display($"The start of the day is {DateTimeExtensionClass.StartOfDay(today)}");
      Display($"The end of the day is {DateTimeExtensionClass.EndOfDay(today)}");

      Display("Press any key to exit:");
      Console.ReadKey();
    }
  }
}
