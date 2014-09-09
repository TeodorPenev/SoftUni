using System;
using System.Collections.Generic;
using System.Threading;

struct Object
{
    public int x;
    public int y;
    public char c;
    public ConsoleColor color;
}
class FallingRocks
{

    static void PrintOnPosition(int x, int y, char c, ConsoleColor color = ConsoleColor.White)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(c);
    }
    static void PrintStringOnPosition(int x, int y, string str, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(str);
    }
    static void Main()
    {
        Console.BufferHeight = Console.WindowHeight = 20;
        Console.BufferWidth = Console.WindowWidth = 50;


        int playField = 25;
        int livesCount = 5;
        int score = 0;
        int chance;
        int rockTypes = 12;

        Object body = new Object();
        body.x = 12;
        body.y = Console.WindowHeight - 1;
        body.c = 'O';
        body.color = ConsoleColor.Gray;

        Object leftHand = new Object();
        leftHand.x = 11;
        leftHand.y = Console.WindowHeight - 1;
        leftHand.c = '(';
        leftHand.color = ConsoleColor.Gray;

        Object rightHand = new Object();
        rightHand.x = 13;
        rightHand.y = Console.WindowHeight - 1;
        rightHand.c = ')';
        rightHand.color = ConsoleColor.Gray;

        Random rockDispenser = new Random();
        List<Object> rocks = new List<Object>();

        Console.WriteLine("Welcome to Falling Rocks!");
        Console.WriteLine();
        Console.WriteLine("You are a dwarf \"(O)\" climbing a mountain but from the top of it a rock slide is heading your way!");
        Console.WriteLine(@"Your job is to avoid getting hit by any of the
falling rocks.");
        Console.WriteLine(@"But everyone knows that despite being short,
dwarfs are very strong and have incredibly tough
bodies. " +
        @"You are able to suffer only 5 hits before finally getting swept away with the rest of the
rocks.");
        Console.WriteLine("Good luck!");
        Console.WriteLine();
        Console.WriteLine("Press [enter] to begin.");
        Console.ReadLine();

        while (true)
        {
            bool collision = false;

            Object rock = new Object();
            chance = rockDispenser.Next(1, rockTypes + 1);
            switch (chance)
            {
                case 1:
                    rock.x = rockDispenser.Next(0, playField + 1);
                    rock.y = 0;
                    rock.c = '^';
                    rock.color = ConsoleColor.Blue;
                    rocks.Add(rock);
                    break;
                case 2:
                    rock.x = rockDispenser.Next(0, playField + 1);
                    rock.y = 0;
                    rock.c = '@';
                    rock.color = ConsoleColor.Gray;
                    rocks.Add(rock);
                    break;
                case 3:
                    rock.x = rockDispenser.Next(0, playField + 1);
                    rock.y = 0;
                    rock.c = '*';
                    rock.color = ConsoleColor.Cyan;
                    rocks.Add(rock);
                    break;
                case 4:
                    rock.x = rockDispenser.Next(0, playField + 1);
                    rock.y = 0;
                    rock.c = '&';
                    rock.color = ConsoleColor.Yellow;
                    rocks.Add(rock);
                    break;
                case 5:
                    rock.x = rockDispenser.Next(0, playField + 1);
                    rock.y = 0;
                    rock.c = '+';
                    rock.color = ConsoleColor.Cyan;
                    rocks.Add(rock);
                    break;
                case 6:
                    rock.x = rockDispenser.Next(0, playField + 1);
                    rock.y = 0;
                    rock.c = '%';
                    rock.color = ConsoleColor.Green;
                    rocks.Add(rock);
                    break;
                case 7:
                    rock.x = rockDispenser.Next(0, playField + 1);
                    rock.y = 0;
                    rock.c = '$';
                    rock.color = ConsoleColor.Red;
                    rocks.Add(rock);
                    break;
                case 8:
                    rock.x = rockDispenser.Next(0, playField + 1);
                    rock.y = 0;
                    rock.c = '#';
                    rock.color = ConsoleColor.DarkYellow;
                    rocks.Add(rock);
                    break;
                case 9:
                    rock.x = rockDispenser.Next(0, playField + 1);
                    rock.y = 0;
                    rock.c = '!';
                    rock.color = ConsoleColor.DarkRed;
                    rocks.Add(rock);
                    break;
                case 10:
                    rock.x = rockDispenser.Next(0, playField + 1);
                    rock.y = 0;
                    rock.c = '.';
                    rock.color = ConsoleColor.White;
                    rocks.Add(rock);
                    break;
                case 11:
                    rock.x = rockDispenser.Next(0, playField + 1);
                    rock.y = 0;
                    rock.c = ';';
                    rock.color = ConsoleColor.Magenta;
                    rocks.Add(rock);
                    break;
                case 12:
                    rock.x = rockDispenser.Next(0, playField + 1);
                    rock.y = 0;
                    rock.c = '-';
                    rock.color = ConsoleColor.White;
                    rocks.Add(rock);
                    break;
                default:
                    break;
            }

            while (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey();

                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (leftHand.x - 1 >= 0)
                    {
                        leftHand.x -= 1;
                        body.x -= 1;
                        rightHand.x -= 1;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (rightHand.x + 1 <= playField)
                    {
                        leftHand.x += 1;
                        body.x += 1;
                        rightHand.x += 1;
                    }
                }
            }

            List<Object> newRocks = new List<Object>();

            for (int i = 0; i < rocks.Count; i++)
            {
                Object oldRock = rocks[i];
                Object newRock = new Object();
                newRock.x = oldRock.x;
                newRock.y = oldRock.y + 1;
                newRock.c = oldRock.c;
                newRock.color = oldRock.color;

                if ((newRock.x == leftHand.x || newRock.x == body.x || newRock.x == rightHand.x) &&
                    newRock.y == body.y)
                {
                    livesCount--;
                    collision = true;

                    if (livesCount <= 0)
                    {
                        //Console.Clear(); //If you want clear end-game screen

                        PrintStringOnPosition(15, 8, "GAME OVER!", ConsoleColor.Red);
                        PrintStringOnPosition(13, 10, "Your score is " + score, ConsoleColor.White);
                        PrintStringOnPosition(11, 11, "Press [enter] to exit.", ConsoleColor.White);
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                }

                if (newRock.y < Console.WindowHeight)
                {
                    newRocks.Add(newRock);
                }
            }

            rocks = newRocks;
            Console.Clear();

            if (collision)
            {
                //rocks.Clear(); //clears the rocks if you get hit

                PrintOnPosition(leftHand.x, leftHand.y, 'X', ConsoleColor.Red);
                PrintOnPosition(body.x, body.y, 'X', ConsoleColor.Red);
                PrintOnPosition(rightHand.x, rightHand.y, 'X', ConsoleColor.Red);
            }
            else
            {
                PrintOnPosition(leftHand.x, leftHand.y, leftHand.c, leftHand.color);
                PrintOnPosition(body.x, body.y, body.c, body.color);
                PrintOnPosition(rightHand.x, rightHand.y, rightHand.c, rightHand.color);
            }

            foreach (Object stone in rocks)
            {
                PrintOnPosition(stone.x, stone.y, stone.c, stone.color);
            }

            score++;

            PrintStringOnPosition(33, 0, "Falling Rocks", ConsoleColor.White);
            PrintStringOnPosition(33, 6, "Lives: " + livesCount, ConsoleColor.White);
            PrintStringOnPosition(33, 7, "Score: " + score, ConsoleColor.White);

            Thread.Sleep(150);
        }
    }
}