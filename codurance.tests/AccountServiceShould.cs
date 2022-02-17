using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace codurance.tests
{
    public class AccountServiceShould
    {
        private readonly AccountService _accountService;
        private readonly Mock<IDepositRepository> _depositRepositoryMock = new();

        public AccountService()
        {
            _accountService = new(_depositRepositoryMock.Object);
        }

        [Fact]
        public void Add_money_to_deposit_when_deposit_call()
        {
            _accountService.Deposit(10);

            //Assert that deposit is total deposit amount + 10
        }
    }
}
