using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class MinimumBalanceException : ApplicationException
    {
        public MinimumBalanceException() : base("value less than zero")

        {

        }
    }
    interface IInterestCalculator
    {
        void AddInterest();
    }
    public abstract class BankAccount
    {
        int accountNumber;
        string accountHolderName;
        protected double balanceAmount;
        public int AccountNumber
        {
            get { return accountNumber; }
        }
        public string AccountHolderName
        {
            get { return accountHolderName; }
            set { accountHolderName = value; }
        }
        public double BalanceAmount { get { return balanceAmount; } }
        public BankAccount(int accountNumber, string accountHolderName, double balance)
        {
            this.accountNumber = accountNumber;
            this.accountHolderName = accountHolderName;
            this.balanceAmount = balance;
        }
        public virtual void Deposit(double depositamount)
        {
            balanceAmount += depositamount;
        }
        public abstract void withdraw(double withdrawAmount);
    }
    class SavingsAccount : BankAccount, IInterestCalculator
    {

        double minBalance = 500;
        double interestRate = 10;
        public SavingsAccount(int accountNumber, string accountHolderName, double balance) : base(accountNumber, accountHolderName, balance)
        {

        }
        public void ChangeMinBalance(double newMinBalance)
        {
            double minBalance = newMinBalance;
        }
        public void AddInterest()
        {
            balanceAmount = balanceAmount * interestRate / 100;
        }
        public override void withdraw(double withdrawAmount)
        {
            if ((BalanceAmount - withdrawAmount) > minBalance)
            {
                balanceAmount = balanceAmount - withdrawAmount;
            }

            else
            {
                try
                {
                    throw new MinimumBalanceException();
                }
                catch (MinimumBalanceException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
    public class ODAccount : BankAccount, IInterestCalculator
    {
        private static int interestRate = 30;
        private static int Limit = 10000;
        public ODAccount(int accountNumber, string accountHolderName, double balance) : base(accountNumber, accountHolderName, balance)
        {

        }
        public void AddInterest()
        {
            balanceAmount += balanceAmount * (interestRate / 100);
        }
        public override void Deposit(double depositAmount)
        {
            balanceAmount += depositAmount;
        }
        public override void withdraw(double withdrawAmount)
        {
            try
            {
                double amount = balanceAmount - withdrawAmount;
                if (amount > -Limit)
                {
                    balanceAmount = amount;
                }
                else
                {
                    throw new MinimumBalanceException();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
    class Branch1
    {
        public static void Main()
        {
            SavingsAccount bankAccount = new SavingsAccount(1000, "customer1", 5000);
            Console.WriteLine($"{bankAccount.AccountNumber} {bankAccount.AccountHolderName} {bankAccount.BalanceAmount}");
            bankAccount.Deposit(10000);
            Console.WriteLine($"{bankAccount.BalanceAmount}");
            bankAccount.withdraw(5000);
            Console.WriteLine($"{bankAccount.BalanceAmount}");

            ODAccount bankAccount1 = new ODAccount(2120, "customer2", 10000);
            Console.WriteLine($"{bankAccount1.AccountNumber} {bankAccount1.AccountHolderName} {bankAccount1.BalanceAmount}");
            bankAccount1.Deposit(10000);
            Console.WriteLine($"{bankAccount1.BalanceAmount}");
            bankAccount1.withdraw(5000);
            Console.WriteLine($"{bankAccount1.BalanceAmount}");
        }
    }
}
