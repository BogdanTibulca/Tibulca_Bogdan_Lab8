using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tibulca_Bogdan_Lab8.Models
{
    public class Category
    {
        public int ID { get; set; }
        public String CategoryName { get; set; }
        public ICollection<BookCategory> BookCategories { get; set; }


    }
}
