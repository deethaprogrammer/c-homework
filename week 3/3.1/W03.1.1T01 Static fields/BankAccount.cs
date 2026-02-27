public class BankAccount
{
    public static double InterestPercentage;
    public double Balance;

    public void Deposit(double deposit)
    {
        this.Balance += deposit;
    }

    public void ApplyInterest()
    {
        double interestrate = InterestPercentage * 0.01;
        this.Balance += this.Balance * interestrate;
    }
}