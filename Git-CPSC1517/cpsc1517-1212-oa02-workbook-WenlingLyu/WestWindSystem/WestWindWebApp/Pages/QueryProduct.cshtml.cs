#region Add namespaces for access BLL and Entities
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WestWindSystem.BLL;
using WestWindSystem.Entities;
#endregion

namespace WestWindWebApp.Pages
{
    public class QueryProductModel : PageModel
    {
        private readonly CategoryServices _categoryServices;
        private readonly ProductServices _productServices;

        public QueryProductModel(CategoryServices categoryServices, ProductServices productServices)
        {
            _categoryServices = categoryServices;
            _productServices = productServices;
        }

        public string FeedbackMessage { get; set; }

        public List<Category> CategoryList { get; set; } = new();

        [BindProperty]

        public int SelectCategoryID { get; set; }

        public Lazy<Product> ProductQuertResultList { get; set; } = new();



        public void OnGet()
        {
            CategoryList = _categoryServices.Category_List();
        }

        public IActionResult OnPostResult()
        {
            if(SelectCategoryID == 0)
            {
                FeedbackMessage = "You must select a category";
            }
            else
            {
                ProductQuertResultList = _productServices.Product_GetByCategoryID(SelectCategoryID);
            }
        }
    }
}
