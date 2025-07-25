using MauiCalculator.ViewModels;

namespace MauiCalculator.Views;

public partial class CalcPageView : ContentPage
{
	public CalcPageView(CalcPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
    }
}