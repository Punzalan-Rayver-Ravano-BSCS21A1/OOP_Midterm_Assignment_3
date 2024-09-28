using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(int accountNumber, int balance, double interest)
            : base(accountNumber, balance, 0.075)
        {

        }
    }
}
