using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema; // for table
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WestwindSystem.DAL;//for westwindContext
using WestwindSystem.Entities; // for region

namespace WestwindSystem.BLL
{
    [Table("Regions")]
    public class RegionServices
    {
        private readonly WestwindContext _context;

        internal RegionServices(WestwindContext context)
        {
            _context = context;
        }

        public List<Region> Region_List()
        {
            return _context
                .Regions
                .OrderBy(currentItem => currentItem.RegionDescription)
                .ToList();
        }

        public Region Region_GetById(int regionId)
        {
            return _context
                .Regions
                .Where(currentItem => currentItem.RegionId == regionId)
                .FirstOrDefault();
        }
    }
}
