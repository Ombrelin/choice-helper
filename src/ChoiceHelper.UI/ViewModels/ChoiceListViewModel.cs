using ChoiceHelper.Core.Domain.Entities;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace ChoiceHelper.UI.ViewModels;

public partial class ChoiceListViewModel : ObservableObject
{
    public ObservableCollection<Choice> Choices => new ObservableCollection<Choice>();

    private readonly IDialogService dialogService;

    public ChoiceListViewModel(IDialogService dialogService)
    {
        this.dialogService = dialogService;
    }

    [ICommand]
    public async Task AddChoice()
    {
        string name = await this.dialogService.DisplayPromptAsync("Question 1", "What's your name?");
        Choices.Add(new Choice(name));
    }
}
