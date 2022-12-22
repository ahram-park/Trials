using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using MVVMToolkitTest2.Messages;
using MVVMToolkitTest2.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMToolkitTest2.ViewModels
{
    public partial class LogInViewModel : ObservableRecipient
    {
        public LogInViewModel()
        {
            OnActivated();
            User = new UserModel { FirstName = "You", LastName = "Park", Age = 22 };
        }
        [ObservableProperty]
        private UserModel _user;
        [ObservableProperty]
        private string _name;
        [ObservableProperty]
        private ObservableCollection<UserModel> users = new ObservableCollection<UserModel>();
        [RelayCommand]
        private void SendLoggedInUserMessage()
        {
            WeakReferenceMessenger.Default.Send(new UserLoggedInMessage(User));
        }
        [RelayCommand]
        private void AddUsers()
        {
            Users.Add(new UserModel() { FirstName = "Nam", LastName = "Soon", Age = 40 });
        }
    }
}
