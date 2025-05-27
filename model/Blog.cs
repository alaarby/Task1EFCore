using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Model
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string description { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
