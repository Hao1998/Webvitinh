using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;


namespace Model.Dao
{
    public class ContentDao
    {
        OnlineShop1Context db = null;
        public ContentDao()
        {
            db = new OnlineShop1Context();
        }

        public IQueryable<Content> ListAllPaging(string SearchString)
        {
            IQueryable<Content> model = db.Content;
            if(!String.IsNullOrEmpty(SearchString))
            {
                model = model.Where(x => x.Name.Contains(SearchString) || x.Name.Contains(SearchString));
            }
            return model.OrderByDescending(x => x.CreateDate);
        }

        public IEnumerable<Content> ListAll(int page, int pageSize)
        {
            IQueryable<Content> model = db.Content;
            return model.OrderByDescending(x => x.CreateDate).ToPagedList(page, pageSize);
        }

        public long Create(Content model)
        {
            //Xử lý alias
            if(!string.IsNullOrEmpty(model.MetalTitle))
            {
                model.MetalTitle = StringHelper.ToUnsignString(model.Name);
            }
            model.CreateDate = DateTime.Now;
            model.Viewcount = 0;
            db.Content.Add(model);
            db.SaveChanges();
            if (!string.IsNullOrEmpty(model.Tags))
            {
                string[] tags = model.Tags.Split(',');
                foreach (var tag in tags)
                {
                    var tagId = StringHelper.ToUnsignString(tag);
                    var existTag = this.CheckTag(tagId);
                    //insert tag to tag table
                    if(!existTag)
                    {
                        this.InsertTag(tagId, tag);
                    }

                    this.InsertContentTag(model.Id, tagId);
                }
            }
            return model.Id;
        }

        public List<Tag> ListTag(long Contentid)
        {
            var model = (from a in db.Tag
                         join b in db.ContentTag
                         on a.Id equals b.TagId
                         where b.ContentId == Contentid
                         select new
                         {
                             ID = b.TagId,
                             Name = a.Name
                         }).AsEnumerable().Select(x => new Tag()
                         {
                             Id = x.ID,
                             Name = x.Name
                         });
            return model.ToList();
        }

        public List<Content> ListAllByTag(string tag, int page, int pageSize)
        {
            var model = (from a in db.Content
                         join b in db.ContentTag
                         on a.Id equals b.ContentId
                         where b.TagId == tag
                         select new
                         {
                             Name = a.Name,
                             MetalTitle = a.MetalTitle,
                             Image = a.Image,
                             Description = a.Description,
                             CreateDate = a.CreateDate,
                             CreatedBy = a.CreatedBy,
                             Id = a.Id

                         }).AsQueryable().Select(x => new Content()
                         {
                             Name = x.Name,
                             MetalTitle = x.MetalTitle,
                             Image = x.Image,
                             Description = x.Description,
                             CreateDate = x.CreateDate,
                             CreatedBy = x.CreatedBy,
                             Id = x.Id
                         });
            return model.OrderByDescending(x => x.CreateDate).ToPagedList(page, pageSize).ToList();
        }

        public Tag GetTag(string id)
        {
            return db.Tag.Find(id);
        }

        public long Edit(Content content)
        {
            //Xử lý alias
            if(string.IsNullOrEmpty(content.MetalTitle))
            {
                content.MetalTitle = StringHelper.ToUnsignString(content.Name);
            }
            //var entity = db.Content.Find(content.Id);
            db.Entry(content).State = EntityState.Modified;
            db.SaveChanges();
            

            //Xử lý tag
            if (!string.IsNullOrEmpty(content.Tags))
            {
                this.RemoveAllContentTag(content.Id);
                string[] tags = content.Tags.Split(',');
                foreach (var tag in tags)
                {
                    var tagId = StringHelper.ToUnsignString(tag);
                    var existedTag = this.CheckTag(tagId);

                    //insert to to tag table
                    if (!existedTag)
                    {
                        this.InsertTag(tagId, tag);
                    }

                    //insert to content tag
                    this.InsertContentTag(content.Id, tagId);

                }
            }

            return content.Id;
        }

        public void RemoveAllContentTag(long contentId)
        {
            db.ContentTag.RemoveRange(db.ContentTag.Where(x => x.ContentId == contentId));
            db.SaveChanges();
        }

        public void InsertContentTag(long contentid, string tagid)
        {
            var contentTag = new ContentTag();
            contentTag.ContentId = contentid;
            contentTag.TagId = tagid;
            db.ContentTag.Add(contentTag);
            db.SaveChanges();
        }

        public void InsertTag(string id, string name)
        {
            var tag = new Tag();
            tag.Id = id;
            tag.Name = name;
            db.Tag.Add(tag);
            db.SaveChanges();
        }

        public Content GetByID(long id)
        {
            return db.Content.Find(id);
        }

        public bool CheckTag(string id)
        {
            return db.Tag.Count(x =>x.Id == id) > 0;
        }
    }
}
