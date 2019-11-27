using MvvmCross.IoC;
using MvvmCross.ViewModels;
using QuadraticEquation.Core.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuadraticEquation.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<QuadraticViewModel>();
        }
    }

}
