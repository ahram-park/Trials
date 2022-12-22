using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMToolkitTest2.Models
{
    public class UserModel : IEquatable<UserModel>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public bool Equals(UserModel? other)
        {
            if (other is null)
                return false;

            return this.FirstName == other.FirstName && this.LastName == other.LastName;
        }
        public override bool Equals(object obj) => Equals(obj as UserModel);
        public override int GetHashCode() => (FirstName, LastName).GetHashCode();
    }
}
