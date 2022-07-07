using ChoiceHelper.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoiceHelper.UI.Services;
public class DialogService : IDialogService
{
    private readonly Page page;

    public DialogService(Page page)
    {
        this.page = page;
    }

    public Task<string> DisplayPromptAsync(string title, string subtitle) => this.page.DisplayPromptAsync(title, subtitle);
}

