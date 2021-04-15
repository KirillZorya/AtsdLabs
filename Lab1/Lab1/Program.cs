using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> numbers = new LinkedList<int>();
            Console.WriteLine(numbers.Empty());
            numbers.Add(5);
            numbers.Add(2);
            numbers.Add(1);
            numbers.Add(8);
            numbers.Add(-2);
            numbers.Delete(numbers.Find(5));
            Console.WriteLine($"List length: {numbers.Length()}");
            numbers.Print(numbers);
            numbers.Clear();
            numbers.Print(numbers);
        }
    }
}
