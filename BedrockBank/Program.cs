﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBank
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating an instance of Account this is where memory is allocated
            var account1 = new Account(); // goes to your account.cs 
            account1.AccountName = "my checking";
            account1.TypeofAccount = AccountType.Checking;   //forces you to pick from the enum
            //account1.AccountNumber = 123233213;  // need to go back to the properties and remove the set so the customer cannot set
           // account1.Balance = 23123123;  //need to go back to properties and remove set - commented out because a user cannot update the balance.
           // can only update balance thru the deposit method in the Account.cs
           // but you can call the deposit method to update the balance: and when you type it should populate with the method box icon
           //whenever you reference a method you must have () and pass in the parameters.
            //account1.Deposit(300.00);  // this method accepts an amount but to save the new balance, create a variable:
          
            account1.Deposit(300.00);
            Console.WriteLine("Account Name: {0}, Account Number: {1}, Type of Account: {2}, Balance: {3:c}",
                account1.AccountName, account1.AccountNumber, account1.TypeofAccount, account1.Balance);

            //create 2nd account
            var account2 = new Account(); // goes to your account.cs 
            account2.AccountName = "my Savings";
            account2.TypeofAccount = AccountType.Savings;   //forces you to pick from the enum
                                                             //account1.AccountNumber = 123233213;  // need to go back to the properties and remove the set so the customer cannot set
                                                             // account1.Balance = 23123123;  //need to go back to properties and remove set - commented out because a user cannot update the balance.
                                                             // can only update balance thru the deposit method in the Account.cs
                                                             // but you can call the deposit method to update the balance: and when you type it should populate with the method box icon
                                                             //whenever you reference a method you must have () and pass in the parameters.
                                                             //account1.Deposit(300.00);  // this method accepts an amount but to save the new balance, create a variable:

            account2.Deposit(100.00);
            Console.WriteLine("Account Name: {0}, Account Number: {1}, Type of Account: {2}, Balance: {3:c}",
                account2.AccountName, account2.AccountNumber, account2.TypeofAccount, account2.Balance);


        }
    }
}
