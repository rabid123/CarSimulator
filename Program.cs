﻿using System;
using static System.Console;

namespace CarSimulator
{
    class Program
    {
        static void Main(string[] args)
        {

            bool shouldNotExit = true;

            while (shouldNotExit)

            {
                WriteLine("1. Add car");
                WriteLine("2. List cars");
                WriteLine("3. simulate speed");
                WriteLine("4. Exit");

                ConsoleKeyInfo keyPressed = ReadKey(true);
                Clear();

                switch (keyPressed.Key)
                {

                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:

                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:

                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        shouldNotExit = false;
                        break;

                }
                Clear();
            }

        }
    }
}
