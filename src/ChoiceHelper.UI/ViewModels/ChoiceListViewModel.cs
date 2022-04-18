using ChoiceHelper.Core.Domain.Entities;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace ChoiceHelper.UI.ViewModels;

public partial class ChoiceListViewModel : ObservableObject
{
    public ObservableCollection<Choice> Choices => new ObservableCollection<Choice>();

    public ChoiceListViewModel()
    {

    }
}
