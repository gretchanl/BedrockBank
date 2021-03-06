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
            Console.WriteLine("*****Welcome to the Bedrock Bank * *****");
            string option;
            do
            {
                
                Console.WriteLine("1. Create an account");
                Console.WriteLine("2. Deposit into an account");
                Console.WriteLine("3. Print accounts");
                Console.WriteLine("0. Exit");
                option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.Write("What is the name of the account");
                        var accountName = Console.ReadLine();
                        Console.Write("What is your email address? ");
                        var emailAddress = Console.ReadLine();
                        var customer = Bank.FindCustomer(emailAddress);                     
                        Bank.FindCustomer(emailAddress);

                        var account1 = Bank.CreateAccount(accountName, 12345,
                            AccountType.Checking, customer);
                        Console.WriteLine("Account Name: {0}, Account Number: {1}, Type of Account: {2}, Balance: {3:c}",
                    account1.AccountName, account1.AccountNumber, account1.TypeofAccount, account1.Balance);
                        break;
                    case "2":
                        break;

                    case "3":
                       // PrintAccounts();
                        break;
                    case "0":
                        Console.WriteLine("Goodbye");
                        return;

                    default:
                        break;
                }
                } while (option !="0") ;

            

            // creating an instance of Account this is where memory is allocated
            //var account1 = new Account(); // goes to your account.cs 
            //account1.AccountName = "my checking";
            //account1.TypeofAccount = AccountType.Checking;   //forces you to pick from the enum
            //account1.AccountNumber = 123233213;  // need to go back to the properties and remove the set so the customer cannot set
            // account1.Balance = 23123123;  //need to go back to properties and remove set - commented out because a user cannot update the balance.
            // can only update balance thru the deposit method in the Account.cs
            // but you can call the deposit method to update the balance: and when you type it should populate with the method box icon
            //whenever you reference a method you must have () and pass in the parameters.
            //account1.Deposit(300.00);  // this method accepts an amount but to save the new balance, create a variable:
            //var account1 = Bank.CreateAccount("My Checking", 12345, AccountType.Checking);
            //account1.Deposit(300.00);
            //Console.WriteLine("Account Name: {0}, Account Number: {1}, Type of Account: {2}, Balance: {3:c}",
            //    account1.AccountName, account1.AccountNumber, account1.TypeofAccount, account1.Balance);

            //create 2nd account
            //var account2 = new Account(); // goes to your account.cs 
            //account2.AccountName = "my Savings";
            //account2.TypeofAccount = AccountType.Savings;   //forces you to pick from the enum
            //account1.AccountNumber = 123233213;  // need to go back to the properties and remove the set so the customer cannot set
            // account1.Balance = 23123123;  //need to go back to properties and remove set - commented out because a user cannot update the balance.
            // can only update balance thru the deposit method in the Account.cs
            // but you can call the deposit method to update the balance: and when you type it should populate with the method box icon
            //whenever you reference a method you must have () and pass in the parameters.
            //account1.Deposit(300.00);  // this method accepts an amount but to save the new balance, create a variable:
           // var account2 = Bank.CreateAccount("My Savings", 987654, AccountType.Savings);
           // account2.Deposit(100.00);
           // Console.WriteLine("Account Name: {0}, Account Number: {1}, Type of Account: {2}, Balance: {3:c}",
            //    account2.AccountName, account2.AccountNumber, account2.TypeofAccount, account2.Balance);


        }

        //static void PrintAccounts()
        //{
        //    foreach (var account in Bank.accounts)
        //    {
        //        Console.WriteLine("Id: {0}, Name: {1}",
        //            account.AccountNumber, account.AccountName);
        //    }

        //    {

            }

        }
    //}
//}
