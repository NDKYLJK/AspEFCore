using AspEFCore.Model;
using AspEFCore.Web.Data;
using System.Collections.Generic;
using System.Linq;


namespace AspEFCore.Web.Service
{
    public class AdminIRepository : IRepository<Admin>
    {
        private readonly DataContext _context;

        public AdminIRepository(DataContext context)
        {
            _context = context;
        }
        public Admin Add(Admin newModel)
        {
            _context.Admins.Add(newModel);
            _context.SaveChanges();
            return newModel;
        }

        public Admin Delete(int id)
        {
            var Admin = _context.Admins.Find(id);
            _context.Admins.Remove(Admin);
            _context.SaveChanges();

            return Admin;
        }

        public List<Admin> GetAll()
        {
            return _context.Admins.ToList();
        }

        public Admin GetById(int id)
        {
            return _context.Admins.Find(id);
        }

        public Admin Update(int id, Admin newModel)
        {
            var Admin = _context.Admins.Find(id);
            Admin = newModel;
            _context.Admins.Update(Admin);
            _context.SaveChanges();

            return Admin;
        }
    }
}
