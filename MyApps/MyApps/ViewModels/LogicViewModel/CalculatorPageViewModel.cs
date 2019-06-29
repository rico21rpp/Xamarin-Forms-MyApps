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

        private DelegateCommand _onBtnDelClickedCommand;
        public DelegateCommand OnBtnDelClickedCommand =>
            _onBtnDelClickedCommand ?? (_onBtnDelClickedCommand = new DelegateCommand(onBtnDelClicked));

        private DelegateCommand _onBtnTotalClickedCommand;
        public DelegateCommand OnBtnTotalClickedCommand =>
            _onBtnTotalClickedCommand ?? (_onBtnTotalClickedCommand = new DelegateCommand(onBtnTotalClicked));

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


        private async void onBtnDelClicked()
        {
            if (!_isTotalCounted && DynamicNum != "0")
            {
                if (DynamicNum.Length == 1)
                    DynamicNum = "0";
                else
                {
                    int len = DynamicNum.Length;
                    DynamicNum = DynamicNum.Substring(0, len - 1);
                }
            }
        }

        private async void onBtnTotalClicked()
        {
            if (!_isTotalCounted && HistoryNum != "" && DynamicNum != "0")
            {
                string[] historyNumSplitted = HistoryNum.Split(' ');
                string lastOpr = historyNumSplitted[historyNumSplitted.Length - 1];
                double dynamicNum = double.Parse(DynamicNum);

                if (lastOpr == "+")
                    _amount += dynamicNum;
                else if (lastOpr == "-")
                    _amount -= dynamicNum;
                else if (lastOpr == "x")
                    _amount *= dynamicNum;
                else if (lastOpr == "/")
                    _amount /= dynamicNum;

                HistoryNum = HistoryNum + " " + DynamicNum + " = " + _amount;
                DynamicNum = "= " + _amount;
                _isTotalCounted = true;
            }
        }

        private async void OnBtnNumClicked(string num)
        {

        }
	}
}
