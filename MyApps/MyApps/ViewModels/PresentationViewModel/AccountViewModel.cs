using System;
using System.Collections.Generic;
using System.Text;

namespace MyApps.ViewModels.PresentationViewModel
{
    public class AccountViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }

        /*
        public AccountViewModel(AccountModel account)
        {
            Username = account.Username;
            Password = account.Password;
        }
        */
    }
}
