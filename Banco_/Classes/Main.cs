using Banco_.Classes;
using System;

namespace Banco_
{
    class M
    {
        static void Main(string[] args)
        {
            BankAccount ba1 = new BankAccount("ES6699 ", 2000);
            BankAccount ba2 = new BankAccount("ES69 ", 5000);


            User user1 = new User("Pepe_Lopez30", "masndao@gmail.com");
            User user2 = new User("Pepito_70", "qwe@gmail.com");

            Client client1 = new Client("1287y");
            Client client2 = new Client("5880t");

            Console.WriteLine("Hello: "  +user1.UserName   +" your UserCode is: " + client1.ClientCode + " and the money in your account is of : " + ba1.money);
            



        }
    }
}
