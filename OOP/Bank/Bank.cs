namespace Bank;

public class Bank
{
    private int id;
    private double balance;

    public int Id { get { return id; } }
    public double Balance { get { return balance; } }

    public Bank(int id, double balance)
    {
        this.id = id;
        this.balance = balance;
    }
    public void Deposit(double amount)
    {
        balance += amount;
    }
    public void Withdraw(double amount)
    {
        balance -= amount;
    }
    public override string ToString()
    {
        return $"Id {id} balance {balance:F2}";
    }
}
