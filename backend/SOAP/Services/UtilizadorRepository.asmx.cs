using SOAP.Repository;
using System;
using System.Data.SqlClient;
using System.Web.Services;

namespace SOAP.Services
{
    /// <summary>
    /// Summary description for Utilizadores
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class UtilizadorRepository : System.Web.Services.WebService
    {
        private readonly DbConnectionFactory _connectionFactory;

        public UtilizadorRepository(DbConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        [WebMethod]
        public void InsertUser(string user)
        {
            try
            {
                if (user == null)
                {
                    throw new ArgumentNullException(nameof(user), "User cannot be null");
                }

                string query = "Exec InserirUtilizador @Auth0UserId";
                using (SqlConnection connection = _connectionFactory.GetConnection())
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    //cmd.Parameters.AddWithValue("@Auth0UserId", user.Auth0UserId);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Database error: " + ex.Message);

            }
        }
    }
}
