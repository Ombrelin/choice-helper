using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoiceHelper.UI.ViewModels;

public interface IDialogService
{
    Task<string> DisplayPromptAsync(string title, string subtitle);
}

