using AspEFCore.Model;
using AspEFCore.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AspEFCore.Web.Service
{

    public class CClassIRepository : IRepository<CClass>
    {
        private readonly DataContext _context;

        public CClassIRepository(DataContext context)
        {
            _context = context;
        }
        public CClass Add(CClass newModel)
        {
            _context.CClasss.Add(newModel);
            _context.SaveChanges();
            return newModel;
        }

        public CClass Delete(int id)
        {
            var CClass = _context.CClasss.Find(id);
            _context.CClasss.Remove(CClass);
            _context.SaveChanges();

            return CClass;
        }

        public List<CClass> GetAll()
        {
            return _context.CClasss.ToList();
        }

        public CClass GetById(int id)
        {
            return _context.CClasss.Find(id);
        }

        public CClass Update(int id, CClass newModel)
        {
            var CClass = _context.CClasss.Find(id);
            CClass = newModel;
            _context.CClasss.Update(CClass);
            _context.SaveChanges();

            return CClass;
        }
    }
}
