namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount userBankAccount = new BankAccount();


            Console.WriteLine("How much money would you like to deposit?");

            double amountToDeposit = double.Parse(Console.ReadLine());

            userBankAccount.Deposit(amountToDeposit);
            double userBalance = userBankAccount.GetBalance();

            Console.WriteLine($"You're new balance is {userBalance,0:c}.");



        }
    }
}
