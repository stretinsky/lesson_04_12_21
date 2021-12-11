using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork__12
{
    class BankTransaction
    {
        public decimal amount { get; private set; }
        public DateTime time { get; private set; }
        public BankTransaction(decimal amount)
        {
            this.amount = amount;
            time = DateTime.Now;
        }
        public string GetInfo()
        {
            return $"{time} {amount}\n";
        }
    }
}
