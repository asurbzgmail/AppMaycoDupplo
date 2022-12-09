using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMaycoDupplo.Controller
{
    public static class PrintNumber
    {
        /// <summary>
        /// Return specific text
        /// </summary>
        /// <returns></returns>
        public static List<string> Texts() => new() { "first", "last" };

        /// <summary>
        /// Returns the first and last number (of the document)
        /// </summary>
        /// <returns></returns>
        public static List<int> StaticNumbers() => new() { 1, 150 };

        /// <summary>
        /// Validate if the first number is equal to or less than the last to continue
        /// </summary>
        /// <param name="firstNumber">The first number given by the user.</param>
        /// <param name="lastNumber">The last number given by the user.</param>
        /// <param name="msg">If there is an error a message is returned</param>
        /// <returns></returns>
        public static bool ValidateFirstvsLast(int firstNumber, int lastNumber, out string msg)
        {
            try
            {
                bool result = firstNumber <= lastNumber;

                if (result)
                    msg = "";
                else
                    msg = "Error: The first number is greater than the last";

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Validate if number is empty, null or not an integer
        /// </summary>
        /// <param name="value">The number given by the user</param>
        /// <param name="msg">If there is an error a message is returned</param>
        /// <returns></returns>
        public static bool ValidateNumber(string? value, out string msg)
        {
			try
			{
                bool result = !string.IsNullOrEmpty(value) && int.TryParse(value, out _);

                if (result)
                    msg = "";
                else
                    msg = "Error: The {0} number is empty, null or not an integer";

                return result;
            }
			catch (Exception)
			{
                throw;
            }
        }

        /// <summary>
        /// Function to return the number or text
        /// </summary>
        /// <param name="value">The number to validate</param>
        /// <returns></returns>
        public static string PrintingNumber(int value)
        {
            try
            {
                //REGLAS:

                //Cualquier número      regresa el número:
                //Multiplos del 3       regresa Mayco
                //Multiplos del 5       regresa Dupplo
                //Multiplos del 3 y 5   regresa MaycoDupplo

                if (value % 3 == 0 && value % 5 == 0)
                    return "MaycoDupplo";
                else if (value % 3 == 0)
                    return "Mayco";
                else if (value % 5 == 0)
                    return "Dupplo";
                else
                    return value.ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
