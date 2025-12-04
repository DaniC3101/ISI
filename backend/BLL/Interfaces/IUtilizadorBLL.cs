using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IUtilizadorBLL
    {
        Task InserteUserAsync(string auth0UserId);
    }
}
