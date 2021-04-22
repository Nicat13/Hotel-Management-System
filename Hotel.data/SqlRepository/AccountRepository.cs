using Hotel.entity.DAL;
using Hotel.data.IRepository;
using Hotel.entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.data.StructModel;
using Hotel.entity.Utilities;

namespace Hotel.data.SqlRepository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly HotelDB _context;
        public AccountRepository()
        {
            _context = new HotelDB();
        }

        public AddUpdateResponseModel AddUser(AppUsers user)
        {
            AppUsers appUser = _context.AppUsers.FirstOrDefault(x => x.FIN == user.FIN);
            if (appUser == null)
            {
                if (_context.AppUsers.Any(x =>x.FIN!=user.FIN&& x.Email == user.Email))
                {
                    return new AddUpdateResponseModel { Message = "Email Already Exist", Status = false };
                }
                else if (_context.AppUsers.Any(x => x.FIN != user.FIN && x.PhoneNumber == user.PhoneNumber))
                {
                    return new AddUpdateResponseModel { Message = "Phonenumber Already Exist", Status = false };
                }
                user.Password = user.Password.HashPassword();
                _context.AppUsers.Add(user);
                _context.SaveChanges();
                return new AddUpdateResponseModel { Message = "ok", Status = true };
            }
            return new AddUpdateResponseModel { Message = "FIN Already Exist", Status = false };
        }

        public bool DeleteUser(int userId)
        {
            AppUsers appUser = _context.AppUsers.FirstOrDefault(x => x.Id==userId);
            if (appUser != null)
            {
                _context.AppUsers.Remove(appUser);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<AppUsers> GetAppUsers()
        {
            return (from au in _context.AppUsers.ToList()
                    from r in _context.Roles
                    where r.Id == au.rolesId
                    select new AppUsers
                    {
                        Id = au.Id,
                        Name = au.Name,
                        Surname = au.Surname,
                        FIN = au.FIN,
                        Email = au.Email,
                        PhoneNumber = au.PhoneNumber,
                        RoleName = r.RoleName
                    }).ToList();
        }

        public List<Roles> GetRoles()
        {
            return _context.Roles.ToList();
        }

        public AppUsers GetUserByid(int userId)
        {
            return _context.AppUsers.FirstOrDefault(u => u.Id == userId);
        }

  

        public int Login(string email, string password)
        {
            string hashedpass = password.HashPassword();
            AppUsers user = _context.AppUsers.FirstOrDefault(x => x.Email == email && x.Password == hashedpass);
            if (user != null)
            {
                return user.Id;
            }
            return 0;
        }

        public AddUpdateResponseModel UpdateUser(AppUsers user)
        {
            try
            {
                AppUsers appUser = _context.AppUsers.FirstOrDefault(x => x.FIN == user.FIN);
                if (appUser != null)
                {
                    if (_context.AppUsers.Any(x=> x.FIN != user.FIN && x.Email==user.Email))
                    {
                        return new AddUpdateResponseModel { Message = "Email Already Exist", Status = false };
                    }
                    else if (_context.AppUsers.Any(x => x.FIN != user.FIN && x.PhoneNumber == user.PhoneNumber))
                    {
                        return new AddUpdateResponseModel { Message = "Phonenumber Already Exist", Status = false };
                    }
                    appUser.Name = user.Name;
                    appUser.Surname = user.Surname;
                    appUser.Email = user.Email;
                    appUser.PhoneNumber = user.PhoneNumber;
                    appUser.rolesId = user.rolesId;
                    if (!string.IsNullOrEmpty(user.Password.Trim()))
                    {
                        appUser.Password = user.Password.HashPassword();
                    }
                    _context.SaveChanges();
                    return new AddUpdateResponseModel {Message="ok",Status=true };
                }
                return new AddUpdateResponseModel { Message = "User not found", Status = false };
            }
            catch (Exception ex)
            {
                return new AddUpdateResponseModel { Message = ex.Message, Status = false };
            }
        }

        public int Userauthenticator(int userId, string password)
        {
            string hashedpass = password.HashPassword();
            AppUsers user = _context.AppUsers.FirstOrDefault(x => x.Id == userId && x.Password == hashedpass);
            if (user != null)
            {
                return user.Id;
            }
            return 0;
        }
    }
}
