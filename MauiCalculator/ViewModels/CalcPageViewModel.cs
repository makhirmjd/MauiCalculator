using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Diagnostics;

namespace MauiCalculator.ViewModels;

public partial class CalcPageViewModel : ObservableObject
{
    [ObservableProperty]
    private string formula = string.Empty;

    [ObservableProperty]
    private string result = "0";

    [RelayCommand]
    public void Operation(string number) => Formula += number;
}
