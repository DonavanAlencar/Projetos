using System;
using System.Collections.Generic;
using System.Text;

namespace TorredeHanoi.Models
{
    public class Disk
    {
        public int Number { get; set; }

        public Disk(int number) : base()
        {
            Number = number;
        }

        public void MoveToPole(Pole destinationPole)
        {
            if (destinationPole == null || destinationPole.Disks == null)
            {
                return;
            }
            int numberOfRungsOnSelectedPole = destinationPole.Disks.Count;
        }

        public override string ToString()
        {
            return Number.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Disk disk = obj as Disk;
            if ((System.Object)disk == null)
            {
                return false;
            }
            return disk.Number == Number;
        }
    }
}
