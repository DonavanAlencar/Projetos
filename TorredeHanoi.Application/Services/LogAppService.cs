using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TorredeHanoi.Application.Interfaces;
using TorredeHanoi.Domain.Repository;
using TorredeHanoi.Models;

namespace TorredeHanoi.Application.Services
{
    public class LogAppService : ILogAppService
    {
        private readonly IMapper _mapper;
        private readonly ILogRepository _customerRepository;

        public LogAppService(IMapper mapper, ILogRepository customerRepository)
        {
            _mapper = mapper;
            _customerRepository = customerRepository;
        }

        public List<Log> GetByIndexador(int id)
        {
            return _customerRepository.GetByIndexador(id);
        }

        #region IDisposable Support
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
