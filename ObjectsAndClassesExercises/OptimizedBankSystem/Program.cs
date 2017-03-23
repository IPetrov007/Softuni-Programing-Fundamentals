using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BankAccount
{

    public string Bank { get; set; }
    public string AccountName { get; set; }
    public decimal Balance { get; set; }
}

namespace _02_OptimizedBankingSystems
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new List<BankAccount>();

            string inputLine = Console.ReadLine();
            while (!inputLine.Equals("end"))
            {
                var input = inputLine.Split(new[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries);
                var currentBankAccount = new BankAccount();
                currentBankAccount.Bank = input[0];
                currentBankAccount.AccountName = input[1];
                currentBankAccount.Balance = decimal.Parse(input[2]);

                bool allreadyExist = result.Any(x => x.Bank == currentBankAccount.Bank && x.AccountName == currentBankAccount.AccountName);
                if (allreadyExist)
                {
                    result.SingleOrDefault(x => x.Bank == currentBankAccount.Bank && x.AccountName == currentBankAccount.AccountName).Balance += currentBankAccount.Balance;
                }
                else
                {
                    result.Add(currentBankAccount);
                }

                inputLine = Console.ReadLine();
            }
            foreach (var bank in result.OrderByDescending(x => x.Balance).ThenBy(x => x.Bank.Length))
            {
                Console.WriteLine($"{bank.AccountName} -> {bank.Balance} ({bank.Bank})");
            }
        }
    }
}
