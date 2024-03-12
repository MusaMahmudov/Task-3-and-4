using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Team : IComparable<Team>
    {
        public int Points { get; set; }
        public Team(int _points)
        {
            Points = _points;
        }

        public int CompareTo(Team? other)
        {
            return other.Points - Points;
        }
    }
}
