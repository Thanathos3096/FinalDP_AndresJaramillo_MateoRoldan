using MvvmCross.IoC;
using MvvmCross.ViewModels;
using Prime.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prime.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<PrimeViewModel>();
        }
    }
}
