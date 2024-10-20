using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemTask
{
    internal class Bank
    {

        //        Bank --
        //        User user[]
        //        addUser(User user);
        //        Deposit(int Id, decimal money);
        //        Withdraw(int id, decimal money)
        //        GetBalance(int id);



        public User[] users = new User[0];
        public void addUser(User user)
        {
            Array.Resize(ref users, users.Length + 1);
            users[users.Length - 1] = user;
            for (int i = 0; i < users.Length; i++)
            {
                if (user ==user)
                {
                    Console.WriteLine("Daxil etdiyiniz adda istifadeci artiq movcuddur. Basqa ad yazin.");
                }
            }
        }
        public User UserSearchByID(int id)
        {
            foreach (var user in users)
            {
                if (id == user.Id)
                {
                    return user;
                }               
               
            }
            return null;
        }

        public void GetBalance(int id)
        {
            User user = UserSearchByID(id);
            if (user != null)
            {
                 Console.WriteLine($"{user.customerName} adli istifadecinin {user.balance} miqdarda balansi var.");
            }
            else
            {
                Console.WriteLine("Istifadeci tapilmadi");
                
            }
            
        }



        public void Deposit(int Id, decimal money)
        {
            User user = UserSearchByID(Id);
            if (user != null)
           {
               decimal newbalance = user.balance += money;
                Console.WriteLine($"{user.customerName} adli istifadecinin balansina {money} dollar daxil edldi.\nYeni balansiniz: {newbalance}\n  ");
           }
           else
            {
                Console.WriteLine($"{Id} id-li istifadeci taolimadi.");
            }


        }
        public void Withdraw(int id, decimal money)
        {
            User user = UserSearchByID(id);
            if (user.balance>=money)
            {
                decimal newbalancee =user.balance -= money;
                Console.WriteLine($"{user.customerName} adli userin balansindan {money} dollar money cixarildi.\nYeni balansiniz: {newbalancee}\n ");
            }
            else
            {
                Console.WriteLine("Yetersiz balance...");
            }

        }

        
        
    }
}
