using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Interfaces
{
    public interface ICheckInput
    {
        public bool InputCheck(User user);
    }
}
