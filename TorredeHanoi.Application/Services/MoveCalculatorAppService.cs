using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using TorredeHanoi.Domain.Interfaces;
using TorredeHanoi.Models;

namespace TorredeHanoi.Application.Services
{
    public class MoveCalculatorAppService : IMoveCalculatorAppService
    {
        public List<Move> moves { get; set; }

        public List<Move> GetMoves(int numberOfDisks, int idMoves)
        {
            moves = new List<Move>();
            Calculate(numberOfDisks - 1, 0, 2, idMoves);
            return moves;
        }

        public void Calculate(int n, int fromPole, int toPole, int idMoves)
        {
            if (n == -1)
            {
                return;
            }
            int intermediatePole = GetIntermediatePole(fromPole, toPole);

            Calculate(n - 1, fromPole, intermediatePole, idMoves);
            moves.Add(new Move(fromPole, toPole, idMoves));
            Calculate(n - 1, intermediatePole, toPole, idMoves);
        }

        public int GetIntermediatePole(int startPole, int endPole)
        {
            return (3 - startPole - endPole);
        }

        #region IDisposable Support
        private bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    if(moves != null)
                    {
                        moves = null;
                    }
                }

                disposedValue = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
             GC.SuppressFinalize(this);
        }
        #endregion
    }
}
