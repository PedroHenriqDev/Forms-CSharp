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
        DatasClass datasCls = new DatasClass();
        public DataTable N_Login(EntityClass obj) 
        {
            return datasCls.DLogin(obj);
        }
    }
}
    