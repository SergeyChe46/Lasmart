using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;

namespace Lasmart.Repository
{
    public class RepositoryManager
    {
        private readonly ApplicationContext _context;
        private readonly PointRepository _pointRepository;
        public RepositoryManager(ApplicationContext context)
        {
            _context = context;
            _pointRepository = new PointRepository(context);
        }

        public PointRepository Points => _pointRepository;

        public Task Save() => _context.SaveChangesAsync();
    }
}