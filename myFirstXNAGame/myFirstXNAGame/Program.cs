using System;

namespace myFirstXNAGame
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (myFirstXNAGame game = new myFirstXNAGame())
            {
                game.Run();
            }
        }
    }
#endif
}
