using System;
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
        private readonly FillEntitiesService _fillEntities;

        public LoginService(
            ConnectionDb connectionDb,
            EncryptEntitiesService encryptEntities,
            FillEntitiesService fillEntities)
        {
            _connectionDb = connectionDb;
            _encryptEntities = encryptEntities;
            _fillEntities = fillEntities;
        }

        public async Task<EntityQuery<User>> LoginAsync(User user)
        {
            user.PasswordHash = _encryptEntities.EncryptPasswordSHA512(user.PasswordHash);
            User userDb = await _connectionDb.VerifyCredentialsAsync(user);

            if (userDb == null)
            {
                return new EntityQuery<User>(false, "Incorrect username or password", DateTime.Now, user);
            }

            await _fillEntities.FillUserWithGroupAsync(userDb);
            return new EntityQuery<User>(true, "Welcome " + user.Username + "!", DateTime.Now, userDb);
        }
    }
}
