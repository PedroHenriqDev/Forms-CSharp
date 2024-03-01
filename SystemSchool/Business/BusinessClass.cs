using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datas;
using Entities;

namespace Business
{
    public class BusinessClass
    {
        DatasClass Datas = new DatasClass();
        public async Task<User> LoginAsync(User user) 
        {
            return await Datas.VerifyCredentialsAsync(user);
        }
    }
}
    