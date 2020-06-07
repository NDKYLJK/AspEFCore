using AspEFCore.Model;
using AspEFCore.Web.Data;
using System.Collections.Generic;
using System.Linq;

namespace AspEFCore.Web.Service
{
    public class OrderIRepository : IRepository<Order>
    {
        private readonly DataContext _context;

        public OrderIRepository(DataContext context)
        {
            _context = context;
        }
        public Order Add(Order newModel)
        {
            _context.Orders.Add(newModel);
            _context.SaveChanges();
            return newModel;
        }

        public Order Delete(int id)
        {
            var Order = _context.Orders.Find(id);
            _context.Orders.Remove(Order);
            _context.SaveChanges();

            return Order;
        }

        public List<Order> GetAll()
        {
            return _context.Orders.ToList();
        }

        public Order GetById(int id)
        {
            return _context.Orders.Find(id);
        }

        public Order Update(int id, Order newModel)
        {
            var Order = _context.Orders.Find(id);
            Order = newModel;
            _context.Orders.Update(Order);
            _context.SaveChanges();

            return Order;
        }
    }
}
