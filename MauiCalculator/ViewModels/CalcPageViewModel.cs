using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Dangl.Calculator;
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

    [RelayCommand]
    public void Reset()
    {
        Formula = string.Empty;
        Result = "0";
    }

    [RelayCommand]
    public void Backspace()
    {
        if (!string.IsNullOrEmpty(Formula))
        {
            if (Formula[^1] == ' ' && Formula.Length > 2)
            {
                Formula = Formula[0..(Formula.Length - 3)];
            }
            else
            {
                Formula = Formula[0..(Formula.Length - 1)];
            }
        }
    }

    [RelayCommand]
    public void Calculate()
    {
        if (string.IsNullOrEmpty(Formula))
        {
            return;
        }

        CalculationResult calculation = Calculator.Calculate(Formula);
        Result = calculation.Result.ToString();
    }
}
