using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork__12
{
    class BalanceAccount : Factory
    {
        decimal balance;
        public BalanceAccount(decimal balance) : base()
        {
            this.balance = balance;
        }
        public override BankAccount CreateAccount()
        {
            BankAccount acc = new BankAccount(balance);
            table.Add(acc.GetID(), acc);
            return acc;
        }
    }
}
