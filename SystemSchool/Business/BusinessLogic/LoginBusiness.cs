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
        ConnectionDb Datas = new ConnectionDb();
        public async Task<LoginQuery> LoginAsync(User user) 
        {
            LoginQuery query = new LoginQuery();
            User userDb = await Datas.VerifyCredentialsAsync(user);

            if (userDb == null)
            {
                query.Moment = DateTime.Now;
            }
            else 
            {
                userDb.Class = await Datas.FindClassByUserAsync(userDb.ClassId);
                query.User = userDb;
                query.Moment = DateTime.Now;
                query.Result = true;
            }

            return query;
        }
    }
}
    