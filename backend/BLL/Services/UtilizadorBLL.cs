using BLL.Interfaces;
using DAL;
using DAL.Interfaces;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UtilizadorBLL: IUtilizadorBLL
    {

        private readonly IUtilizadorDAL _dal;

        public UtilizadorBLL(IUtilizadorDAL dal)
        {
            _dal = dal;
        }

        public async Task InserteUserAsync(string auth0UserId)
        {
            await _dal.InsertUserAsync(auth0UserId);
        }
    }
}