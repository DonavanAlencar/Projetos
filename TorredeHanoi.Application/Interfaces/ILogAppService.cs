using System;
using System.Collections.Generic;
using System.Text;
using TorredeHanoi.Models;

namespace TorredeHanoi.Application.Interfaces
{
    public interface ILogAppService : IDisposable
    {
        List<Log> GetByIndexador(int id);

        List<Log> GetAll(int id);
    }
}
