using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_
{
    /// <summary>
    /// In this user class we extends of the interface of user.
    /// </summary>
    public class User : Iuserable
    {

        public string UserName { get; set; }
        public string Mail { get; set; }


        public User(string UserName, string Mail)
        {
            this.UserName = UserName;
            this.Mail = Mail;
        }
    }
}
