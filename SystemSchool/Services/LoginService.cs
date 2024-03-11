using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datas;
using Entities;
using Entities.TransientClasses;

namespace Services
{
    public class LoginService
    {
        private readonly ConnectionDb _connectionDb;
        private readonly EncryptEntitiesService _encryptEntities;

        public LoginService(ConnectionDb connectionDb, EncryptEntitiesService encryptEntities)
        {
            _connectionDb = connectionDb;
            _encryptEntities = encryptEntities;
        }

        public async Task<EntityQuery<User>> LoginAsync(User user)
        {
            user.PasswordHash = _encryptEntities.EncryptPasswordSHA512(user.PasswordHash);
            User userDb = await _connectionDb.VerifyCredentialsAsync(user);

            if (userDb == null)
            {
                return new EntityQuery<User>(false, "Incorrect username or password", DateTime.Now, user);
            }
            userDb.Class = await _connectionDb.ReturnClassByIdAsync(userDb.ClassId);
            return new EntityQuery<User>(true, "Welcome " + user.Username + "!", DateTime.Now, userDb);
        }
    }
}
