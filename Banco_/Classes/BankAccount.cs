using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_.Classes
{
    /// <summary>
    /// it should extends of Notification 
    /// </summary>
    public class BankAccount
    {
        public string iban;
        public decimal money;

        public BankAccount(string iban, int money)
        {
            this.iban = iban;
            this.money = money;

        }
    }
}
