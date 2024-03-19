using System;
using System.Threading.Tasks;
using Datas;
using Entities;
using Entities.TransientClasses;

namespace Services
{
    /// <summary>
    /// Provides methods for user login.
    /// </summary>
    public class LoginService
    {
        private readonly ConnectionDb _connectionDb;
        private readonly EncryptEntitiesService _encryptEntities;
        private readonly FillEntitiesService _fillEntities;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginService"/> class.
        /// </summary>
        /// <param name="connectionDb">The database connection.</param>
        /// <param name="encryptEntities">The service for encrypting entities.</param>
        /// <param name="fillEntities">The service for filling entities with related data.</param>
        public LoginService(
            ConnectionDb connectionDb,
            EncryptEntitiesService encryptEntities,
            FillEntitiesService fillEntities)
        {
            _connectionDb = connectionDb ?? throw new ArgumentNullException(nameof(connectionDb));
            _encryptEntities = encryptEntities ?? throw new ArgumentNullException(nameof(encryptEntities));
            _fillEntities = fillEntities ?? throw new ArgumentNullException(nameof(fillEntities));
        }

        /// <summary>
        /// Logs in a user asynchronously.
        /// </summary>
        /// <param name="user">The user to log in.</param>
        /// <returns>A task representing the asynchronous operation and containing the login result.</returns>
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
