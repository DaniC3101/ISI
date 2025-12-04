using Models;
using System;
using System.Data.SqlClient;


namespace SOAP.Repository
{
    public class UtilizadorRepository
    {
        private readonly DbConnectionFactory _connectionFactory;

        public UtilizadorRepository(DbConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public int AddUser(Utilizador user)
        {
            if (user == null) throw new ArgumentNullException(nameof(user));

            string query = "EXEC RegistrarUtilizador @Auth0UserId, @Nome, @Email, @ImgUrl";

            using (SqlConnection connection = _connectionFactory.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@Auth0UserId", user.Auth0UserId);
                cmd.Parameters.AddWithValue("@Nome", user.Nome);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@ImgUrl", user.ImgUrl);
                connection.Open();

                var result = cmd.ExecuteScalar();
                return Convert.ToInt32(result);
            }
        }

    }
}