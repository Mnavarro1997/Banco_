using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_
{
    /// <summary>
    /// In this client class we extends of the interface or person.
    /// </summary>
    public class Client : Ipersonable
    {
        public string ClientCode { get; set; }

        public Client(string ClientCode)
        {
            this.ClientCode = ClientCode;
        }

        //public BankAccount y user deberia de extender de Persona.
    }
}
