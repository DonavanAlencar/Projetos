using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TorredeHanoi.Application.Services;
using TorredeHanoi.Application.Interfaces;
using TorredeHanoi.Domain.Interfaces;

namespace TorredeHanoi.Service.Controllers
{
    [Route("api/[controller]")]
    public class TorreOperationsController : Controller
    {
        private readonly ILogAppService _logAppService;
        private readonly IMoveCalculatorAppService _moveCalculatorAppService;

        public TorreOperationsController(ILogAppService logAppService,
                                         IMoveCalculatorAppService moveCalculatorAppService)
        {
            _logAppService = logAppService;
            _moveCalculatorAppService = moveCalculatorAppService;
        }

        [HttpGet]
        public IEnumerable<Move> Get(int id)
        {
            IEnumerable<Move> moves = new List<Move>();

            if (id > 0)
            {
                try
                {
                    moves = _moveCalculatorAppService.GetMoves(id, 0);
                }
                catch (Exception ex)
                {
                    var result = new List<Move>();
                    result.Add(new Move(0) { mensagem = ex.Message });
                    moves = new List<Move>(result);
                }
            }
            else
            {
                var result = new List<Move>();
                result.Add(new Move(0) { mensagem = "Quantidade de Discos não preenchido!" });
                moves = new List<Move>(result);
            }

            return moves;
        }

        [HttpPost]
        public int Post(string movimento)
        {
            _logAppService.GetByIndexador

            return 0;
        }
    }
}
