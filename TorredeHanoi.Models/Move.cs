using System;
using System.Collections.Generic;
using System.Text;
using TorredeHanoi.Models;

namespace TorredeHanoi.Application.Services
{
    public class Move
    {
        public Pole FromPole { get; set; }

        public Pole ToPole { get; set; }

        public int idMoves { get; set; }

        public string mensagem { get; set; }

        public Move(int idMoves)
        {
            this.idMoves = idMoves;
        }

        public Move(int fromPoleNumber, int toPoleNumber, int idMoves)
        {
            this.FromPole = GameState.Poles[fromPoleNumber];
            this.ToPole = GameState.Poles[toPoleNumber];
            this.idMoves = idMoves;
        }

        public bool AffectCount()
        {
            if (ToPole.Equals(FromPole))
            {
                return false;
            }
            return IsValid();
        }

        public bool IsValid()
        {
            if (ToPole.Equals(FromPole))
            {
                return true;
            }
            return ToPole.AllowDisk(FromPole.GetTopDisk());
        }
    }
}
