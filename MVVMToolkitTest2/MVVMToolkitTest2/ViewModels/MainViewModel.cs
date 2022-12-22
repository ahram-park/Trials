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
    public partial class MainViewModel : ObservableRecipient
    {
        public MainViewModel()
        {
            OnActivated();
            User = new UserModel() { FirstName = "Aaron", LastName = "Park", Age = 29 };
            Users.Add(new UserModel() { FirstName = "Aaron", LastName = "Park", Age = 29 });
            Users.Add(new UserModel() { FirstName = "Ahram", LastName = "Park", Age = 29 });
            Users.Add(new UserModel() { FirstName = "SangKun", LastName = "Park", Age = 29 });
            Users.Add(new UserModel() { FirstName = "SangHun", LastName = "Park", Age = 29 });
            Users.Add(new UserModel() { FirstName = "Yesman", LastName = "Park", Age = 29 });
            FirstName = "Ahram";
            LastName = "Park";
            
        }

        [ObservableProperty]
        private UserModel user;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(FullName))]
        private string _firstName;
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(FullName))]
        private string _lastName;

        public string FullName => $"{FirstName} {LastName}";

        [ObservableProperty]
        private ObservableCollection<UserModel> users = new ObservableCollection<UserModel>();

        [ObservableProperty]
        private UserModel _selectedUser;

        [RelayCommand]
        private void ChangeFirstName(UserModel user)
        {
            FirstName = user.FirstName;
        }

        [RelayCommand]
        private void AddUsers()
        {
            Users.Add(new UserModel() { FirstName = "Nam", LastName = "Soon", Age = 40 });
        }
        [RelayCommand]
        private void RemoveUser()
        {
            Users.Remove(SelectedUser);
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
