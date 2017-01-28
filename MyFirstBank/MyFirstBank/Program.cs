using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstBank
{
    class Program
    {
        // Main is the entry point for the program to start
        static void Main(string[] args)
        {
            Console.WriteLine("*****Welcome to my bank****");
            while(true)
            { 
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Create an account");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("Please selct one of the options from above:");
            var choice = Console.ReadLine();
                switch (choice)
                {
                    case "0":
                        return;
                    //break;
                    case "1":
                        Console.WriteLine("Please provide your email address");
                        var emailAddress = Console.ReadLine();
                        var myAccount = new Account(emailAddress);
                        Console.WriteLine($"The balance in my account - {myAccount.AccountNumber} is {myAccount.Balance:C}");
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    default:
                        Console.WriteLine("Sorry, option not available");
                        break;
                }
            }
            //create an account object/instance
            //new keyword - calling the constructor
            /*var myAccount = new Account();
            myAccount.EmailAddress = "test@test.com";
            //myAccount.AccountNumber = 12345;
            //Problem is allowing the user to set the balance
            //myAccount.Balance = 1000000;
            //M - stands for money
            //var - stands for variable
            myAccount.Deposit(200.50M);
            //$ - to create placeholders
            //C - result in currency format
            Console.WriteLine($"The balance in my account - {myAccount.AccountNumber} is {myAccount.Balance:C}");

            var myAccount2 = new Account("test2@test.com");
            //myAccount2.EmailAddress = "test2@test.com";
            myAccount2.Deposit(200.50M);
            Console.WriteLine($"The balance in my account - {myAccount2.AccountNumber} is {myAccount2.Balance:C}");*/

        }
    }
}
