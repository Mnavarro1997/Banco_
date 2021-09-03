using Banco_.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_.Services
{
    public class UserServices
    {
        public void Register(string email, string password, string name, string phone, string ClientCode, string type)
        {
            Isendable notificationService;

            /*switch(type)
            {
                case "Client":
                    notificationService = new MailServices1();
                    Client client = new Client(email, password, name, phone, ClientCode);
                    notificationService.Send($"Welcome")

            }
            */
        }
    }
}
