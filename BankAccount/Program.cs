namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool myBool = true;
            int initialSaldo = 0;

            while (true)
            {

                try
                {
                    Console.WriteLine("Hej, du kommer nu få fyra val du kan göra:");
                    Console.Clear();
                    Console.ReadKey();

                    Console.WriteLine("1: Sätta in pengar på ditt saldo.\n2: Ta ut pengar från ditt saldo. " +
                     "\n3: Kontrollera saldo.\n4: Avsluta");
                    Console.WriteLine("Var god välj en siffra '1-4'");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    switch (choice)
                    {
                        case 1:

                            Console.WriteLine("Du har valt att sätta in pengar på ditt konto!");
                            Console.Write("Hur mycket vill du sätta in?: ");
                            int addedSaldo = Convert.ToInt32(Console.ReadLine());
                            initialSaldo += addedSaldo;
                            Console.WriteLine("Du har valt att sätta in {0}kr på ditt konto", addedSaldo);
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.WriteLine("Du har valt att ta ut pengar på från konto!");
                            Console.Write("Hur mycket vill du ta ut?: ");
                            int withdrawnSaldo = Convert.ToInt32(Console.ReadLine());
                            Console.ReadKey();

                            if (withdrawnSaldo >= initialSaldo)
                            {
                                Console.WriteLine("Sorry, du kan inte ta ut mer än vad du har på kontot");
                                Console.ReadKey();
                            }
                            else if (withdrawnSaldo <= initialSaldo)
                            {
                                initialSaldo -= withdrawnSaldo;
                                Console.WriteLine($"Du har valt att ta ut {withdrawnSaldo}kr, ditt saldo är just nu {initialSaldo}");
                                Console.ReadKey();
                            }
                            //newSaldo = withdrawnSaldo - saldo;
                            break;
                        case 3:
                            Console.WriteLine("Ditt nuvarande saldo är {0}", initialSaldo);
                            Console.ReadKey();
                            break;
                        case 4:
                            Console.WriteLine("Du har valt att lämna kontohanteringen, ha en bra dag!");
                            Console.ReadKey();
                            Environment.Exit(0);

                            break;
                        default:
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Var god välj en siffra.");
                    Console.ReadKey();
                }
            }
        }


    }
}