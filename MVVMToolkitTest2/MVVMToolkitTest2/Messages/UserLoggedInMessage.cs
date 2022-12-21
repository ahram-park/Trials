using CommunityToolkit.Mvvm.Messaging.Messages;
using MVVMToolkitTest2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMToolkitTest2.Messages
{
    public class UserLoggedInMessage : ValueChangedMessage<UserModel>
    {
        public UserLoggedInMessage(UserModel value) : base(value)
        {
        }
    }
}
