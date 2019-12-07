using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guldkortet
{
    class User
    {
        protected string serialNumber;
        protected string name;

        public User()
        {

        }
        public User(string serialNumber, string name)
        {
            this.serialNumber = serialNumber;
            this.name = name;
        }
    }
}
