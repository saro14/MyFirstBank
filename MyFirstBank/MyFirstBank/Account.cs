using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstBank
{
    /// <summary>
    /// This class defines the account for a bank
    /// This is the blueprint
    /// 
    /// </summary>
    class Account
    {
        #region Statics
        //This is just to maintain last account number
        //If there is a static keyword, it is general-shared, not for every instance - not part of every account, class level variable
        private static int lastAccountNumber = 0;
        #endregion
        #region Properties
        public int AccountNumber { get; private set; }
        public string EmailAddress { get; set; }
        //This private set is to just read the balance, not write to it.
        public decimal Balance { get; private set; }
        #endregion
        #region Methods
        //constructor - without this we can't call new
        //this("", 0.0M) - empty..there are no parameters in this constructor when compared to the third one
        public Account() : this("", 0.0M)
        {
            //this means go to the instance of the memory that you created
            //this.AccountNumber = lastAccountNumber +=1;
            //this.AccountNumber = ++lastAccountNumber;
        }
        //Method overloading
        //this(emailAddress, 0.0M) - here the email address is given as the parameter, but no balance so that is empty parameter
        public Account(string emailAddress): this(emailAddress, 0.0M)
        {
            //this.AccountNumber = ++lastAccountNumber;
            //this.EmailAddress = emailAddress;
        }
        public Account(string emailAddress, decimal balance)
        {
            this.AccountNumber = ++lastAccountNumber;
            this.EmailAddress = emailAddress;
            this.Balance = balance;
        }
        //If you don't specify the access modifier, it will by default be private
        public decimal Deposit(decimal amount)
        {
            //Balance = Balance+amount;
            Balance += amount;
            return Balance;
        }
        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }
        #endregion
    }
}
