using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.BusinessComponents.ConcreteClasses;
using Datas;
using Entities;

namespace Services
{

    public class LoginService
    {
        private readonly ConnectionDb _connectionDb;

        public LoginService(ConnectionDb connectionDb)
        {
            _connectionDb = connectionDb;
        }

        public async Task<LoginQuery> LoginAsync(User user)
        {
            User userDb = await _connectionDb.VerifyCredentialsAsync(user);

            if (userDb == null)
            {
                return new LoginQuery(false, "Incorrect username or password", DateTime.Now, user);
            }
            userDb.Class = await _connectionDb.ReturnClassByIdAsync(userDb.ClassId);
            return new LoginQuery(true, "Welcome " + user.Username + "!", DateTime.Now, userDb);
        }
    }
}
