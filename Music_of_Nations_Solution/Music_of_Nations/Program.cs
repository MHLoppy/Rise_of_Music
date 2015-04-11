﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_of_Nations
{
    public class Program
    {
        /// <summary>
        /// The directory path where the different music mood directories are located.
        /// </summary>
        private static String SoundsTracksDirPath = "sounds/tracks/";

        /// <summary>
        /// The "battle_defeat" music mood track directory path.
        /// </summary>
        private static String BattleDefeatDirPath = SoundsTracksDirPath + "battle_defeat/";

        /// <summary>
        /// The "battle_victory" music mood track directory path.
        /// </summary>
        private static String BattleVictoryDirPath = SoundsTracksDirPath + "battle_victory/";

        /// <summary>
        /// The "economic" music mood track directory path.
        /// </summary>
        private static String EconomicDirPath = SoundsTracksDirPath + "economic/";

        /// <summary>
        /// The "lose" music mood track directory path.
        /// </summary>
        private static String LoseDirPath = SoundsTracksDirPath + "lose/";

        /// <summary>
        /// The "win" music mood track directory path.
        /// </summary>
        private static String WinDirPath = SoundsTracksDirPath + "win/";

        /// <summary>
        /// The entry point to Music of Nations.
        /// </summary>
        /// <param name="args">Not currently used.</param>
        public static void Main(string[] args)
        {
            // Prints the header
            PrintWelcomeMessage();

            // Initializes the application and returns success or failure
            bool initSuccess = Init();

            // If the app failed to initialize
            if (!initSuccess)
            {
                Console.WriteLine("Failed to initialize");

                // Allow the user to exit once they have read any messages
                Console.Write("Press any key to continue...");
                Console.ReadKey();

                // Exit with failure status code
                Environment.Exit(-1);
            }
            else // Else, the app successfully initialized
            {
                Console.WriteLine("Music of Nations initialized successfully");
            }

            // Allow the user to exit once they have read any messages
            Console.Write("Press any key to continue...");
            Console.ReadKey();

            // Exit with success status code
            Environment.Exit(0);
        }

        /// <summary>
        /// Initializes the program and checks for existance of necessary directories.
        /// </summary>
        /// <returns>True if successfully initialized, false otherwise.</returns>
        private static bool Init()
        {
            Console.WriteLine("Initializing");

            // Check the existance of these directories
            bool battleDefeatDirExists = Directory.Exists(BattleDefeatDirPath);
            bool battleVictoryDirExists = Directory.Exists(BattleVictoryDirPath);
            bool economicDirExists = Directory.Exists(EconomicDirPath);
            bool loseDirExists = Directory.Exists(LoseDirPath);
            bool winDirExists = Directory.Exists(WinDirPath);

            // Print the results
            Console.WriteLine("Directory exists (" + BattleDefeatDirPath + "): " + battleDefeatDirExists);
            Console.WriteLine("Directory exists (" + BattleVictoryDirPath + "): " + battleVictoryDirExists);
            Console.WriteLine("Directory exists (" + EconomicDirPath + "): " + economicDirExists);
            Console.WriteLine("Directory exists (" + LoseDirPath + "): " + loseDirExists);
            Console.WriteLine("Directory exists (" + WinDirPath + "): " + winDirExists);

            // Returns true if all directories exist, false if even one does not exist
            return (battleDefeatDirExists && battleVictoryDirExists && economicDirExists && loseDirExists && winDirExists);
        }

        /// <summary>
        /// Prints the welcome header.
        /// </summary>
        private static void PrintWelcomeMessage()
        {
            Console.WriteLine("==============================");
            Console.WriteLine("       Music of Nations");
            Console.WriteLine("==============================");
        }
    }
}