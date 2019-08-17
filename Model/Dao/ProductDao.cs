using Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Dao
{
    public class ProductDao
    {
        OnlineShop1Context db = null;
        public ProductDao()
        {
            db = new OnlineShop1Context();
        }

        public List<Product> GetAllProduct()
        {
            return db.Product.OrderBy(x => x.Id).ToList();
        }

        public List<Product> ListRelatedProducts(int productID)
        {
            var product = db.Product.Find(productID);
            return db.Product.Where(x => x.Id != productID && x.CategoryId == product.CategoryId).ToList();
        }

        public List<Product> ListNewProduct(int top)
        {
          
            return db.Product.OrderBy(x => x.CreateDate).Take(top).Take(top).ToList();
        }

        public List<Product> ListFeatureProduct(int top)
        {
            return db.Product.OrderByDescending(x => x.Price).Take(top).ToList();
        }

        public Product AddProductJson(Product entity)
        {
            db.Product.Add(entity);
            db.SaveChanges();
            return entity;
        }

        public bool DeleteProductCategoryJson(int id)
        {
            var temp = db.Product.Find(id);
            db.Product.Remove(temp);
            db.SaveChanges();
            return true;
        }

        public List<Product> GetDetail(long categoryId)
        {
            var model = db.Product.Where(x => x.CategoryId == categoryId);
            return model.ToList();
        }

        public List<Product> ListProductByCategoryId(long categoryId, ref int TotalRecord, int pageIndex = 1, int pageSize = 1)
        {
            TotalRecord = db.Product.Where(x => x.CategoryId == categoryId).Count();
            var model = db.Product.OrderBy(x => x.Viewcount).Where(x => x.CategoryId == categoryId).Skip((pageIndex - 1) * pageSize).Take(pageSize);
            return model.ToList();
        }

        public List<ProductViewModel> Search(string keyword, ref int totalRecord, int pageIndex = 1, int pageSize = 2)
        {
            totalRecord = db.Product.Where(x => x.Name == keyword).Count();
            var model = (from a in db.Product
                         join b in db.ProductCategory
                         on a.CategoryId equals b.Id
                         where a.Name.Contains(keyword)
                         select new
                         {
                             CateMetaTitle = b.MetaTitle,
                             CateName = b.Name,
                             CreatedDate = a.CreateDate,
                             ID = a.Id,
                             Images = a.Image,
                             Name = a.Name,
                             MetaTitle = a.MetalTitle,
                             Price = a.Price
                         }).AsEnumerable().Select(x => new ProductViewModel()
                         {
                             CateMetaTitle = x.MetaTitle,
                             CateName = x.Name,
                             CreatedDate = x.CreatedDate,
                             ID = x.ID,
                             Images = x.Images,
                             Name = x.Name,
                             MetaTitle = x.MetaTitle,
                             Price = x.Price
                         });
            model.OrderByDescending(x => x.CreatedDate).Skip((pageIndex - 1) * pageSize).Take(pageSize);
            return model.ToList();
        }


        public List<Product> AllProducts(ref int TotalRecord, int pageIndex = 1, int pageSize = 1)
        {
            TotalRecord = db.Product.Count();
            var model = db.Product.OrderBy(x => x.Viewcount).Skip((pageIndex - 1) * pageSize).Take(pageSize);
            return model.ToList();
        }
        
        public Product ViewDetail(int id)
        {
            return db.Product.Find(id);
        }

        public List<string> ListName(string keyword)
        {
            return db.Product.Where(x => x.Name.Contains(keyword)).Select(x => x.Name).ToList();
        }
    }
}
