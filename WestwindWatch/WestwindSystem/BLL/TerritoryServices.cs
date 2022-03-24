using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WestwindSystem.DAL;
using WestwindSystem.Entities;

namespace WestwindSystem.BLL
{
    public class TerritoryServices
    {
        //define a readonly data field for context
        private readonly WestwindContext _context;

        //define a greedy constructor for initailizing the DbContext
        internal TerritoryServices(WestwindContext context)
        {
            _context = context;
        }

        public List<Territory> GetByRegion(int regionID)
        {   
            IEnumerable<Territory> queryResult = _context  
                .Territories
                .Where(currentItem => currentItem.RegionID == regionID)
                .OrderBy(currentItem => currentItem.TerritoryDescription);
            return queryResult.ToList();
        }
    }
}
