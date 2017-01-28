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
            //create an account object/instance
            //new keyword - calling the constructor
            var myAccount = new Account();
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
            Console.WriteLine($"The balance in my account - {myAccount2.AccountNumber} is {myAccount2.Balance:C}");

        }
    }
}
