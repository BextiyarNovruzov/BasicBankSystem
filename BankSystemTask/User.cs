using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemTask
{
    internal class User
    {
        private int id;
        public string customerName;
        public decimal balance;
        public User(int id, string customerName, decimal balance)
        {
            this.id = id;
            this.customerName = customerName;
            this.balance = balance;
        }


        public int Id
        {
            get { return id; }

            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Musteri Id-si menfi ola bilmez.");
                }
            }

        }
    }
}
