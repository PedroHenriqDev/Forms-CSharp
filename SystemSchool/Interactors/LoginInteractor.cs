using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;
using Entities;
using Microsoft.Win32;

namespace Interactors
{
    public class LoginInteractor
    {
        LoginBusiness business = new LoginBusiness();
        public async Task<User> LoginInteractorAsync(User user) 
        {
            return await business.LoginAsync(user);
        }
    }
}
