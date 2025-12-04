using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IUtilizadorDAL
    {
        Task InsertUserAsync(string auth0UserId);
    }
}
