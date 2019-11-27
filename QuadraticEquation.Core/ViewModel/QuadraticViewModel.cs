using MvvmCross.Commands;
using MvvmCross.ViewModels;
using QuadraticEquation.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace QuadraticEquation.Core.ViewModel
{
    public class QuadraticViewModel : MvxViewModel
    {
        private readonly ICalculationService _calculationService;
        private double _x1;
        private double _x2;
        private double _a;
        private double _b;
        private double _c;
        private double _result;
        private MvxCommand _calculateCommand;

        public QuadraticViewModel(ICalculationService calculationService)
        {
            _calculationService = calculationService;
        }

        public double x1
        {
            get => _x1;
            set
            {
                _x1 = value;
                SetProperty(ref _x1, value);
            }
        }

        public double x2
        {
            get => _x2;
            set
            {
                _x2 = value;
                SetProperty(ref _x2,value);
            }
        }
        public double a
        {
            get => _a;
            set
            {
                _a = value;
                SetProperty(ref _a, value);
            }
        }
        public double b
        {
            get => _b;
            set
            {
                _b = value;
                SetProperty(ref _b, value);
            }
        }
        public double c
        {
            get => _c;
            set
            {
                _c = value;
                SetProperty(ref _c, value);
            }
        }

        public double Result
        {
            get => _result;
            set => SetProperty(ref _result, value);
        }

        public ICommand CalculateCommand
        {
            get
            {
                _calculateCommand = _calculateCommand ?? new MvxCommand(Calculate);
                return _calculateCommand;
            }
        }

        public async override Task Initialize()
        {
            await base.Initialize();
            x1 = 0;
            x2 = 0;
            a = 0;
            b = 0;
            c = 0;

            Calculate();
        }

        private void Calculate()
        {
            Result = _calculationService.GetQuadratic(x1,x2,a,b,c);
        }
    }
}
