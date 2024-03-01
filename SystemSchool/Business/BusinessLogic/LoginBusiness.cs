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
        DatasClass Datas = new DatasClass();
        public async Task<LoginQuery> LoginAsync(User user) 
        {
            LoginQuery query = new LoginQuery();
            User userDb = await Datas.VerifyCredentialsAsync(user);
            userDb.Class = await Datas.FindClassByUserAsync(userDb);

            if(userDb.Class != null)
            {
                query.User = userDb;
                query.Moment = DateTime.Now;
                query.Result = true;
            }

            query.Moment = DateTime.Now;
            return query;
        }
    }
}
    