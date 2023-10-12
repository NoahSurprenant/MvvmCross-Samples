using Microsoft.Maui.ApplicationModel;
using MvvmCross;
using MvvmCross.ViewModels;
using TipCalc.Core.Services;
using TipCalc.Core.ViewModels;

namespace TipCalc.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            var isMainThread = MainThread.IsMainThread;
            Mvx.IoCProvider.RegisterType<ICalculationService, CalculationService>();

            RegisterAppStart<TipViewModel>();
        }
    }
}