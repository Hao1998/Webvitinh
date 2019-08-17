using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Dao
{
    public class SlideDao
    {
        OnlineShop1Context db = null;
        public SlideDao()
        {
            db = new OnlineShop1Context();
        }

        public List<Slide> ListAll()
        {
            return db.Slide.Where(x => x.Status == true).OrderBy(y => y.DisplayOrder).ToList();
        }
    }
}
