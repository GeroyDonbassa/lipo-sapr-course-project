using System;

namespace DoubleReader
{
    /// <summary>
    /// Класс входа в программу.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Метод входа в программу.
        /// </summary>
        /// <param name="args">Аргументы.</param>
        private static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите число: ");
                var stringValue = Console.ReadLine();
                var doubleValue = DoubleReader.GetDouble(stringValue);
                Console.WriteLine($"Введено число {doubleValue}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}