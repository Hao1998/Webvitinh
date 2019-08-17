using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Dao
{
    public class UserDao
    {
        OnlineShop1Context db = null;
        public UserDao()
        {
            db = new OnlineShop1Context();
        }

        public long Insert(User entity)
        {
            var user = db.User.SingleOrDefault(x => x.Username == entity.Username);
            if (user == null)
            {
                db.User.Add(entity);
                db.SaveChanges();
                return entity.Id;
            }
            else
            {
                return user.Id;
            }
        }

        public int Login(string userName, string passWord, bool isLoginAdmin=false)
        {
            var result = db.User.SingleOrDefault(x => x.Username == userName);
            if (result == null)
            {
                return 0;
            }
            else
            {
                if(isLoginAdmin == true)
                {
                    if(result.GroupID == Common.CommonConstants.ADMIN_GROUP || result.GroupID == Common.CommonConstants.MOD_GROUP)
                    {
                        if (result.Status == false)
                        {
                            return -1;
                        }
                        else
                        {
                            if (result.Password == passWord)
                                return 1;
                            else
                                return -2;
                        }
                    }
                    else
                    {
                        return -3;
                    }
                }
                else
                {
                    if (result.Status == false)
                    {
                        return -1;
                    }
                    else
                    {
                        if (result.Password == passWord)
                            return 1;
                        else
                            return -2;
                    }
                }                         
            }
        }

        public User GetByID(string userName)
        {
            return db.User.SingleOrDefault(x => x.Username == userName);
        }

        public bool CheckUserName(string username)
        {
            return db.User.Count(x => x.Username == username) > 0;
        }

        public bool CheckEmail(string email)
        {
            return db.User.Count(x => x.Email == email) > 0;
        }


        public List<User> ListAll()
        {
            return db.User.OrderBy(x => x.Id).ToList();
        }

        public User AddUserJson(User entity)
        {
            db.User.Add(entity);
            db.SaveChanges();
            return entity;
        }

        public bool DeleteUserJson(long id)
        {
            var temp = db.User.Find(id);
            db.User.Remove(temp);
            db.SaveChanges();
            return true;
        }
    }
}
