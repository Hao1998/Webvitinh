using PagedList.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Dao
{
    public class ProductCategoryDao
    {
        OnlineShop1Context db = null;
        public ProductCategoryDao()
        {
            db = new OnlineShop1Context();
        }

        public List<ProductCategory> ListProductCategory(ref int TotalRecord, int pageIndex = 1, int pageSize = 1)
        {
            TotalRecord = db.ProductCategory.Count();

            //Neu muon join
            //List<ProductViewModel>
            /*var model = from a in db.Product
                        join b in db.ProductCategory
                        on a.CategoryID equals b.ID
                        where a.CategoryID == categoryId
                        select new ProductViewModel()
                        {
                            CateMetaTitle = b.MetaTitle,
                            CateName = b.Name,
                            CreatedDate = a.CreateDate,
                            ID = a.ID,
                            Image = a.Image,
                            Name = a.Name,
                            MetaTitle = a.MetalTitle,
                            Price = a.Price
                        };*/


            var model = db.ProductCategory.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            return model.ToList();
        }

        public ProductCategory AddProductCategoryJson(ProductCategory entity)
        {
            db.ProductCategory.Add(entity);
            db.SaveChanges();
            return entity;
        }

        public List<ProductCategory> ListAll()
        {
            return db.ProductCategory.Where(x => x.Status == true).OrderBy(x => x.DisplayOrder).ToList();
        }

        public bool DeleteProductCategoryJson(int id)
        {
            var temp = db.ProductCategory.Find(id);
            db.ProductCategory.Remove(temp);
            db.SaveChanges();
            return true;
        }

        public ProductCategory ViewDetail(long? id)
        {
            return db.ProductCategory.Find(id);
        }
    }
}
