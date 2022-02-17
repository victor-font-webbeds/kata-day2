using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace codurance.tests.AcceptanceTests
{
    public class PrintStatementFeature
    {
        private readonly Mock<IConsole> _consoleMock = new();

        [Fact]
        public void Print_statement_after_deposits_and_withdraws_in_reverse_order()
        {
            //Given
            AccountService accountService = new AccountService();
            accountService.Deposit(50);
            accountService.WithDraw(20);
            accountService.WithDraw(10);
            accountService.Deposit(30);

            _consoleMock.Setup(x => x.Print("50"));

            //When
            accountService.PrintStatement();


            _consoleMock.Verify(c => c.Print("50"), Times.Once);
        }
    }
}
