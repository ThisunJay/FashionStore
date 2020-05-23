using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Posts
    {
        public string PostsObject { get; set; }

        public string getDetails()
        {
            return PostsObject;
        }
    }
}
