namespace codurance
{
    public interface IDepositRepository
    {
        void Deposit(int amount);
        void WithDraw(int amount);
        int GetBalance();
    }
}