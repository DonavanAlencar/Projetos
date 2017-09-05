using System;
using System.Collections.Generic;
using System.Text;
using TorredeHanoi.Application.Services;

namespace TorredeHanoi.Domain.Interfaces
{
    public interface IMoveCalculatorAppService : IDisposable
    {
        List<Move> moves { get; set; }

        List<Move> GetMoves(int numberOfDisks, int idMoves);

        void Calculate(int n, int fromPole, int toPole, int idMoves);

        int GetIntermediatePole(int startPole, int endPole);
    }
}
