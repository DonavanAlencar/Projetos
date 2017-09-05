using System;
using System.Collections.Generic;
using System.Text;
using TorredeHanoi.Models;

namespace TorredeHanoi.Domain.Repository
{
    public interface ILogRepository : IRepository<Log>
    {
        List<Log> GetByIndexador(int id);
    }
}
