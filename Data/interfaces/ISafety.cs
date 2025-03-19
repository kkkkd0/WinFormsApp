using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.interfaces
{
    public interface ISafety
    {
        public bool Compare(string password, string salt, string hashpassword);
        public (string hash, string salt) Salt(string password, uint length);
    }
}
