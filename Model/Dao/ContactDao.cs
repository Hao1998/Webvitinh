using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Dao
{
    public class ContactDao
    {
        OnlineShop1Context db = null;
        public ContactDao()
        {
            db = new OnlineShop1Context();
        }

        public Contact GetActiveContact()
        {
            return db.Contact.Single(x => x.Status == true);
        }

        public int InsertFeedBack(FeedBack fb)
        {
            db.FeedBack.Add(fb);
            db.SaveChanges();
            return fb.Id;
        }
    }
}
