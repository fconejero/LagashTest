using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class User : IUser
    {
        private string Name { get; set; }

        private string LastName { get; set; }

        public User(string name)
        {
            this.Name = name;
        }

        public string GetFullName()
        {
            return string.Format("Nombre: {0}. \nApellido: {1}.", this.Name, this.LastName);
        }

        public void SetName(string name)
        {
            this.Name = name;
        }

        public void SetLastName(string lastName)
        {
            this.LastName = lastName;
        }
    }
}
