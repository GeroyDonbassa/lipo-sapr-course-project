using System;
using System.Globalization;

namespace DoubleReader
{
    /// <summary>
    /// Считыватель чисел типа <see cref="double"/>.
    /// </summary>
    public static class DoubleReader
    {
        /// <summary>
        /// Получает значение типа <see cref="double"/> из строки.
        /// </summary>
        /// <param name="stringValue">Строковое значение.</param>
        /// <returns>Значение типа <see cref="double"/>.</returns>
        public static double GetDouble(string stringValue)
        {
            var isDouble = double.TryParse(stringValue, out var doubleValue);

            return isDouble ? doubleValue : throw new ArgumentException("Строка не соответствует формату double");
        }
    }
}