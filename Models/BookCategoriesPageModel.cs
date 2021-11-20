using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc.RazorPages;
using Tibulca_Bogdan_Lab8.Data;

namespace Tibulca_Bogdan_Lab8.Models
{
    public class BookCategoriesPageModel : PageModel
    {
        public List<AssignedCategoryData> AssignedCategoryData;

        public void PopulateAssignedCategoryData(Tibulca_Bogdan_Lab8Context context, Book Book)
        {

        }
    }
}
