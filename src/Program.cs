using System.Diagnostics;
using System.Text;
using TextCopy;

namespace UltimatePassGen
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.Title = "Ultimate PassGen";

            Console.WriteLine("Welcome to Ultimate PassGen!\n");

            string? input;
            int length;

            do
            {
                do
                {
                    Console.Write("Type the length of your password: ");
                    input = Console.ReadLine();
                }
                while (!Int32.TryParse(input, out length));
            }
            while (!(length > 0));

            Console.WriteLine("Generating...");

            long startTime = Stopwatch.GetTimestamp();
            string password = Password.Generate(length);
            TimeSpan elapsedTime = Stopwatch.GetElapsedTime(startTime);

            File.WriteAllText("password.txt", password);
            Console.WriteLine("Password generated!\n");
            Console.WriteLine(password);
            Console.WriteLine("\nPassword generated in {0}", elapsedTime);
            
            Console.WriteLine("Press C to copy the generated password to the clipboard " +
                              "or any other key to close the program.");
            
            if (Console.ReadKey(true).Key == ConsoleKey.C)
            {
                ClipboardService.SetText(password);
                Console.WriteLine("Copied to clipboard!");
            }
        }
    }
}
