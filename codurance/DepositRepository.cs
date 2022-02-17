using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codurance
{
    internal class DepositRepository : IDepositRepository
    {
        private int _balance = 0;

        public void Deposit(int amount)
        {
            _balance += amount;
        }

        public int GetBalance()
        {
            throw new NotImplementedException();
        }

        public void WithDraw(int amount)
        {
            throw new NotImplementedException();
        }
    }
}
