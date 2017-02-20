using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Notification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string resultForPrint = string.Empty;
            for (int i = 0; i < n; i++)
            {
                string result = Console.ReadLine();

                if (result=="success")
                {
                   string operation = Console.ReadLine();
                   string message = Console.ReadLine();
                   resultForPrint += ShowSuccess(operation, message) + Environment.NewLine;
                }
                else if (result == "error")
                {
                    string operation1 = Console.ReadLine();
                    int code = int.Parse(Console.ReadLine());

                    resultForPrint += ShowError(operation1, code) + Environment.NewLine;
                }
                
            }
            Console.WriteLine(resultForPrint);
        }
        static string ShowSuccess(string operation, string message)
        {
            var result = $"Successfully executed {operation}." + Environment.NewLine;
            result += "==============================" + Environment.NewLine;
            result += $"Message: {message}.";
            return result;
        }

        static string ShowError(string operation1, int code)
        {
            var result = $"Error: Failed to execute {operation1}." + Environment.NewLine;
            result += "==============================" + Environment.NewLine;
            result += $"Error Code: {code}." + Environment.NewLine;

            string reason = String.Empty;
            if (code >= 0)
            {
                reason = "Invalid Client Data";
            }
            else
            {
                reason = "Internal System Failure";
            }
            result += $"Reason: {reason}.";
            return result;
        }
    }
}
