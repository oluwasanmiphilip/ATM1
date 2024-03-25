// See https://aka.ms/new-console-template for more information


namespace BankApp
{
    class Program
    {
        public static void Main()
        {
            WelcomePage.Welcm();
            Obtions.Obtns();
        }

    }
    class WelcomePage
    {
        public static void Welcm()
        {
            Console.WriteLine("Welcome To GT Bank");

            Console.WriteLine("Enter your Acct Name");

            string? AcctName = Console.ReadLine();

            Console.WriteLine($"Acct Name: {AcctName}");

            

        }
        
    }
    class Obtions
    {
        
        public static void Obtns()
        {
            
            Console.WriteLine("Enter (1)Save (2)Withdraw (3)Balance");
            int? obtions = Convert.ToInt32(Console.ReadLine());
           
            
            switch(obtions)
            {

                case 1 : 
                Console.WriteLine("Enter Amount");
                int? save = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Available: {save}");
                Console.WriteLine("Thank You for Banking with Us");
                
                break;

                case 2 : 
                Console.WriteLine("Enter Amount To Withdraw");
                int? saves = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Withdraw : -{saves}");
                Console.WriteLine("Thank You for Banking with Us");
                
                break;

                case 3 : 
                Console.WriteLine("Enter Amount");
                int? amt = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Network Unavailable");
                
                break;

            }
        }

    }
}
