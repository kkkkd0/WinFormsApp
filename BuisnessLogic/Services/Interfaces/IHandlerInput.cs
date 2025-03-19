using Data.interfaces;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLogic.Services.Interfaces
{
    public interface IHandlerInput
    {
        public bool Initaction(UserAction userAction, User user);
    }
}
