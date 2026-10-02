using ExecicioCarrossel.ViewModels;

namespace ExecicioCarrossel.Views;

public partial class ViagemPage : ContentPage
{
	public ViagemPage(ViagemViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}