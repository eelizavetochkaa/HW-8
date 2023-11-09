using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_8
{

    public class BankAccount
    {
        private static int account_number;
        private int balance;
        private bank type;
        private System.Collections.Queue transactions;
        public void setAccountNumber()
        {
            account_number++;
        }
        public int getAccountNumber()
        {
            return account_number;
        }
        public int getBalance()
        {
            return balance;
        }

        public bank getType()
        {
            return type;
        }

        public void increaseMoney(int money)
        {
            BankTransaction transaction = new BankTransaction(money);
            transactions.Enqueue(transaction);
            this.balance = this.balance + money;
        }

        public void decreaseMoney(int money)
        {
            BankTransaction transaction = new BankTransaction(money);
            transactions.Enqueue(transaction);
            this.balance = this.balance + money;
        }
        public BankAccount(int balance)
        {
            BankTransaction transaction = new BankTransaction(this.balance - balance);
            transactions.Enqueue(transaction);
            this.balance = balance;
            setAccountNumber();
        }
        
        public BankAccount(bank type)
        {
            this.type = type;
            setAccountNumber();
        }
        public BankAccount(int balance,bank type)
        {
            BankTransaction transaction = new BankTransaction(this.balance - balance);
            transactions.Enqueue(transaction);
            this.balance = balance;
            this.type = type;
        }
        public void Dispose()
        {
            // Write transactions to a file
            using (StreamWriter writer = new StreamWriter("transactions.txt"))
            {
                foreach (var transaction in transactions)
                {
                    writer.WriteLine(transaction);
                }
            }

            // Suppress finalization
            GC.SuppressFinalize(this);
        }
    }
}
