using Hotel.entity.DAL;
using Hotel.data.IRepository;
using Hotel.entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.data.SqlRepository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly HotelDB _context;
        public AccountRepository()
        {
            _context = new HotelDB();
        }

        public string HashPassword(string password)
        {
            var bytes = new UTF8Encoding().GetBytes(password);
            var hashBytes = System.Security.Cryptography.MD5.Create().ComputeHash(bytes);
            string hashedpass = Convert.ToBase64String(hashBytes);
            return hashedpass;
        }

        public int Login(string email, string password)
        {
            string hashedpass = HashPassword(password);
            AppUsers user = _context.AppUsers.FirstOrDefault(x => x.Email == email && x.Password == hashedpass);
            if (user != null)
            {
                return user.Id;
            }
            return 0;
        }

        public int Userauthenticator(int userId, string password)
        {
            string hashedpass = HashPassword(password);
            AppUsers user = _context.AppUsers.FirstOrDefault(x => x.Id == userId && x.Password == hashedpass);
            if (user != null)
            {
                return user.Id;
            }
            return 0;
        }
    }
}
