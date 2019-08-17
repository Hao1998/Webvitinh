using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Dao
{
    public class FooterDao
    {
        OnlineShop1Context db = null;
        public FooterDao()
        {
            db = new OnlineShop1Context();
        }

        public Footer GetFooter()
        {
            return db.Footer.SingleOrDefault(x => x.Status == true);
        }
    }
}
