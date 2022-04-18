using ChoiceHelper.UI.ViewModels;

namespace ChoiceHelper.UI;

public partial class ChoicesListPage : ContentPage
{
	public ChoicesListPage(ChoiceListViewModel viewModel)
	{
		BindingContext = viewModel;

		InitializeComponent();
	}
}