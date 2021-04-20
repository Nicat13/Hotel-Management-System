using Hotel.entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.data.IRepository
{
    public interface IAccountRepository
    {
        int Login(string email, string password);
        int Userauthenticator(int userId, string password);
        string HashPassword(string password);
        List<AppUsers> GetAppUsers();
        List<Roles> GetRoles();
        AppUsers GetUserByid(int userId);
        bool? UpdateUser(AppUsers user);
        bool AddUser(AppUsers user);
        bool DeleteUser(int userId);

    }
}
