using MauiCalculator.MVVM.ViewModels;

namespace MauiCalculator.MVVM.Views;

public partial class CalculatorView : ContentPage
{
	public CalculatorView()
	{
		InitializeComponent();
		BindingContext = new CalcViewModel();
	}
}