using MvvmCross.Commands;
using MvvmCross.ViewModels;
using Prime.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Prime.Core.ViewModels
{
    public class PrimeViewModel : MvxViewModel
    {
       
        private MvxCommand _calculateCommand;
        private readonly IPrimeService _primeService;
        private int _n;
        private string _result;

        public PrimeViewModel(IPrimeService primeService)
        {
            _primeService = primeService;
        }
        public int N
        {
            get => _n;
            set => SetProperty(ref _n, value);
        }

        public async override Task Initialize()
        {
            await base.Initialize();
            N = 20;
            Calculate();
        }
        public ICommand CalculateCommand
        {
            get
            {
                _calculateCommand = _calculateCommand ?? new MvxCommand(Calculate);
                return _calculateCommand;
            }
        }
        public string Result
        {

            get => _result;
            set => SetProperty(ref _result, value);
            
        }
        private void Calculate()
        {
            Result = _primeService.GetPrime(N);
        }
    }
}

