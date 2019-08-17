using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Dao
{
    public class OrderDao
    {
        OnlineShop1Context db = null;
        public OrderDao()
        {
            db = new OnlineShop1Context();
        }
        public long Insert(Order order)
        {
            db.Order.Add(order);
            db.SaveChanges();
            return order.Id;
        }

        public List<Order> GetOrder()
        {
            return db.Order.OrderBy(x => x.Id).ToList();
        }

        public Order AddOrderJson(Order entity)
        {
            db.Order.Add(entity);
            db.SaveChanges();
            return entity;
        }

        public bool DeleteOrderJson(long id)
        {
            var temp = db.Order.Find(id);
            db.Order.Remove(temp);
            db.SaveChanges();
            return true;
        }

        //public int GetIdOrder(long id)
        //{
        //    var result = db.Order.Where(x => x.Id == id);
        //    var temp = result.
        //}
    }
}
