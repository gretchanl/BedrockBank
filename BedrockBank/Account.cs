using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBank
{
    public enum AccountType
    {
        Savings,
        Checking,
        CD,
        Loans
    }
    /// <summary>
    /// this is how you do an xml comment
    /// this is a bank summary
    /// </summary>

    public class Account
   
    {
        #region Variables
        private static int lastAccountNumber = 0; //if key word static it is a shared memory for all instance to use
        
        #endregion

        #region properties
        /// <summary>
        /// comment for AccountNumber
        /// </summary>
        public int AccountNumber { get; private set; } //
        /// <summary>
        /// comment for AccountName
        /// </summary>
        public string AccountName { get; set; }
        public int SSN { get; set; }
        public double Balance { get; private set; } //take out set and change to private set - users cannot set from outside
        public AccountType TypeofAccount { get; set; }  //** ties to the Enum
        #endregion

        #region Constructor // constructors must be public and have no return type
        public Account() // must be named the same as the class with no parameters
            // this will get called everytime a new account is called
            // need to tell this method what to do
            //take last account value and 
        {

            AccountNumber = ++lastAccountNumber; // preincrement updates the lastAccountNumber and gives that number to AccountNumber
            // then need to give the AccountNumber a private set
        }
        #endregion

        #region Methods

        //public double (the output)  Deposit method( parameter, parameter  );
        public double Deposit(double amount)  // you must write a return statement (return balance)
        {
            Balance += amount;  // same as balance = balance + amount
            return Balance;
        }
    
        #endregion

    }
}
