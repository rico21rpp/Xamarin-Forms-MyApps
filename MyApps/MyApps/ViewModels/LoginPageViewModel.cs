using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApps.ViewModels
{
	public class LoginPageViewModel : BindableBase
	{
        public string Username { get; set; } 
        public string Password { get; set; }

        public LoginPageViewModel()
        {

        }
	}
}
