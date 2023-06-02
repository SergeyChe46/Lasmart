using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;

namespace Lasmart.Repository
{
    public class PointRepository : BaseRepository<Point>
    {
        public PointRepository(ApplicationContext context) : base(context)
        {
            using (var db = new ApplicationContext())
            {
            }
        }
    }
}