using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Threading.Tasks;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        // Sample input data (list of numbers)df
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        // Map step: Square each number
        //var mappedResults = numbers.Select(num => num * num);
        var mappedResults = Square(numbers);
        // Reduce step: Sum the squared values
        int sumOfSquares = mappedResults.Sum();

        // Display the final result
        Console.WriteLine($"Sum of squares: {sumOfSquares}");
        Console.ReadLine();
        /*
        In this example:

        Map Step: Each number in the numbers list is squared.
        Reduce Step: The squared values are summed up.

        This simplified example demonstrates the basic concept of MapReduce where the "mapping" operation 
        transforms each input element, and the "reducing" operation aggregates the results. 
        Keep in mind that in a distributed environment, these operations would be performed in parallel 
        across multiple nodes to handle large datasets.
        */

    }

    private static List<int> Square(List<int> numbers)
    {
        List<int> result = new List<int>();
        for (int i = 0; i < numbers.Count; i++)
        {
            result.Add(numbers[i] * numbers[i]);
        }
        return result;
    }
}
