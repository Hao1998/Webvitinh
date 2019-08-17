using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Dao
{
    public class OrderDetailDao
    {
        OnlineShop1Context db = null;
        public OrderDetailDao()
        {
            db = new OnlineShop1Context();
        }
        public bool Insert(OrderDetail detail)
        {
            try
            {
                db.OrderDetail.Add(detail);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public long GetId(long id)
        {
            var result = db.OrderDetail.Find(id);
            var model = result.OrderId;
            return model;
        }

        public List<long> GetOrderDetailId(long id)
        {
            var result = db.OrderDetail.OrderBy(x=>x.OrderId == id).ToList();
            List<long> array = new List<long>();
            foreach(var item in result)
            {
                array.Add(item.OrderId);
            }
            return array;
        }

        public IQueryable<OrderDetail> GetOrderDetails(long id)
        {
            var result = db.OrderDetail.Where(x=>x.OrderId == id).AsQueryable();
            return result;
        }

        public List<OrderDetail> GetOrderDetails_2(long id)
        {
            var result = db.OrderDetail.Where(x => x.OrderId == id).ToList();
            return result;
        }


        public bool DeleteOrderDetailJson(long id)
        {
            var temp = db.OrderDetail.Where(x =>x.OrderId == id).ToList();
            db.OrderDetail.RemoveRange(temp);
            db.SaveChanges();
            return true;
        }
    }
}
