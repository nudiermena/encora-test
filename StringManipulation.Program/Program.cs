using StringManipulation.Program.Models;
using System.Collections;

namespace StringManipulation.Encora;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Test Case Input");
        int N = Convert.ToInt32(Console.ReadLine());
        List<string> inputStrings = new();

        for (int i = 0; i < N; i++)
        {
            inputStrings.Add(Console.ReadLine());
        }

        // Perform sorting operation
        List<string> output = StringSorting.SortingOperations(inputStrings);

        Console.WriteLine(Environment.NewLine);


        Console.WriteLine("Expected Output");

        // Print the output string
        foreach (var str in output)
        {
            Console.WriteLine(str);
        }
        Console.ReadLine();
    }
}

