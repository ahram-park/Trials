using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMToolkitTest3.ViewModels
{
    public partial class MainViewModel : ObservableRecipient
    {
        [ObservableProperty]
        private string _name;

        [RelayCommand]
        private void ChangeFirstName()
        {
        }
    }
}
