using System;
namespace TSystem_EventExample_Bank
{
    
    public class Bank
    {
        public event DisplayMsg InsufficientBalance;
        public event DisplayMsg ZeroBalance;
        public event DisplayMsg LowBalance;

        int balance;
        int amount;
        public Bank()
        {
            balance = 10000;
        }
        public int Deposit(int amount)
        {
            this.amount = amount;

            balance = balance + amount;
            return balance;
        }
        public int Withdraw(int amount)
        {
            int abalance = balance - amount;

            if (abalance < 0)
            {
                InsufficientBalance();
                return balance;
            }
            else
            {
                balance = balance - amount;

                if(balance == 0)
                {
                    ZeroBalance();
                    return balance;
                }
                else if (balance < 3000)
                {
                    LowBalance();
                    return abalance;
                }
                else 
                {
                    return balance;
                }
            
            }
        }
    }
}
