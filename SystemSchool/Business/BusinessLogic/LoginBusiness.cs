using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.BusinessComponents.ConcreteClasses;
using Datas;
using Entities;

namespace Business
{
    public class LoginBusiness
    {
        private readonly ConnectionDb ConnectionDb = new ConnectionDb();
        public async Task<LoginQuery> LoginAsync(User user) 
        {
            LoginQuery query;
            User userDb = await ConnectionDb.VerifyCredentialsAsync(user);

            if (userDb == null)
            {
                query = new LoginQuery(false, "Incorrect username or password", DateTime.Now, user);
            }
            else 
            {
                userDb.Class = await ConnectionDb.FindClassByIdAsync(userDb.ClassId);
                query = new LoginQuery(true, "Welcome " + user.Username + "!", DateTime.Now, userDb);
            }

            return query;
        }
    }
}
    