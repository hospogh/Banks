using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banks
{
    class Account
    {
        //Constructors
        public Account(Person person, DateTime creationDate, string currency, decimal balance = 0)
        {
            Person = person;
            this.accountNumber = accountsCounter;
            CreationDate = creationDate;
            Currency = currency;
            Balance = balance;
            Transactions = new List<Transaction>();
            accountsCounter++;
        }

        //Variables
        private static int accountsCounter;
        private decimal balance;
        private int accountNumber;

        //Properties
        public Person Person { get; set; }
        public int AccountNumber { get { return accountNumber; } }
        public DateTime CreationDate { get; set; }
        public String Currency { get; set; }
        public List<Transaction> Transactions { get; set; }
        public decimal Balance
        {
            get { return balance; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Balance can't be negative");
                }
                else
                {
                    balance = value;
                }
            }
        }

        //Methods
        public void DepositMoney(decimal money, DateTime date)
        {
            Balance += money;
            Transactions.Add(new Transaction(money, date));
        }
        public void WithdrawMoney(decimal money, DateTime date)
        {
            Balance -= money;
            Transactions.Add(new Transaction(-money, date));
        }
        public void PrintAccountStatement()
        {
            Console.WriteLine(Person + "\n");
            foreach (Transaction t in Transactions)
            {
                Console.WriteLine(t);
            }
            Console.WriteLine("____________________________________________________");
            Console.WriteLine("Current Balance {0} {1}", Balance, Currency);
        }

        //Operators
        public static Account operator +(Account account, decimal money)
        {
            account.DepositMoney(money, DateTime.Now);
            return account;
        }
        public static Account operator -(Account account, decimal money)
        {
            account.WithdrawMoney(money, DateTime.Now);
            return account;
        }
        public static bool operator >(Account firstAccount, Account secondAccount)
        {
            return firstAccount.Balance > secondAccount.Balance;
        }
        public static bool operator <(Account firstAccount, Account secondAccount)
        {
            return firstAccount.Balance < secondAccount.Balance;
        }
    }
}
