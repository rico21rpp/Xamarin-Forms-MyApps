using MyApps.ViewModels.PresentationViewModel;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApps.ViewModels
{
	public class LoginPageViewModel : ViewModelBase
	{
        private readonly INavigationService _navigationService;
        private readonly IPageDialogService _pageDialogService;

        private DelegateCommand _loginCommand;

        private List<AccountViewModel> listAccount = new List<AccountViewModel>();

        public string Username { get; set; }
        public string Password { get; set; }

        public DelegateCommand LoginCommand =>
            _loginCommand ?? (_loginCommand = new DelegateCommand(() =>
            {
                Login(Username, Password);
            }));

        public LoginPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService) : base(navigationService)
        {
            _navigationService = navigationService;
            _pageDialogService = pageDialogService;
            setListAccount();
        }

        private void setListAccount()
        {
            listAccount.Add(new AccountViewModel
            {
                Username = "user1",
                Password = "user1"
            });

            listAccount.Add(new AccountViewModel
            {
                Username = "user2",
                Password = "user2"
            });
        }

        async void Login(string uname, string pass)
        {
            foreach (AccountViewModel account in listAccount)
            {
                if (account.Username == uname && account.Password == pass)
                {
                    await _navigationService.NavigateAsync("/HomePage");
                }
                else
                {
                    await _pageDialogService.DisplayAlertAsync("Incorrect Username/Password!", "The username or password you entered is incorrect.", "OK");
                }
            }
        } 
	}
}
