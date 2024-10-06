using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismInheritance.Extensions
{
    public static class SeasonExtension
    {
        public static Season Next(this Season season)
        {
            int seasonInt = (int)season;
            int nextSeason = (seasonInt + 1) % 4;
            return (Season)nextSeason;
        }
    }
}
