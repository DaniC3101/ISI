using System;
using System.Threading.Tasks;
using DAL.Interfaces;
using ServiceReference1;

namespace DAL.Services
{
    public class UtilizadorDAL :IUtilizadorDAL
    {
        public async Task InsertUserAsync(string auth0UserId)
        {
            var client = new UtilizadorRepositorySoapClient(UtilizadorRepositorySoapClient.EndpointConfiguration.UtilizadorRepositorySoap);

            var user = new Utilizador
            {
                Auth0UserId = auth0UserId
            };

            await client.InsertUserAsync(user);
            await client.CloseAsync();
        }
    }
}   