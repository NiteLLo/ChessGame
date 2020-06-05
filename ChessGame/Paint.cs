using System;

namespace ChessGame
{
    public class Paint
    {
        public static void Pole ()
        {
            for (var i = 1; i < 9; i++)
            {
                Console.SetCursorPosition(20, 19 - i);
                Console.WriteLine(i);

                Console.SetCursorPosition(29, 19 - i);
                Console.WriteLine(i);                
            }

            Console.SetCursorPosition(21, 10);
            Console.WriteLine("A");
            Console.SetCursorPosition(22, 10);
            Console.WriteLine("B");
            Console.SetCursorPosition(23, 10);
            Console.WriteLine("C");
            Console.SetCursorPosition(24, 10);
            Console.WriteLine("D");
            Console.SetCursorPosition(25, 10);
            Console.WriteLine("E");
            Console.SetCursorPosition(26, 10);
            Console.WriteLine("F");
            Console.SetCursorPosition(27, 10);
            Console.WriteLine("G");
            Console.SetCursorPosition(28, 10);
            Console.WriteLine("H");

            Console.SetCursorPosition(21, 19);
            Console.WriteLine("A");
            Console.SetCursorPosition(22, 19);
            Console.WriteLine("B");
            Console.SetCursorPosition(23, 19);
            Console.WriteLine("C");
            Console.SetCursorPosition(24, 19);
            Console.WriteLine("D");
            Console.SetCursorPosition(25, 19);
            Console.WriteLine("E");
            Console.SetCursorPosition(26, 19);
            Console.WriteLine("F");
            Console.SetCursorPosition(27, 19);
            Console.WriteLine("G");
            Console.SetCursorPosition(28, 19);
            Console.WriteLine("H");
        }

        public static void Dot(int x, int y, string symbol)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(symbol);
        }

        public static void ChessPiece(PropertiesChessPiece[] arrayOfPiece)
        {
            for (var i = 0; i < 32; i++)
            {
                if (arrayOfPiece[i].positionX > 0 && arrayOfPiece[i].positionY > 0)
                {
                    if ((i >= 0 && i < 8) || (i >= 16 && i < 24))
                    {
                        if (i >= 16 && i < 24)
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(arrayOfPiece[i].positionX, arrayOfPiece[i].positionY);
                            Console.WriteLine("*");
                        }
                        
                        if(i >= 0 && i < 8)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(arrayOfPiece[i].positionX, arrayOfPiece[i].positionY);
                            Console.WriteLine("*");
                        }
                    }

                    if (i == 8 || i == 9 || i == 24 || i == 25)
                    {
                        if (i == 24 || i == 25)
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(arrayOfPiece[i].positionX, arrayOfPiece[i].positionY);
                            Console.WriteLine("#");
                        }

                        if (i == 8 || i == 9)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(arrayOfPiece[i].positionX, arrayOfPiece[i].positionY);
                            Console.WriteLine("#");
                        }
                    }

                    if (i == 10 || i == 11 || i == 26 || i == 27)
                    {
                        if (i == 26 || i == 27)
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(arrayOfPiece[i].positionX, arrayOfPiece[i].positionY);
                            Console.WriteLine("@");
                        }

                        if (i == 10 || i == 11)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(arrayOfPiece[i].positionX, arrayOfPiece[i].positionY);
                            Console.WriteLine("@");
                        }
                    }

                    if (i == 12 || i == 13 || i == 28 || i == 29)
                    {
                        if (i == 28 || i == 29)
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(arrayOfPiece[i].positionX, arrayOfPiece[i].positionY);
                            Console.WriteLine("&");
                        }

                        if (i == 12 || i == 13)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(arrayOfPiece[i].positionX, arrayOfPiece[i].positionY);
                            Console.WriteLine("&");
                        }
                    }

                    if (i == 14 || i == 30)
                    {
                        if (i == 30)
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(arrayOfPiece[i].positionX, arrayOfPiece[i].positionY);
                            Console.WriteLine("$");
                        }

                        if (i == 14)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(arrayOfPiece[i].positionX, arrayOfPiece[i].positionY);
                            Console.WriteLine("$");
                        }
                    }

                    if (i == 15 || i == 31)
                    {
                        if (i == 31)
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.SetCursorPosition(arrayOfPiece[i].positionX, arrayOfPiece[i].positionY);
                            Console.WriteLine("+");
                        }

                        if (i == 15)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(arrayOfPiece[i].positionX, arrayOfPiece[i].positionY);
                            Console.WriteLine("+");
                        }
                    }
                }             
            }
        }
    }
}
