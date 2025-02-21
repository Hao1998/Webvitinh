﻿using Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Dao
{
    public class CategoryDao
    {
        OnlineShop1Context db = null;
        public CategoryDao()
        {
            db = new OnlineShop1Context();
        }
        public long Insert(Category category)
        {
            db.Category.Add(category);
            db.SaveChanges();
            return category.Id;
        }
        public List<Category> ListAll()
        {
            return db.Category.Where(x => x.Status == true).ToList();
        }
        public ProductCategory ViewDetail(long id)
        {
            return db.ProductCategory.Find(id);
        }
    }
}
