using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codurance
{
    public class AccountService
    {
        private readonly IDepositRepository _depositRepository;
        public AccountService(IDepositRepository depositRepository)
        {
            _depositRepository = depositRepository;
        }

        public void Deposit(int amount)
        {
            _depositRepository.Deposit(amount);
        }

        public void WithDraw(int amount)
        {

        }

        public void PrintStatement()
        {

        }
    }
}
