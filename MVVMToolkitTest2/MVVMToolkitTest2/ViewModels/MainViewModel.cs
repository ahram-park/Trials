using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using MVVMToolkitTest2.Messages;
using MVVMToolkitTest2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMToolkitTest2.ViewModels
{
    public partial class MainViewModel : ObservableRecipient
    {
        public MainViewModel()
        {
            OnActivated();
            User = new UserModel { FirstName = "Ahram", LastName = "Park", Age = 29 };
            _name = "Ahram";
        }

        [ObservableProperty]
        private UserModel user;

        [ObservableProperty]
        private string _name;

        [RelayCommand]
        private void ChangeFirstName(UserModel user)
        {
            Name = user.FirstName;
        }

        protected override void OnActivated()
        {
            base.OnActivated();
            WeakReferenceMessenger.Default.Register<UserLoggedInMessage>(this, (r, m) =>
            {
                ChangeFirstName(m.Value);
            });
        }
    }
}
