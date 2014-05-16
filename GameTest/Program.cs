#region Using Statements
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
#endregion

namespace GameTest
{
#if WINDOWS || LINUX
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Properties properties = new Properties()
            {
                ContentList = Directory.GetFiles("Content").Select(x => x.Substring(x.IndexOf('\\') + 1)).ToList(),
                TileSize = 100
            };
            using (var game = new Game1(properties))
                game.Run();
        }
    }
#endif
}
