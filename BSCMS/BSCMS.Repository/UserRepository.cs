using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using BSCMS.Model;

namespace BSCMS.Repository
{
    public class UserRepository : IUserRepository
    {
        private string _connectionString;

        public UserRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public User FindBy(string username, string passwordHash)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("GetUserByUsernameAndPasswordHash", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@Username", SqlDbType.NVarChar, 100).Value = username;
                command.Parameters.Add("@PasswordHash", SqlDbType.NVarChar, 100).Value = passwordHash;

                connection.Open();

                using (IDataReader reader = command.ExecuteReader())
                {
                    return GetUserCollectionFromReader(reader).FirstOrDefault();
                }
            }
        }

        private IList<User> GetUserCollectionFromReader(IDataReader dataReader)
        {
            List<User> users = new List<User>();

            while (dataReader.Read())
            {
                users.Add(new User
                {
                    Id = (int)dataReader["Id"],
                    Username = (string)dataReader["Username"],
                    PasswordHash = (string)dataReader["PasswordHash"]
                });
            }

            return users;
        }
    }
}
