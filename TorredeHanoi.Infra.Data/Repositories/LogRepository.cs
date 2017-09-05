using TorredeHanoi.Infra.Data.Context;
using TorredeHanoi.Models;
using TorredeHanoi.Domain.Repository;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;

namespace TorredeHanoi.Infra.Data.Repositories
{
    public class LogRepository : Repository<Log>, ILogRepository
    {
        private readonly EventStoreSQLContext _context;

        public LogRepository(EventStoreSQLContext context) 
            : base(context)
        {
            _context = context;
        }

        public List<Log> GetByIndexador(int Indexador)
        {
            return (from e in _context.Log where e.Indexador == Indexador select e).ToList();
        }
    }
}
