namespace BankTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccounts accounts = new BankAccounts(123, "jasd", 123);
            BankAccounts account1 = new BankAccounts(123, "jasd", 123);
            Console.WriteLine("istediyiniz emeliyyati secin");
            Console.WriteLine("\n 1.DisplayAccountInfo \n 2. Deposit \n 3 WithDraw  \n 4 esas menyuya qayit \n 6 TransferFunds \n 0 Quit Application");
            int Menu = int.Parse(Console.ReadLine());

            switch (Menu)
            {
                case 1:
                    account1.DisplayAccountInfo();
                    break;
                case 2:
                    Console.WriteLine("ne qeder pul elave etmek isteyirsen?");
                    decimal deposit = int.Parse(Console.ReadLine());
                    account1.Deposit(deposit);
                    break;
                case 3:
                    Console.WriteLine("ne qeder pul elave etmek isteyirsen?");
                    decimal withdraw = int.Parse(Console.ReadLine());
                    account1.WithDraw(withdraw);
                    break;
                case 4:
                    Console.WriteLine("esas menyuya qayit");
                    break;
                case 0:
                    Console.WriteLine("sonlandir");
                    return;


            }
        }
    }
}
