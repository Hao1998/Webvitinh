using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Dao
{
    public class MenuDao
    {
        OnlineShop1Context db = null;
        public MenuDao()
        {
            db = new OnlineShop1Context();
        }

        public List<Menus> ListByGroupId()
        {
            return db.Menus.Where(x=>x.Status == true).OrderBy(x => x.DisplayOrder).ToList();
        }
    }
}
