using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBank
{
    public static class Bank
    {
        #region Variable
        private static bankmodels db = new bankmodels();
        //public static List<Account> accounts = new List<Account>();// when you execute, it will allocate memory 
        // list to create a collection needs to be private so only the bank can see it // list of what: strings, int
        // must be static 
        // left side is a declaration just like  int= 10
        //reference types (list, string - is special and doesn't need new), array..)  must always use new so it will allocate memory
        #endregion
 
        public static Customer FindCustomer(string emailAddress)
        {
            return db.Customers.Where(
            c => c.CustomerEmail == emailAddress).FirstOrDefault();
        }



        /// <summary>
        /// Create a new account
        /// </summary>
        /// <param name="accountName">Name for your account</param>
        /// <param name="ssn">Your social sec number </param>
        /// <param name="typeOfAccount">The type of account</param>
        /// <returns>A new account</returns>
        public static Account CreateAccount
            (string accountName, 
            int ssn, AccountType typeOfAccount,
            Customer customer)    // the parameters are from the properties from the class

        {
            var account = new Account
            { AccountName = 
                accountName,
                SSN = ssn,
                TypeofAccount = typeOfAccount,
                Customer =customer
            };

            db.Accounts.Add(account); // this method puts the account into the collection list
            db.SaveChanges();
            return account;

        } // end of the method

        

    }
}
