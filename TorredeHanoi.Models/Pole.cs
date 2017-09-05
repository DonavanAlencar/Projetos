using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TorredeHanoi.Models
{
    public class Pole
    {
        public SortedList<int, Disk> Disks { get; set; }

        public int Number { get; set; }

        public Pole(int number)
        {
            Disks = new SortedList<int, Disk>();
            this.Number = number;
        }

        public bool IsEmpty()
        {
            return Disks.Count == 0;
        }

        public bool AllowDisk(Disk disk)
        {
            if (disk == null)
            {
                return false;
            }
            if (Disks.Count == 0)
            {
                return true;
            }
            return GetTopDisk().Number > disk.Number;
        }

        public Disk GetTopDisk()
        {
            if (Disks.Count > 0)
            {
                return Disks.First().Value;
            }
            return null;
        }

        public void RemoveDisk()
        {
            Disks.Remove(Disks.First().Key);
        }

        public void AddDisk(Disk disk)
        {
            if (disk == null)
            {
                return;
            }
            if (AllowDisk(disk))
            {
                disk.MoveToPole(this);
                Disks.Add(disk.Number, disk);
            }
        }

        override public string ToString()
        {
            return Convert.ToString(Number);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Pole pole = obj as Pole;
            if ((System.Object)pole == null)
            {
                return false;
            }
            return pole.Number == Number;
        }

    }
}
