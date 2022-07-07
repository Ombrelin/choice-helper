using ChoiceHelper.UI.Services;
using ChoiceHelper.UI.ViewModels;

namespace ChoiceHelper.UI;

public partial class ChoicesListPage : ContentPage
{
	public ChoicesListPage(ChoicesListPage page)
	{
		BindingContext = new ChoiceListViewModel(new DialogService(page));

		InitializeComponent();
	}
}