using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_8
{
    public enum bank: int
    {
        tecuchy = 135000,
        sbereg = 120000
    }
    internal class BankTransaction
    {
        DateTime date;
        int money;
        bool flag;

        public BankTransaction(int money)
        {
            this.money = money;
            date = DateTime.Now;
        }
    }
}
