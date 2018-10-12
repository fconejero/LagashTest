using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public interface IUser
    {
        void SetName(string name);

        void SetLastName(string lastName);

        string GetFullName();
    }
}
