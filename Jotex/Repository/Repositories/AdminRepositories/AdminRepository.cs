using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.AdminRepositories
{
    public interface IAdminRepository
    {
        MyAdmin Login(string email, string password);
        bool UserExsis(string email);
        MyAdmin CheckByToken(string token);
        void UpdateToken(int id, string token);
    }

    public class AdminRepository : IAdminRepository
    {
        private readonly CompanyDbContext _context;

        public AdminRepository(CompanyDbContext context)
        {
            _context = context;
        }

        public MyAdmin CheckByToken(string token)
        {
            return _context.MyAdmins.FirstOrDefault(a => a.Token == token);
        }

        public MyAdmin Login(string email, string password)
        {
            MyAdmin admin = _context.MyAdmins.FirstOrDefault(a => a.Email == email);

            if (admin != null /* && CryptoHelper.Crypto.VerifyHashedPassword(admin.Password,password)*/ )
            {
                return admin;
            }

            return null;
        }

        public void UpdateToken(int id, string token)
        {
            MyAdmin admin = _context.MyAdmins.Find(id);

            admin.Token = token;

            _context.SaveChanges();
        }

        public bool UserExsis(string email)
        {
            return _context.MyAdmins.Any(a => a.Email == email);
        }
    }
}
