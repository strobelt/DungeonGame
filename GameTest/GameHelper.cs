using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameTest
{
    public static class GameHelper
    {
        public static T GetRandom<T>(this ICollection<T> source)
        {
            int randomPos = new Random().Next(source.Count);
            return source.ToArray()[randomPos];
        }
    }
}
