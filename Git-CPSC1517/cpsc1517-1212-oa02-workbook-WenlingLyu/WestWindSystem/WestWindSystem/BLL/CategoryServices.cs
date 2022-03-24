using WestWindSystem.DAL; //For WestWindContext
using WestWindSystem.Entities; //For entities

namespace WestWindSystem.BLL
{
    public  class CategoryServices
    {
        //Step1 : Define a readonly data field for the custom DbContext class
        //and use constructor injection to set the value of the data field
        private readonly WestWindContext _dbContext;

        internal CategoryServices(WestWindContext context)
        {
            _dbContext = context;
        }

        //Step2: Define methods that uses the DbContext
        public List<Category> Category_List()
        {
            IEnumerable<Category> resultListQuery = _dbContext
                .Categories
                .OrderBy(item => item.CategoryName);
            return resultListQuery.ToList();
        }

        public Category Category_GetById(int categoryID)
        {
            IEnumerable<Category> singleResultQuery = _dbContext
                .Categories
                .Where(item => item.CategoryID == categoryID);
            return singleResultQuery.FirstOrDefault();
        }

        public List <Category>Category_GetByPartialCategoryNameOrDescription(
            string partialNameOrDescription)
        {
            IEnumerable<Category> resultListQuery = _dbContext
                .Categories
                .Where(item => item.CategoryName.Contains(partialNameOrDescription)
                ||item.Description.Contains(partialNameOrDescription));
            return resultListQuery.ToList();
        }
    }
}
