using System.Diagnostics;

namespace BankSystemTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            int id;
            string customerName;
            decimal balance;
            decimal money;

            string shortcuts;
            bool cantinue = true;
            Console.WriteLine("Banking sistemimize xos geldiniz.");
            Console.WriteLine("INFO: Asagida ede bileceyiniz emeliyyatlar ucun qisa yollar qeyd olunub.");


            do
            {
                Console.WriteLine("User daxil etmek ucun : 1");
                Console.WriteLine("Balansi gormek ucun: 2");
                Console.WriteLine("Balansin artirilmasi ucun: 3");
                Console.WriteLine("Balansin azaldilmasi ucun: 4");
                Console.WriteLine("Proqrami dayandirmaq ucun: 0");
                Console.WriteLine("INFO: Seciminizi daxil edin(Eger user daxil edilmeyibse ilk basda 1 secerek user add etmeyiniz sertdir.)");
                shortcuts = Console.ReadLine();
                
                switch(shortcuts)
                {
                    
                    case "1":

                        Console.Write("Customer name daxil edin: ");
                        customerName = Console.ReadLine().Trim();

                        bool TrueValue =true;
                        do
                        {
                            Console.Write("User id daxil edin: ");
                            TrueValue = int.TryParse(Console.ReadLine().Trim(), out id);
                            if (!TrueValue)
                            {
                                Console.WriteLine("Id reqemlerden ibaret olmalidir. Reqemden basqa sinvol istifade etmeyin.");
                            }
                        }
                        while (!TrueValue);

                        do
                        {
                            Console.Write("Balance daxil edin: ");
                            TrueValue = decimal.TryParse(Console.ReadLine().Trim(), out balance);
                            if (!TrueValue)
                            {
                                Console.WriteLine("Balance daxil ederken yazi xetasi oldu,Reqemden basqa sinvol istifade etmeyin.");
                            }
                        } 
                        while (!TrueValue);

                        User user = new User(id,customerName,balance);
                        bank.addUser(user);
                        Console.Clear();
                        Console.WriteLine("Istifadeci elave edildi, davam edin.");

                    break;


                    case "2":
                        do
                        {
                            Console.Write("Id daxil edin: ");
                            TrueValue = int.TryParse(Console.ReadLine().Trim(), out id);
                            if (!TrueValue)
                            {
                                Console.WriteLine("Id reqemlerden ibaret olmalidir. Reqemden basqa sinvol istifade etmeyin.");
                                
                            }
                            

                        }
                        while (!TrueValue);

                        bank.GetBalance(id);
                        Console.WriteLine("Novbeti emeliyyat ucun info: ");

                        break;
                    case "3":
                        do
                        {
                            Console.Write("User id daxil edin: ");
                            TrueValue = int.TryParse(Console.ReadLine().Trim(), out id);
                            if (!TrueValue)
                            {
                                Console.WriteLine("Id reqemlerden ibaret olmalidir. Reqemden basqa sinvol istifade etmeyin.");
                            }
                        }
                        while (!TrueValue);
                        do
                        {
                            Console.Write("Daxil etmek istediyiniz meblegi daxil edin:");
                            TrueValue = decimal.TryParse(Console.ReadLine().Trim(), out money);
                            if (!TrueValue)
                            {
                                Console.WriteLine("Mebleg reqemlerden ibaret olmalidir. Reqemden basqa sinvol istifade etmeyin.");
                            }

                            bank.Deposit(id, money);
                            Console.WriteLine("Novbeti emeliyyat ucun info: ");

                        } while (!TrueValue);
                        break;
                        case "4":
                        do
                        {
                            Console.Write("Id daxil edin: ");
                            TrueValue = int.TryParse(Console.ReadLine().Trim(),out id);
                            if (!TrueValue)
                            {
                                Console.WriteLine("Id reqemlerden ibaret olmalidir. Reqemden basqa sinvol istifade etmeyin.");
                            }

                        } while (!TrueValue);

                        do
                        {
                            Console.Write("Balansdan cixarmaq istediyiniz meblegi qeyd edin: ");
                            TrueValue = decimal.TryParse(Console.ReadLine(), out money);
                            if (!TrueValue)
                            {
                                Console.WriteLine("Mebleg reqemlerden ibaret olmalidir. Reqemden basqa sinvol istifade etmeyin.");
                            }
                        } while (!TrueValue);
                        bank.Withdraw(id,money);
                        Console.WriteLine("Novbeti emeliyyat ucun info: ");

                        break;

                        case "0":
                        
                        cantinue = false;
                        Console.WriteLine("Proqram Dayandirildi.");

                        break;

                        default:
                        Console.WriteLine("Yalnis shortcut secdiniz. Yalniz asagidaki shortcuts istifade edile biler.");
                        
                        break;
                }


            }

            while (cantinue);
            

        }
    }
}
