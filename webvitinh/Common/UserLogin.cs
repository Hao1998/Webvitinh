using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webvitinh
{
    [Serializable]
    public class UserLogin
    {
        public long UserID { get; set; }
        public string UserName { get; set; }
        public string GroupID { set; get; }
    }
}
