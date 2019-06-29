using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApps.ViewModels
{
	public class CalculatorPageViewModel : ViewModelBase
	{
        private double _amount;
        private bool _isOprClicked;
        private bool _isTotalCounted;

        public string HistoryNum { get; set; }
        public string DynamicNum { get; set; }

        public CalculatorPageViewModel(INavigationService navigationService) : base(navigationService)
        {

        }


        private DelegateCommand _onBtnClearClickedCommand;
        public DelegateCommand OnBtnClearClickedCommand =>
            _onBtnClearClickedCommand ?? (_onBtnClearClickedCommand = new DelegateCommand(onBtnClearClicked));

        private DelegateCommand<string> _onBtnNumClickedCommand;
        public DelegateCommand<string> OnBtnNumClickedCommand =>
            _onBtnNumClickedCommand ?? (_onBtnNumClickedCommand = new DelegateCommand<string>((num) =>
            {

            }));


        private async void onBtnClearClicked()
        {
            DynamicNum = "0";
            HistoryNum = "";
            _amount = 0;
        }

        private void clearTotal()
        {
            if (_isTotalCounted)
            {
                onBtnClearClicked();
                onBtnClearClicked();
            }
        }

        private async void OnBtnNumClicked(string num)
        {

        }
	}
}
