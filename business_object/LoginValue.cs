using PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Frameworks.business_object
{
   public class LoginValue
    {
        // Данные для авторизации

        public string SendKeyLogin { get; set; }
        public string SendKeyPassword { get; set; }

        public LoginValue(string SendKeyLogin, string SendKeyPassword)  
        {
            this.SendKeyLogin = SendKeyLogin;  
            this.SendKeyPassword = SendKeyPassword;
        }

    }
}
