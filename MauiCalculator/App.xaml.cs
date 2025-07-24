using MauiCalculator.ViewModels;
using MauiCalculator.Views;

namespace MauiCalculator
{
    public partial class App : Application
    {
        private readonly CalcPageViewModel viewModel;

        public App(CalcPageViewModel viewModel)
        {
            InitializeComponent();
            this.viewModel = viewModel;
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new CalcPageView(viewModel));
        }
    }
}