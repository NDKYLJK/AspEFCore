using AspEFCore.Model;
using AspEFCore.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspEFCore.Web.Service
{
    public class UserIRepository : IRepository<User>
    {
        private readonly DataContext _context;

        public UserIRepository(DataContext context)
        {
            _context = context;
        }
        public User Add(User newModel)
        {
            _context.Users.Add(newModel);
            _context.SaveChanges();
            return newModel;
        }

        public User Delete(int id)
        {
            var User = _context.Users.Find(id);
            _context.Users.Remove(User);
            _context.SaveChanges();

            return User;
        }

        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public User GetById(int id)
        {
            return _context.Users.Find(id);
        }

        public User Update(int id, User newModel)
        {
            var User = _context.Users.Find(id);
            User = newModel;
            _context.Users.Update(User);
            _context.SaveChanges();

            return User;
        }
    }
}
