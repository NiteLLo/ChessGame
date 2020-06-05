using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  ");

            Console.OutputEncoding = Encoding.UTF8;

            bool game = true, comWalk = false, userWalk = true;
            int saveCounter = 0, numberOfPiece = -1;
            string chessMove = "", realChessMove = "";

            Paint.Pole();
            for (var i = 0; i < 3; i++)
            {
                Console.Beep();
            }

            Console.Title = "Шахматы";

            PropertiesChessPiece[] arrayOfPiece = new PropertiesChessPiece[33];
            #region
            for (var i = 0; i < 8; i++)
            {
                arrayOfPiece[i] = new PropertiesChessPiece(21 + i, 17);
            }

            for (var i = 16; i < 24; i++)
            {
                arrayOfPiece[i] = new PropertiesChessPiece(21 + i - 16, 12);
            }
            arrayOfPiece[8] = new PropertiesChessPiece(21, 18);
            arrayOfPiece[9] = new PropertiesChessPiece(28, 18);

            arrayOfPiece[24] = new PropertiesChessPiece(21, 11);
            arrayOfPiece[25] = new PropertiesChessPiece(28, 11);

            arrayOfPiece[10] = new PropertiesChessPiece(22, 18);
            arrayOfPiece[11] = new PropertiesChessPiece(27, 18);

            arrayOfPiece[26] = new PropertiesChessPiece(22, 11);
            arrayOfPiece[27] = new PropertiesChessPiece(27, 11);

            arrayOfPiece[12] = new PropertiesChessPiece(23, 18);
            arrayOfPiece[13] = new PropertiesChessPiece(26, 18);

            arrayOfPiece[28] = new PropertiesChessPiece(23, 11);
            arrayOfPiece[29] = new PropertiesChessPiece(26, 11);

            arrayOfPiece[14] = new PropertiesChessPiece(24, 18);
            arrayOfPiece[15] = new PropertiesChessPiece(25, 18);

            arrayOfPiece[30] = new PropertiesChessPiece(24, 11);
            arrayOfPiece[31] = new PropertiesChessPiece(25, 11);

            #endregion

            while (game)
            {
                numberOfPiece = -1;
                saveCounter = 0;
                chessMove = "";
                realChessMove = "";
                userWalk = true;
                comWalk = false;
                Paint.ChessPiece(arrayOfPiece);

                realChessMove = ChangeUserStr(ref chessMove, ref realChessMove, arrayOfPiece, ref saveCounter, false);

                if (realChessMove[8] == '1')
                {
                    while (userWalk)
                    {

                        if (realChessMove == "")
                        {
                            realChessMove = ChangeUserStr(ref chessMove, ref realChessMove, arrayOfPiece, ref saveCounter, false);
                        }

                        if (saveCounter >= 0 && saveCounter <= 7 && CheckWalkPawn(arrayOfPiece, saveCounter, realChessMove, ref numberOfPiece))
                        {
                            BehaviorPawn(ref arrayOfPiece, saveCounter, realChessMove, ref game, numberOfPiece, false); // Pawn
                            userWalk = false;
                        }
                        else if (saveCounter >= 8 && saveCounter <= 9 && CheckWalkRook(arrayOfPiece, saveCounter, realChessMove, ref numberOfPiece))
                        {
                            Behavior(ref arrayOfPiece, saveCounter, realChessMove, numberOfPiece, ref game, false); //Rook
                            userWalk = false;
                        }
                        else if (saveCounter >= 10 && saveCounter <= 11 && CheckWalkBishop(arrayOfPiece, saveCounter, realChessMove, ref numberOfPiece))
                        {
                            Behavior(ref arrayOfPiece, saveCounter, realChessMove, numberOfPiece, ref game, false); //Bishop
                            userWalk = false;
                        }
                        else if (saveCounter >= 12 && saveCounter <= 13 && CheckWalkKnight(arrayOfPiece, saveCounter, realChessMove, ref numberOfPiece))
                        {
                            Behavior(ref arrayOfPiece, saveCounter, realChessMove, numberOfPiece, ref game, false); //Knight
                            userWalk = false;
                        }
                        else if (saveCounter == 14 && (CheckWalkRook(arrayOfPiece, saveCounter, realChessMove, ref numberOfPiece) || CheckWalkKnight(arrayOfPiece, saveCounter, realChessMove, ref numberOfPiece)))
                        {
                            Behavior(ref arrayOfPiece, saveCounter, realChessMove, numberOfPiece, ref game, false); //Queen
                            userWalk = false;
                        }
                        else if (saveCounter == 15 && CheckWalkKing(arrayOfPiece, saveCounter, realChessMove, ref numberOfPiece))
                        {
                            Behavior(ref arrayOfPiece, saveCounter, realChessMove, numberOfPiece, ref game, false); //King
                            userWalk = false;
                        }
                        else
                        {
                            Console.SetCursorPosition(0, 4);
                            Console.WriteLine("Данных ход невозможен, попробуйте другой.");
                            realChessMove = "";
                            userWalk = true;
                        }
                    }
                }

                while (!comWalk)
                {
                    comWalk = ComputerWalk(ref arrayOfPiece, ref saveCounter, ref realChessMove, ref game, ref numberOfPiece);
                }
            }
        }

        static string ChangeUserStr(ref string chessMove, ref string realChessMove, PropertiesChessPiece[] arrayOfPiece, ref int saveCounter, bool comp)
        {
            if (!comp)
            {
            linkOne:

                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Ваша начальная позиция - это фигуры, находящиеся снизу.");
                Console.WriteLine("Введите ход в формате - начальная позиция конечная позиция (A2A4, регистр букв не важен) - для хода.");

                Console.SetCursorPosition(0, 3);
                chessMove = Console.ReadLine();
                chessMove = chessMove.Trim();
                chessMove = chessMove.ToUpper();

                if (chessMove.Length == 4 && chessMove[0] >= 'A' && chessMove[0] <= 'H' && chessMove[2] >= 'A' && chessMove[2] <= 'H' && chessMove[1] >= '1' && chessMove[1] <= '8' && chessMove[3] >= '1' && chessMove[3] <= '8')
                {
                    Console.SetCursorPosition(0, 3);
                    Console.WriteLine("                                                                                                      ");
                    Console.SetCursorPosition(0, 4);
                    Console.WriteLine("                                                                                                      ");
                }
                else
                {
                    Console.WriteLine("Данные для хода введены некоректно, введите заного.");

                    Console.SetCursorPosition(0, 3);
                    Console.WriteLine("                                                                                                 ");

                    goto linkOne;
                }
            }

            switch (chessMove[0])
            {
                case 'A':
                    realChessMove += 21;
                    realChessMove += 18 - Convert.ToInt32(Convert.ToString(chessMove[1])) + 1;
                    break;
                case 'B':
                    realChessMove += 22;
                    realChessMove += 18 - Convert.ToInt32(Convert.ToString(chessMove[1])) + 1;
                    break;
                case 'C':
                    realChessMove += 23;
                    realChessMove += 18 - Convert.ToInt32(Convert.ToString(chessMove[1])) + 1;
                    break;
                case 'D':
                    realChessMove += 24;
                    realChessMove += 18 - Convert.ToInt32(Convert.ToString(chessMove[1])) + 1;
                    break;
                case 'E':
                    realChessMove += 25;
                    realChessMove += 18 - Convert.ToInt32(Convert.ToString(chessMove[1])) + 1;
                    break;
                case 'F':
                    realChessMove += 26;
                    realChessMove += 18 - Convert.ToInt32(Convert.ToString(chessMove[1])) + 1;
                    break;
                case 'G':
                    realChessMove += 27;
                    realChessMove += 18 - Convert.ToInt32(Convert.ToString(chessMove[1])) + 1;
                    break;
                case 'H':
                    realChessMove += 28;
                    realChessMove += 18 - Convert.ToInt32(Convert.ToString(chessMove[1])) + 1;
                    break;
            }

            switch (chessMove[2])
            {
                case 'A':
                    realChessMove += 21;
                    realChessMove += 18 - Convert.ToInt32(Convert.ToString(chessMove[3])) + 1;
                    break;
                case 'B':
                    realChessMove += 22;
                    realChessMove += 18 - Convert.ToInt32(Convert.ToString(chessMove[3])) + 1;
                    break;
                case 'C':
                    realChessMove += 23;
                    realChessMove += 18 - Convert.ToInt32(Convert.ToString(chessMove[3])) + 1;
                    break;
                case 'D':
                    realChessMove += 24;
                    realChessMove += 18 - Convert.ToInt32(Convert.ToString(chessMove[3])) + 1;
                    break;
                case 'E':
                    realChessMove += 25;
                    realChessMove += 18 - Convert.ToInt32(Convert.ToString(chessMove[3])) + 1;
                    break;
                case 'F':
                    realChessMove += 26;
                    realChessMove += 18 - Convert.ToInt32(Convert.ToString(chessMove[3])) + 1;
                    break;
                case 'G':
                    realChessMove += 27;
                    realChessMove += 18 - Convert.ToInt32(Convert.ToString(chessMove[3])) + 1;
                    break;
                case 'H':
                    realChessMove += 28;
                    realChessMove += 18 - Convert.ToInt32(Convert.ToString(chessMove[3])) + 1;
                    break;
            }


            for (var i = 0; i < 16; i++)
            {
                if (arrayOfPiece[i].positionX == Convert.ToInt32(Convert.ToString(realChessMove[0]) + Convert.ToString(realChessMove[1])) && arrayOfPiece[i].positionY == Convert.ToInt32(Convert.ToString(realChessMove[2]) + Convert.ToString(realChessMove[3])))
                {
                    realChessMove += "1";
                    saveCounter = i;
                    break;
                }
            }

            realChessMove += " ";

            return realChessMove;
        }
        static bool CheckWalkPawn(PropertiesChessPiece[] arrayOfPiece, int saveCounter, string realChessMove, ref int numberOfPiece)
        {
            int
                xFuture = Convert.ToInt32(Convert.ToString(realChessMove[4]) + Convert.ToString(realChessMove[5])),
                yFuture = Convert.ToInt32(Convert.ToString(realChessMove[6]) + Convert.ToString(realChessMove[7]));     

            if (arrayOfPiece[saveCounter].positionY - yFuture == 1)
            {
                if (Math.Abs(arrayOfPiece[saveCounter].positionX - xFuture) == 1)
                {
                    for (var i = 16; i < 32; i++)
                    {
                        if (i == saveCounter) i++;

                        if (arrayOfPiece[i].positionX == xFuture && arrayOfPiece[i].positionY == yFuture)
                        {// Pawn attack
                            numberOfPiece = i;
                            return true;
                        }
                    }
                    return false;
                }

                for (var i = 0; i < 32; i++)
                {
                    if (i == saveCounter) i++;

                    if (arrayOfPiece[i].positionX == xFuture && arrayOfPiece[i].positionY == yFuture)
                    {
                        return false;
                    }
                }

                return true;
            }
            else if (arrayOfPiece[saveCounter].positionY - yFuture == -1 && realChessMove[realChessMove.Length - 1] == '2')
            {
                if (Math.Abs(arrayOfPiece[saveCounter].positionX - xFuture) == 1)
                {
                    for (var i = 0; i < 16; i++)
                    {
                        if (i == saveCounter) i++;

                        if (arrayOfPiece[i].positionX == xFuture && arrayOfPiece[i].positionY == yFuture)
                        {// Pawn attack
                            numberOfPiece = i;
                            return true;
                        }
                    }
                    return false;
                }

                for (var i = 0; i < 32; i++)
                {
                    if (i == saveCounter) i++;

                    if (arrayOfPiece[i].positionX == xFuture && arrayOfPiece[i].positionY == yFuture)
                    {
                        return false;
                    }
                }

                return true;
            }
            else if (arrayOfPiece[saveCounter].positionY == 17 && arrayOfPiece[saveCounter].positionY - yFuture == 2 && arrayOfPiece[saveCounter].positionX == xFuture)
            {
                for (var i = 0; i < 32; i++)
                {
                    if (i == saveCounter) i++;

                    if (arrayOfPiece[i].positionX == xFuture && (arrayOfPiece[i].positionY == yFuture || arrayOfPiece[i].positionY == yFuture - 1))
                    {
                        return false;
                    }
                }
                return true;
            }
            else if (arrayOfPiece[saveCounter].positionY == 12 && arrayOfPiece[saveCounter].positionY - yFuture == -2 && arrayOfPiece[saveCounter].positionX == xFuture && realChessMove[realChessMove.Length - 1] == '2')
            {
                for (var i = 0; i < 32; i++)
                {
                    if (i == saveCounter) i++;

                    if (arrayOfPiece[i].positionX == xFuture && (arrayOfPiece[i].positionY == yFuture || arrayOfPiece[i].positionY == yFuture - 1))
                    {
                        return false;
                    }
                }
                return true;
            }

            return false;
        }
        static bool CheckWalkRook(PropertiesChessPiece[] arrayOfPiece, int saveCounter, string realChessMove, ref int numberOfPiece)
        {
            int
                xFuture = Convert.ToInt32(Convert.ToString(realChessMove[4]) + Convert.ToString(realChessMove[5])),
                yFuture = Convert.ToInt32(Convert.ToString(realChessMove[6]) + Convert.ToString(realChessMove[7]));

            if (arrayOfPiece[saveCounter].positionX != xFuture && arrayOfPiece[saveCounter].positionY == yFuture)
            {
                for (var i = 1; i <= Math.Abs(arrayOfPiece[saveCounter].positionX - xFuture); i++)
                {
                    for (var j = 0; j < 32; j++)
                    {
                        if (j == saveCounter) j++;

                        if (realChessMove[realChessMove.Length - 1] == '2')
                        {
                            if (arrayOfPiece[j].positionX == arrayOfPiece[saveCounter].positionX + i && arrayOfPiece[j].positionY == arrayOfPiece[saveCounter].positionY && arrayOfPiece[saveCounter].positionX - xFuture < 0)
                            {
                                if (j >= 1 && j <= 15)
                                {
                                    numberOfPiece = j;
                                    return true;
                                }
                                else return false;
                            }
                            else if (arrayOfPiece[j].positionX == arrayOfPiece[saveCounter].positionX - i && arrayOfPiece[j].positionY == arrayOfPiece[saveCounter].positionY && arrayOfPiece[saveCounter].positionX - xFuture > 0)
                            {
                                if (j >= 1 && j <= 15)
                                {
                                    numberOfPiece = j;
                                    return true;
                                }
                                else return false;
                            }
                        }
                        else
                        {
                            if (realChessMove[realChessMove.Length - 1] == '2')
                            {
                                if (arrayOfPiece[j].positionX == arrayOfPiece[saveCounter].positionX + i && arrayOfPiece[j].positionY == arrayOfPiece[saveCounter].positionY && arrayOfPiece[saveCounter].positionX - xFuture < 0)
                                {
                                    if (j >= 1 && j <= 15)
                                    {
                                        numberOfPiece = j;
                                        return true;
                                    }
                                    else return false;
                                }
                                else if (arrayOfPiece[j].positionX == arrayOfPiece[saveCounter].positionX - i && arrayOfPiece[j].positionY == arrayOfPiece[saveCounter].positionY && arrayOfPiece[saveCounter].positionX - xFuture > 0)
                                {
                                    if (j >= 1 && j <= 15)
                                    {
                                        numberOfPiece = j;
                                        return true;
                                    }
                                    else return false;
                                }
                            }
                            else
                            {
                                if (arrayOfPiece[j].positionX == arrayOfPiece[saveCounter].positionX + i && arrayOfPiece[j].positionY == arrayOfPiece[saveCounter].positionY && arrayOfPiece[saveCounter].positionX - xFuture < 0)
                                {
                                    if (j >= 16 && j <= 31)
                                    {
                                        numberOfPiece = j;
                                        return true;
                                    }
                                    else return false;
                                }
                                else if (arrayOfPiece[j].positionX == arrayOfPiece[saveCounter].positionX - i && arrayOfPiece[j].positionY == arrayOfPiece[saveCounter].positionY && arrayOfPiece[saveCounter].positionX - xFuture > 0)
                                {
                                    if (j >= 16 && j <= 31)
                                    {
                                        numberOfPiece = j;
                                        return true;
                                    }
                                    else return false;
                                }
                            }                           
                        }                 
                    }
                }
                return true;
            }
            else if (arrayOfPiece[saveCounter].positionX == xFuture && arrayOfPiece[saveCounter].positionY != yFuture)
            {
                for (var i = 1; i <= Math.Abs(arrayOfPiece[saveCounter].positionY - yFuture); i++)
                {
                    for (var j = 0; j < 32; j++)
                    {
                        if (j == saveCounter) j++;

                        if (realChessMove[realChessMove.Length - 1] == '2')
                        {
                            if (arrayOfPiece[saveCounter].positionY - yFuture < 0 && arrayOfPiece[j].positionX == arrayOfPiece[saveCounter].positionX && arrayOfPiece[j].positionY == arrayOfPiece[saveCounter].positionY + i)
                            {
                                if (j >= 1 && j <= 15)
                                {
                                    numberOfPiece = j;
                                    return true;
                                }
                                else return false;
                            }
                            else if (arrayOfPiece[saveCounter].positionY - yFuture > 0 && arrayOfPiece[j].positionX == arrayOfPiece[saveCounter].positionX && arrayOfPiece[j].positionY == arrayOfPiece[saveCounter].positionY - i)
                            {
                                if (j >= 1 && j <= 15)
                                {
                                    numberOfPiece = j;
                                    return true;
                                }
                                else return false;
                            }
                        }
                        else
                        {
                            if (arrayOfPiece[saveCounter].positionY - yFuture < 0 && arrayOfPiece[j].positionX == arrayOfPiece[saveCounter].positionX && arrayOfPiece[j].positionY == arrayOfPiece[saveCounter].positionY + i)
                            {
                                if (j >= 16 && j <= 31)
                                {
                                    numberOfPiece = j;
                                    return true;
                                }
                                else return false;
                            }
                            else if (arrayOfPiece[saveCounter].positionY - yFuture > 0 && arrayOfPiece[j].positionX == arrayOfPiece[saveCounter].positionX && arrayOfPiece[j].positionY == arrayOfPiece[saveCounter].positionY - i)
                            {
                                if (j >= 16 && j <= 31)
                                {
                                    numberOfPiece = j;
                                    return true;
                                }
                                else return false;
                            }
                        }
                        
                    }
                }
                return true;
            }

            return false;
        }
        static bool CheckWalkKnight(PropertiesChessPiece[] arrayOfPiece, int saveCounter, string realChessMove, ref int numberOfPiece)
        {
            int
               xFuture = Convert.ToInt32(Convert.ToString(realChessMove[4]) + Convert.ToString(realChessMove[5])),
               yFuture = Convert.ToInt32(Convert.ToString(realChessMove[6]) + Convert.ToString(realChessMove[7]));

            if (Math.Abs(arrayOfPiece[saveCounter].positionX - xFuture) == Math.Abs(arrayOfPiece[saveCounter].positionY - yFuture) && arrayOfPiece[saveCounter].positionY != yFuture)
            {
                for (var i = 1; i <= Math.Abs(arrayOfPiece[saveCounter].positionX - xFuture); i++)
                {
                    for (var j = 0; j < 32; j++)
                    {
                        if (j == saveCounter) j++;

                        if (realChessMove[realChessMove.Length - 1] == '2')
                        {
                            if (arrayOfPiece[saveCounter].positionX - xFuture > arrayOfPiece[saveCounter].positionY - yFuture)
                            {
                                if (arrayOfPiece[j].positionX == arrayOfPiece[saveCounter].positionX - i && arrayOfPiece[j].positionY == arrayOfPiece[saveCounter].positionY + i)
                                {
                                    if (j >= 1 && j <= 15)
                                    {
                                        numberOfPiece = j;
                                        return true;
                                    }
                                    else return false;
                                }
                            }
                            else if (arrayOfPiece[saveCounter].positionX - xFuture < arrayOfPiece[saveCounter].positionY - yFuture)
                            {
                                if (arrayOfPiece[j].positionX == arrayOfPiece[saveCounter].positionX + i && arrayOfPiece[j].positionY == arrayOfPiece[saveCounter].positionY - i)
                                {
                                    if (j >= 1 && j <= 15)
                                    {
                                        numberOfPiece = j;
                                        return true;
                                    }
                                    else return false;
                                }
                            }
                            else if (arrayOfPiece[j].positionX == arrayOfPiece[saveCounter].positionX + i && arrayOfPiece[j].positionY == arrayOfPiece[saveCounter].positionY + i)
                            {
                                if (j >= 1 && j <= 15)
                                {
                                    numberOfPiece = j;
                                    return true;
                                }
                                else return false;
                            }
                            else if (arrayOfPiece[j].positionX == arrayOfPiece[saveCounter].positionX - i && arrayOfPiece[j].positionY == arrayOfPiece[saveCounter].positionY - i)
                            {
                                if (j >= 1 && j <= 15)
                                {
                                    numberOfPiece = j;
                                    return true;
                                }
                                else return false;
                            }
                        }
                        else
                        {
                            if (arrayOfPiece[saveCounter].positionX - xFuture > arrayOfPiece[saveCounter].positionY - yFuture)
                            {
                                if (arrayOfPiece[j].positionX == arrayOfPiece[saveCounter].positionX - i && arrayOfPiece[j].positionY == arrayOfPiece[saveCounter].positionY + i)
                                {
                                    if (j >= 16 && j <= 31)
                                    {
                                        numberOfPiece = j;
                                        return true;
                                    }
                                    else return false;
                                }
                            }
                            else if (arrayOfPiece[saveCounter].positionX - xFuture < arrayOfPiece[saveCounter].positionY - yFuture)
                            {
                                if (arrayOfPiece[j].positionX == arrayOfPiece[saveCounter].positionX + i && arrayOfPiece[j].positionY == arrayOfPiece[saveCounter].positionY - i)
                                {
                                    if (j >= 16 && j <= 31)
                                    {
                                        numberOfPiece = j;
                                        return true;
                                    }
                                    else return false;
                                }
                            }
                            else if (arrayOfPiece[j].positionX == arrayOfPiece[saveCounter].positionX + i && arrayOfPiece[j].positionY == arrayOfPiece[saveCounter].positionY + i)
                            {
                                if (j >= 16 && j <= 31)
                                {
                                    numberOfPiece = j;
                                    return true;
                                }
                                else return false;
                            }
                            else if (arrayOfPiece[j].positionX == arrayOfPiece[saveCounter].positionX - i && arrayOfPiece[j].positionY == arrayOfPiece[saveCounter].positionY - i)
                            {
                                if (j >= 16 && j <= 31)
                                {
                                    numberOfPiece = j;
                                    return true;
                                }
                                else return false;
                            }
                        }
                        
                    }
                }
                return true;
            }

            return false;
        }
        static bool CheckWalkBishop(PropertiesChessPiece[] arrayOfPiece, int saveCounter, string realChessMove, ref int numberOfPiece)
        {
            int
               xFuture = Convert.ToInt32(Convert.ToString(realChessMove[4]) + Convert.ToString(realChessMove[5])),
               yFuture = Convert.ToInt32(Convert.ToString(realChessMove[6]) + Convert.ToString(realChessMove[7]));

            if (Math.Abs(xFuture - arrayOfPiece[saveCounter].positionX) == 1)
            {
                if (Math.Abs(yFuture - arrayOfPiece[saveCounter].positionY) == 2)
                {
                    for (var i = 0; i < 32; i++)
                    {
                        if (i == saveCounter) i++;

                        if (realChessMove[realChessMove.Length - 1] == '2')
                        {
                            if (arrayOfPiece[i].positionX == xFuture && arrayOfPiece[i].positionY == yFuture)
                            {
                                if (i >= 1 && i <= 15)
                                {
                                    numberOfPiece = i;
                                    return true;
                                }
                                else return false;
                            }
                        }
                        else
                        {
                            if (arrayOfPiece[i].positionX == xFuture && arrayOfPiece[i].positionY == yFuture)
                            {
                                if (i >= 16 && i <= 31)
                                {
                                    numberOfPiece = i;
                                    return true;
                                }
                                else return false;
                            }
                        }
                        
                    }
                    return true;
                }
            }
            else if (Math.Abs(xFuture - arrayOfPiece[saveCounter].positionX) == 2)
            {
                if (Math.Abs(yFuture - arrayOfPiece[saveCounter].positionY) == 1)
                {
                    for (var i = 0; i < 32; i++)
                    {
                        if (i == saveCounter) i++;

                        if (arrayOfPiece[i].positionX == xFuture && arrayOfPiece[i].positionY == yFuture)
                        {
                            if (i >= 16 && i <= 31)
                            {
                                numberOfPiece = i;
                                return true;
                            }
                            else return false;
                        }
                    }
                    return true;
                }
            }

            return false;
        }
        static bool CheckWalkKing(PropertiesChessPiece[] arrayOfPiece, int saveCounter, string realChessMove, ref int numberOfPiece)
        {
            int
               xFuture = Convert.ToInt32(Convert.ToString(realChessMove[4]) + Convert.ToString(realChessMove[5])),
               yFuture = Convert.ToInt32(Convert.ToString(realChessMove[6]) + Convert.ToString(realChessMove[7]));

            if (Math.Abs(arrayOfPiece[saveCounter].positionX - xFuture) == 1 && Math.Abs(arrayOfPiece[saveCounter].positionY - yFuture) == 1)
            {
                for (var i = 0; i < 32; i++)
                {
                    if (i == saveCounter) i++;

                    if (realChessMove[realChessMove.Length - 1] == '2')
                    {
                        if (arrayOfPiece[i].positionX == xFuture && arrayOfPiece[i].positionY == yFuture)
                        {
                            if (i >= 1 && i <= 15)
                            {
                                numberOfPiece = i;
                                return true;
                            }
                            else return false;
                        }
                    }
                    else
                    {
                        if (arrayOfPiece[i].positionX == xFuture && arrayOfPiece[i].positionY == yFuture)
                        {
                            if (i >= 16 && i <= 31)
                            {
                                numberOfPiece = i;
                                return true;
                            }
                            else return false;
                        }
                    }
                    
                }
                return true;
            }
            else if (Math.Abs(arrayOfPiece[saveCounter].positionX - xFuture) == 0 && Math.Abs(arrayOfPiece[saveCounter].positionY - yFuture) == 1)
            {
                for (var i = 0; i < 32; i++)
                {
                    if (i == saveCounter) i++;

                    if (realChessMove[realChessMove.Length - 1] == '2')
                    {
                        if (arrayOfPiece[i].positionX == xFuture && arrayOfPiece[i].positionY == yFuture)
                        {
                            if (i >= 1 && i <= 15)
                            {
                                numberOfPiece = i;
                                return true;
                            }
                            else return false;
                        }
                    }
                    else
                    {
                        if (arrayOfPiece[i].positionX == xFuture && arrayOfPiece[i].positionY == yFuture)
                        {
                            if (i >= 16 && i <= 31)
                            {
                                numberOfPiece = i;
                                return true;
                            }
                            else return false;
                        }
                    }
                    
                }
                return true;
            }
            else if (Math.Abs(arrayOfPiece[saveCounter].positionX - xFuture) == 1 && Math.Abs(arrayOfPiece[saveCounter].positionY - yFuture) == 0)

            {
                for (var i = 0; i < 32; i++)
                {
                    if (i == saveCounter) i++;

                    if (realChessMove[realChessMove.Length - 1] == '2')
                    {
                        if (arrayOfPiece[i].positionX == xFuture && arrayOfPiece[i].positionY == yFuture)
                        {
                            if (i >= 1 && i <= 15)
                            {
                                numberOfPiece = i;
                                return true;
                            }
                            else return false;
                        }
                    }
                    else
                    {
                        if (arrayOfPiece[i].positionX == xFuture && arrayOfPiece[i].positionY == yFuture)
                        {
                            if (i >= 16 && i <= 31)
                            {
                                numberOfPiece = i;
                                return true;
                            }
                            else return false;
                        }
                    }
                    
                }
                return true;
            }
            return false;
        }
        static void Behavior(ref PropertiesChessPiece[] arrayOfPiece, int saveCounter, string realChessMove, int numberOfPiece, ref bool game, bool comp)
        {
            int
                xFuture = Convert.ToInt32(Convert.ToString(realChessMove[4]) + Convert.ToString(realChessMove[5])),
                yFuture = Convert.ToInt32(Convert.ToString(realChessMove[6]) + Convert.ToString(realChessMove[7]));

            if (comp)
            {

            }

            if (numberOfPiece == -1)
            {
                Paint.Dot(arrayOfPiece[saveCounter].positionX, arrayOfPiece[saveCounter].positionY, " ");
                arrayOfPiece[saveCounter].positionX = xFuture;
                arrayOfPiece[saveCounter].positionY = yFuture;
                return;
            }
            else
            {
                if (numberOfPiece == 15)
                {
                    MessageBox.Show("Вы проиграли, в слудующий раз будьте внимательны!");
                    game = false;
                    return;
                }
                else if (numberOfPiece == 31)
                {
                    MessageBox.Show("Мои поздравления. Вы победили!");
                    game = false;
                    return;
                }

                Paint.Dot(arrayOfPiece[saveCounter].positionX, arrayOfPiece[saveCounter].positionY, " ");
                arrayOfPiece[saveCounter].positionX = arrayOfPiece[numberOfPiece].positionX;
                arrayOfPiece[saveCounter].positionY = arrayOfPiece[numberOfPiece].positionY;
                arrayOfPiece[numberOfPiece].positionX *= -1;
                arrayOfPiece[numberOfPiece].positionY *= -1;
                return;
            }
        }
        static void BehaviorPawn(ref PropertiesChessPiece[] arrayOfPiece, int saveCounter, string realChessMove, ref bool game, int numberOfPiece, bool comp)
        {
            int
                xFuture = Convert.ToInt32(Convert.ToString(realChessMove[4]) + Convert.ToString(realChessMove[5])),
                yFuture = Convert.ToInt32(Convert.ToString(realChessMove[6]) + Convert.ToString(realChessMove[7]));

            for (var i = 0; i < 32; i++)
            {
                if (i == saveCounter) i++;

                if (arrayOfPiece[i].positionX == xFuture && arrayOfPiece[i].positionY == yFuture)
                {// Pawn attack
                    if (i != 15)
                    {
                        if (numberOfPiece == 15)
                        {
                            MessageBox.Show("Вы проиграли, в слудующий раз будьте внимательны!");
                            game = false;
                            return;
                        }
                        else if (numberOfPiece == 31)
                        {
                            MessageBox.Show("Мои поздравления. Вы победили!");
                            game = false;
                            return;
                        }

                        Paint.Dot(arrayOfPiece[saveCounter].positionX, arrayOfPiece[saveCounter].positionY, " ");
                        arrayOfPiece[saveCounter].positionX = arrayOfPiece[i].positionX;
                        arrayOfPiece[saveCounter].positionY = arrayOfPiece[i].positionY;
                        arrayOfPiece[i].positionX *= -1;
                        arrayOfPiece[i].positionY *= -1;
                    }

                    return;
                }
            }
            Paint.Dot(arrayOfPiece[saveCounter].positionX, arrayOfPiece[saveCounter].positionY, " ");
            arrayOfPiece[saveCounter].positionX = xFuture;
            arrayOfPiece[saveCounter].positionY = yFuture;
        }

        static bool ComputerWalk(ref PropertiesChessPiece[] arrayOfPiece, ref int saveCounter, ref string realChessMove, ref bool game, ref int numberOfPiece)
        {
            Random rnd = new Random();

            #region            
            int rnd1 = 0, rnd2 = 0, saveRnd = 0;

            while (true)
            {
                rnd1 = rnd.Next(16, 32);
                rnd2 = rnd.Next(16, 32);

                if (rnd1 <= 31 && rnd1 >= 28)
                {
                    if (rnd.Next(0, 4) == rnd.Next(0, 4) && arrayOfPiece[rnd1].positionX > 0)
                    {
                        if (rnd1 == 31)
                        {
                            saveCounter = rnd1;

                            if (rnd.Next(0, 3) == 1)
                            {
                                realChessMove = Convert.ToString(arrayOfPiece[31].positionX);
                                realChessMove += arrayOfPiece[31].positionY;
                                realChessMove += arrayOfPiece[31].positionX + 1;

                                if (arrayOfPiece[31].positionX + 1 < 21 || arrayOfPiece[31].positionX + 1 > 28)
                                {
                                    return false;
                                }

                                if (rnd.Next(0, 3) == 1)
                                {
                                    if (arrayOfPiece[31].positionY + 1 < 11 || arrayOfPiece[31].positionY + 1 > 18)
                                    {
                                        return false;
                                    }

                                    realChessMove += arrayOfPiece[31].positionY + 1;

                                    if (CheckWalkKing(arrayOfPiece, saveCounter, realChessMove, ref numberOfPiece))
                                    {
                                        Behavior(ref arrayOfPiece, saveCounter, realChessMove, numberOfPiece, ref game, true);

                                        return true;
                                    }
                                    else return false;
                                }
                                else if (rnd.Next(0, 3) == 2)
                                {
                                    if (arrayOfPiece[31].positionY - 1 < 11 || arrayOfPiece[31].positionY - 1 > 18)
                                    {
                                        return false;
                                    }

                                    realChessMove += arrayOfPiece[31].positionY - 1;

                                    if (CheckWalkKing(arrayOfPiece, saveCounter, realChessMove, ref numberOfPiece))
                                    {
                                        Behavior(ref arrayOfPiece, saveCounter, realChessMove, numberOfPiece, ref game, true);

                                        return true;
                                    }
                                    else return false;
                                }
                                else
                                {
                                    realChessMove += arrayOfPiece[31].positionY;

                                    if (CheckWalkKing(arrayOfPiece, saveCounter, realChessMove, ref numberOfPiece))
                                    {
                                        Behavior(ref arrayOfPiece, saveCounter, realChessMove, numberOfPiece, ref game, true);

                                        return true;
                                    }
                                    else return false;
                                }
                            }
                            else if (rnd.Next(0, 3) == 2)
                            {
                                realChessMove = Convert.ToString(arrayOfPiece[31].positionX);
                                realChessMove += arrayOfPiece[31].positionY;
                                realChessMove += arrayOfPiece[31].positionX - 1;

                                if (arrayOfPiece[31].positionX - 1 < 11 || arrayOfPiece[31].positionX - 1 > 18)
                                {
                                    return false;
                                }

                                if (rnd.Next(0, 3) == 1)
                                {
                                    if (arrayOfPiece[31].positionY + 1 < 11 || arrayOfPiece[31].positionY + 1 > 18)
                                    {
                                        return false;
                                    }

                                    realChessMove += arrayOfPiece[31].positionY + 1;
                                    realChessMove += 2;

                                    if (CheckWalkKing(arrayOfPiece, saveCounter, realChessMove, ref numberOfPiece))
                                    {
                                        Behavior(ref arrayOfPiece, saveCounter, realChessMove, numberOfPiece, ref game, true);

                                        return true;
                                    }
                                    else return false;
                                }
                                else if (rnd.Next(0, 3) == 2)
                                {
                                    if (arrayOfPiece[31].positionY - 1 < 11 || arrayOfPiece[31].positionY - 1 > 18)
                                    {
                                        return false;
                                    }

                                    realChessMove += arrayOfPiece[31].positionY - 1;
                                    realChessMove += 2;

                                    if (CheckWalkKing(arrayOfPiece, saveCounter, realChessMove, ref numberOfPiece))
                                    {
                                        Behavior(ref arrayOfPiece, saveCounter, realChessMove, numberOfPiece, ref game, true);

                                        return true;
                                    }
                                    else return false;
                                }
                                else
                                {
                                    if (arrayOfPiece[31].positionY - 1 < 11 || arrayOfPiece[31].positionY - 1 > 18)
                                    {
                                        return false;
                                    }
                                    realChessMove += arrayOfPiece[31].positionY;
                                    realChessMove += 2;

                                    if (CheckWalkKing(arrayOfPiece, saveCounter, realChessMove, ref numberOfPiece))
                                    {
                                        Behavior(ref arrayOfPiece, saveCounter, realChessMove, numberOfPiece, ref game, true);

                                        return true;
                                    }
                                    else return false;
                                }
                            }
                            else if (rnd.Next(0, 3) == 0)
                            {
                                realChessMove = Convert.ToString(arrayOfPiece[31].positionX);
                                realChessMove += arrayOfPiece[31].positionY;
                                realChessMove += arrayOfPiece[31].positionX;

                                if (rnd.Next(0, 2) == 1)
                                {
                                    if (arrayOfPiece[31].positionY + 1 < 11 || arrayOfPiece[31].positionY + 1 > 18)
                                    {
                                        return false;
                                    }

                                    realChessMove += arrayOfPiece[31].positionY + 1;
                                    realChessMove += 2;

                                    if (CheckWalkKing(arrayOfPiece, saveCounter, realChessMove, ref numberOfPiece))
                                    {
                                        Behavior(ref arrayOfPiece, saveCounter, realChessMove, numberOfPiece, ref game, true);

                                        return true;
                                    }
                                    else return false;
                                }
                                else
                                {
                                    if (arrayOfPiece[31].positionY - 1 < 11 || arrayOfPiece[31].positionY - 1 > 18)
                                    {
                                        return false;
                                    }

                                    realChessMove += arrayOfPiece[31].positionY - 1;
                                    realChessMove += 2;

                                    if (CheckWalkKing(arrayOfPiece, saveCounter, realChessMove, ref numberOfPiece))
                                    {
                                        Behavior(ref arrayOfPiece, saveCounter, realChessMove, numberOfPiece, ref game, true);

                                        return true;
                                    }
                                    else return false;
                                }
                            }
                        }
                        else if (rnd1 == 30)
                        {
                            saveCounter = rnd1;

                            if (rnd.Next(0, 8) == 0)
                            {
                                realChessMove = Convert.ToString(arrayOfPiece[saveCounter].positionX);
                                realChessMove += arrayOfPiece[saveCounter].positionY;
                                saveRnd = rnd.Next(1, 8);
                                realChessMove += arrayOfPiece[saveCounter].positionX + saveRnd;
                                realChessMove += arrayOfPiece[saveCounter].positionY + saveRnd;

                                if (arrayOfPiece[saveCounter].positionY + saveRnd < 11 || arrayOfPiece[saveCounter].positionY + saveRnd > 18 || arrayOfPiece[saveCounter].positionX + saveRnd < 21 || arrayOfPiece[saveCounter].positionX + saveRnd > 28)
                                {
                                    return false;
                                }
                                realChessMove += 2;

                                if (CheckWalkKnight(arrayOfPiece, saveCounter, realChessMove, ref numberOfPiece))
                                {
                                    Behavior(ref arrayOfPiece, saveCounter, realChessMove, numberOfPiece, ref game, true);
                                    return true;
                                }
                                else return false;
                            }
                            else if (rnd.Next(0, 8) == 1)
                            {
                                realChessMove = Convert.ToString(arrayOfPiece[saveCounter].positionX);
                                realChessMove += arrayOfPiece[saveCounter].positionY;
                                saveRnd = rnd.Next(1, 8);
                                realChessMove += arrayOfPiece[saveCounter].positionX - saveRnd;
                                realChessMove += arrayOfPiece[saveCounter].positionY + saveRnd;

                                if (arrayOfPiece[saveCounter].positionY + saveRnd < 11 || arrayOfPiece[saveCounter].positionY + saveRnd > 18 || arrayOfPiece[saveCounter].positionX - saveRnd < 21 || arrayOfPiece[saveCounter].positionX - saveRnd > 28)
                                {
                                    return false;
                                }
                                realChessMove += 2;

                                if (CheckWalkKnight(arrayOfPiece, saveCounter, realChessMove, ref numberOfPiece))
                                {
                                    Behavior(ref arrayOfPiece, saveCounter, realChessMove, numberOfPiece, ref game, true);
                                    return true;
                                }
                                else return false;
                            }
                            else if (rnd.Next(0, 8) == 2)
                            {
                                realChessMove = Convert.ToString(arrayOfPiece[saveCounter].positionX);
                                realChessMove += arrayOfPiece[saveCounter].positionY;
                                saveRnd = rnd.Next(1, 8);
                                realChessMove += arrayOfPiece[saveCounter].positionX + saveRnd;
                                realChessMove += arrayOfPiece[saveCounter].positionY - saveRnd;

                                if (arrayOfPiece[saveCounter].positionY - saveRnd < 11 || arrayOfPiece[saveCounter].positionY - saveRnd > 18 || arrayOfPiece[saveCounter].positionX + saveRnd < 21 || arrayOfPiece[saveCounter].positionX + saveRnd > 28)
                                {
                                    return false;
                                }
                                realChessMove += 2;

                                if (CheckWalkKnight(arrayOfPiece, saveCounter, realChessMove, ref numberOfPiece))
                                {
                                    Behavior(ref arrayOfPiece, saveCounter, realChessMove, numberOfPiece, ref game, true);
                                    return true;
                                }
                                else return false;
                            }
                            else if (rnd.Next(0, 8) == 3)
                            {
                                realChessMove = Convert.ToString(arrayOfPiece[saveCounter].positionX);
                                realChessMove += arrayOfPiece[saveCounter].positionY;
                                saveRnd = rnd.Next(1, 8);
                                realChessMove += arrayOfPiece[saveCounter].positionX - saveRnd;
                                realChessMove += arrayOfPiece[saveCounter].positionY - saveRnd;

                                if (arrayOfPiece[saveCounter].positionY - saveRnd < 11 || arrayOfPiece[saveCounter].positionY - saveRnd > 18 || arrayOfPiece[saveCounter].positionX - saveRnd < 21 || arrayOfPiece[saveCounter].positionX - saveRnd > 28)
                                {
                                    return false;
                                }
                                realChessMove += 2;

                                if (CheckWalkKnight(arrayOfPiece, saveCounter, realChessMove, ref numberOfPiece))
                                {
                                    Behavior(ref arrayOfPiece, saveCounter, realChessMove, numberOfPiece, ref game, true);
                                    return true;
                                }
                                else return false;
                            }
                            else if (rnd.Next(0, 8) == 4)
                            {
                                realChessMove = Convert.ToString(arrayOfPiece[saveCounter].positionX);
                                realChessMove += arrayOfPiece[saveCounter].positionY;
                                realChessMove += arrayOfPiece[saveCounter].positionX;
                                saveRnd = rnd.Next(1, 8);
                                realChessMove += arrayOfPiece[saveCounter].positionY - saveRnd;

                                if (arrayOfPiece[saveCounter].positionY - saveRnd < 11 || arrayOfPiece[saveCounter].positionY - saveRnd > 18)
                                {
                                    return false;
                                }
                                realChessMove += 2;

                                if (CheckWalkRook(arrayOfPiece, saveCounter, realChessMove, ref numberOfPiece))
                                {
                                    Behavior(ref arrayOfPiece, saveCounter, realChessMove, numberOfPiece, ref game, true);
                                    return true;
                                }
                                else return false;
                            }
                            else if (rnd.Next(0, 8) == 5)
                            {
                                realChessMove = Convert.ToString(arrayOfPiece[saveCounter].positionX);
                                realChessMove += arrayOfPiece[saveCounter].positionY;
                                realChessMove += arrayOfPiece[saveCounter].positionX;
                                saveRnd = rnd.Next(1, 8);
                                realChessMove += arrayOfPiece[saveCounter].positionY + saveRnd;

                                if (arrayOfPiece[saveCounter].positionY + saveRnd < 11 || arrayOfPiece[saveCounter].positionY + saveRnd > 18)
                                {
                                    return false;
                                }
                                realChessMove += 2;

                                if (CheckWalkRook(arrayOfPiece, saveCounter, realChessMove, ref numberOfPiece))
                                {
                                    Behavior(ref arrayOfPiece, saveCounter, realChessMove, numberOfPiece, ref game, true);
                                    return true;
                                }
                                else return false;
                            }
                            else if (rnd.Next(0, 8) == 6)
                            {
                                realChessMove = Convert.ToString(arrayOfPiece[saveCounter].positionX);
                                realChessMove += arrayOfPiece[saveCounter].positionY;
                                saveRnd = rnd.Next(1, 8);
                                realChessMove += arrayOfPiece[saveCounter].positionX - saveRnd;
                                realChessMove += arrayOfPiece[saveCounter].positionY;

                                if (arrayOfPiece[saveCounter].positionX - saveRnd < 21 || arrayOfPiece[saveCounter].positionX - saveRnd > 28)
                                {
                                    return false;
                                }
                                realChessMove += 2;

                                if (CheckWalkRook(arrayOfPiece, saveCounter, realChessMove, ref numberOfPiece))
                                {
                                    Behavior(ref arrayOfPiece, saveCounter, realChessMove, numberOfPiece, ref game, true);
                                    return true;
                                }
                                else return false;
                            }
                            else if (rnd.Next(0, 8) == 7)
                            {
                                realChessMove = Convert.ToString(arrayOfPiece[saveCounter].positionX);
                                realChessMove += arrayOfPiece[saveCounter].positionY;
                                saveRnd = rnd.Next(1, 8);
                                realChessMove += arrayOfPiece[saveCounter].positionX + rnd.Next(1, 8);
                                realChessMove += arrayOfPiece[saveCounter].positionY;

                                if (arrayOfPiece[saveCounter].positionX + saveRnd < 21 || arrayOfPiece[saveCounter].positionX + saveRnd > 28)
                                {
                                    return false;
                                }
                                realChessMove += 2;

                                if (CheckWalkRook(arrayOfPiece, saveCounter, realChessMove, ref numberOfPiece))
                                {
                                    Behavior(ref arrayOfPiece, saveCounter, realChessMove, numberOfPiece, ref game, true);
                                    return true;
                                }
                                else return false;
                            }
                        }
                        else if (rnd1 == 29 || rnd1 == 28)
                        {
                            saveCounter = rnd1;

                            if (rnd.Next(0, 4) == 0)
                            {
                                realChessMove = Convert.ToString(arrayOfPiece[saveCounter].positionX);
                                realChessMove += arrayOfPiece[saveCounter].positionY;
                                saveRnd = rnd.Next(1, 8);
                                realChessMove += arrayOfPiece[saveCounter].positionX + saveRnd;
                                realChessMove += arrayOfPiece[saveCounter].positionY + saveRnd;

                                if (arrayOfPiece[saveCounter].positionY + saveRnd < 11 || arrayOfPiece[saveCounter].positionY + saveRnd > 18 || arrayOfPiece[saveCounter].positionX + saveRnd < 21 || arrayOfPiece[saveCounter].positionX + saveRnd > 28)
                                {
                                    return false;
                                }
                                realChessMove += 2;

                                if (CheckWalkKnight(arrayOfPiece, saveCounter, realChessMove, ref numberOfPiece))
                                {
                                    Behavior(ref arrayOfPiece, saveCounter, realChessMove, numberOfPiece, ref game, true);
                                    return true;
                                }
                                else return false;
                            }
                            else if (rnd.Next(0, 4) == 1)
                            {
                                realChessMove = Convert.ToString(arrayOfPiece[saveCounter].positionX);
                                realChessMove += arrayOfPiece[saveCounter].positionY;
                                saveRnd = rnd.Next(1, 8);
                                realChessMove += arrayOfPiece[saveCounter].positionX - saveRnd;
                                realChessMove += arrayOfPiece[saveCounter].positionY + saveRnd;

                                if (arrayOfPiece[saveCounter].positionY + saveRnd < 11 || arrayOfPiece[saveCounter].positionY + saveRnd > 18 || arrayOfPiece[saveCounter].positionX - saveRnd < 21 || arrayOfPiece[saveCounter].positionX - saveRnd > 28)
                                {
                                    return false;
                                }
                                realChessMove += 2;

                                if (CheckWalkKnight(arrayOfPiece, saveCounter, realChessMove, ref numberOfPiece))
                                {
                                    Behavior(ref arrayOfPiece, saveCounter, realChessMove, numberOfPiece, ref game, true);
                                    return true;
                                }
                                else return false;
                            }
                            else if (rnd.Next(0, 4) == 2)
                            {
                                realChessMove = Convert.ToString(arrayOfPiece[saveCounter].positionX);
                                realChessMove += arrayOfPiece[saveCounter].positionY;
                                saveRnd = rnd.Next(1, 8);
                                realChessMove += arrayOfPiece[saveCounter].positionX + saveRnd;
                                realChessMove += arrayOfPiece[saveCounter].positionY - saveRnd;

                                if (arrayOfPiece[saveCounter].positionY - saveRnd < 11 || arrayOfPiece[saveCounter].positionY - saveRnd > 18 || arrayOfPiece[saveCounter].positionX + saveRnd < 21 || arrayOfPiece[saveCounter].positionX + saveRnd > 28)
                                {
                                    return false;
                                }
                                realChessMove += 2;

                                if (CheckWalkKnight(arrayOfPiece, saveCounter, realChessMove, ref numberOfPiece))
                                {
                                    Behavior(ref arrayOfPiece, saveCounter, realChessMove, numberOfPiece, ref game, true);
                                    return true;
                                }
                                else return false;
                            }
                            else if (rnd.Next(0, 4) == 3)
                            {
                                realChessMove = Convert.ToString(arrayOfPiece[saveCounter].positionX);
                                realChessMove += arrayOfPiece[saveCounter].positionY;
                                saveRnd = rnd.Next(1, 8);
                                realChessMove += arrayOfPiece[saveCounter].positionX - saveRnd;
                                realChessMove += arrayOfPiece[saveCounter].positionY - saveRnd;

                                if (arrayOfPiece[saveCounter].positionY - saveRnd < 11 || arrayOfPiece[saveCounter].positionY - saveRnd > 18 || arrayOfPiece[saveCounter].positionX - saveRnd < 21 || arrayOfPiece[saveCounter].positionX - saveRnd > 28)
                                {
                                    return false;
                                }
                                realChessMove += 2;

                                if (CheckWalkKnight(arrayOfPiece, saveCounter, realChessMove, ref numberOfPiece))
                                {
                                    Behavior(ref arrayOfPiece, saveCounter, realChessMove, numberOfPiece, ref game, true);
                                    return true;
                                }
                                else return false;
                            }
                        }
                    }
                }
                else
                {
                    if (rnd1 >= 16 && rnd1 <= 23)
                    {
                        saveCounter = rnd1;

                        if (rnd.Next(0, 3) == 0)
                        {
                            if (arrayOfPiece[saveCounter].positionY == 12)
                            {
                                realChessMove = Convert.ToString(arrayOfPiece[saveCounter].positionX);
                                realChessMove += arrayOfPiece[saveCounter].positionY;
                                realChessMove += arrayOfPiece[saveCounter].positionX;
                                realChessMove += arrayOfPiece[saveCounter].positionY + 2;

                                if (arrayOfPiece[saveCounter].positionY + 2 < 11 || arrayOfPiece[saveCounter].positionY + 2 > 18)
                                {
                                    return false;
                                }
                                realChessMove += 2;

                                if (CheckWalkPawn(arrayOfPiece, saveCounter, realChessMove, ref numberOfPiece))
                                {
                                    BehaviorPawn(ref arrayOfPiece, saveCounter, realChessMove, ref game, numberOfPiece, true);
                                    return true;
                                }
                                else return false;
                            }
                            else
                            {
                                realChessMove = Convert.ToString(arrayOfPiece[saveCounter].positionX);
                                realChessMove += arrayOfPiece[saveCounter].positionY;
                                realChessMove += arrayOfPiece[saveCounter].positionX;
                                realChessMove += arrayOfPiece[saveCounter].positionY + 1;

                                if (arrayOfPiece[saveCounter].positionY + 1 < 11 || arrayOfPiece[saveCounter].positionY + 1 > 18)
                                {
                                    return false;
                                }
                                realChessMove += 2;

                                if (CheckWalkPawn(arrayOfPiece, saveCounter, realChessMove, ref numberOfPiece))
                                {
                                    BehaviorPawn(ref arrayOfPiece, saveCounter, realChessMove, ref game, numberOfPiece, true);
                                    return true;
                                }
                                else return false;
                            }
                        }
                        else if (rnd.Next(0, 3) == 1)
                        {
                            realChessMove = Convert.ToString(arrayOfPiece[saveCounter].positionX);
                            realChessMove += arrayOfPiece[saveCounter].positionY;
                            realChessMove += arrayOfPiece[saveCounter].positionX - 1;
                            realChessMove += arrayOfPiece[saveCounter].positionY + 1;

                            if (arrayOfPiece[saveCounter].positionY + 1 < 11 || arrayOfPiece[saveCounter].positionY + 1 > 18 || arrayOfPiece[saveCounter].positionX - 1 < 21 || arrayOfPiece[saveCounter].positionX - 1 > 28)
                            {
                                return false;
                            }
                            realChessMove += 2;

                            if (CheckWalkPawn(arrayOfPiece, saveCounter, realChessMove, ref numberOfPiece))
                            {
                                BehaviorPawn(ref arrayOfPiece, saveCounter, realChessMove, ref game, numberOfPiece, true);
                                return true;
                            }
                            else return false;
                        }
                        else if (rnd.Next(0, 3) == 2)
                        {
                            realChessMove = Convert.ToString(arrayOfPiece[saveCounter].positionX);
                            realChessMove += arrayOfPiece[saveCounter].positionY;
                            realChessMove += arrayOfPiece[saveCounter].positionX + 1;
                            realChessMove += arrayOfPiece[saveCounter].positionY + 1;

                            if (arrayOfPiece[saveCounter].positionY + 1 < 11 || arrayOfPiece[saveCounter].positionY + 1 > 18 || arrayOfPiece[saveCounter].positionX + 1 < 21 || arrayOfPiece[saveCounter].positionX + 1 > 28)
                            {
                                return false;
                            }
                            realChessMove += 2;

                            if (CheckWalkPawn(arrayOfPiece, saveCounter, realChessMove, ref numberOfPiece))
                            {
                                BehaviorPawn(ref arrayOfPiece, saveCounter, realChessMove, ref game, numberOfPiece, true);
                                return true;
                            }
                            else return false;
                        }
                    }
                    else if (rnd1 == 24 || rnd1 == 25)
                    {
                        saveCounter = rnd1;

                        if (rnd.Next(0, 4) == 0)
                        {
                            realChessMove = Convert.ToString(arrayOfPiece[saveCounter].positionX);
                            realChessMove += arrayOfPiece[saveCounter].positionY;
                            realChessMove += arrayOfPiece[saveCounter].positionX;
                            saveRnd = rnd.Next(1, 8);
                            realChessMove += arrayOfPiece[saveCounter].positionY - saveRnd;

                            if (arrayOfPiece[saveCounter].positionY - saveRnd < 11 || arrayOfPiece[saveCounter].positionY - saveRnd > 18)
                            {
                                return false;
                            }

                            realChessMove += 2;

                            if (CheckWalkRook(arrayOfPiece, saveCounter, realChessMove, ref numberOfPiece))
                            {
                                Behavior(ref arrayOfPiece, saveCounter, realChessMove, numberOfPiece, ref game, true);
                                return true;
                            }
                            else return false;
                        }
                        else if (rnd.Next(0, 4) == 1)
                        {
                            realChessMove = Convert.ToString(arrayOfPiece[saveCounter].positionX);
                            realChessMove += arrayOfPiece[saveCounter].positionY;
                            realChessMove += arrayOfPiece[saveCounter].positionX;
                            saveRnd = rnd.Next(1, 8);
                            realChessMove += arrayOfPiece[saveCounter].positionY + saveRnd;

                            if (arrayOfPiece[saveCounter].positionY + saveRnd < 11 || arrayOfPiece[saveCounter].positionY + saveRnd > 18)
                            {
                                return false;
                            }

                            realChessMove += 2;

                            if (CheckWalkRook(arrayOfPiece, saveCounter, realChessMove, ref numberOfPiece))
                            {
                                Behavior(ref arrayOfPiece, saveCounter, realChessMove, numberOfPiece, ref game, true);
                                return true;
                            }
                            else return false;
                        }
                        else if (rnd.Next(0, 4) == 2)
                        {
                            realChessMove = Convert.ToString(arrayOfPiece[saveCounter].positionX);
                            realChessMove += arrayOfPiece[saveCounter].positionY;
                            saveRnd = rnd.Next(1, 8);
                            realChessMove += arrayOfPiece[saveCounter].positionX - saveRnd;
                            realChessMove += arrayOfPiece[saveCounter].positionY;

                            if (arrayOfPiece[saveCounter].positionX - saveRnd < 21 || arrayOfPiece[saveCounter].positionX - saveRnd > 28)
                            {
                                return false;
                            }
                            realChessMove += 2;

                            if (CheckWalkRook(arrayOfPiece, saveCounter, realChessMove, ref numberOfPiece))
                            {
                                Behavior(ref arrayOfPiece, saveCounter, realChessMove, numberOfPiece, ref game, true);
                                return true;
                            }
                            else return false;
                        }
                        else if (rnd.Next(0, 4) == 3)
                        {
                            realChessMove = Convert.ToString(arrayOfPiece[saveCounter].positionX);
                            realChessMove += arrayOfPiece[saveCounter].positionY;
                            saveRnd = rnd.Next(1, 8);
                            realChessMove += arrayOfPiece[saveCounter].positionX + saveRnd;
                            realChessMove += arrayOfPiece[saveCounter].positionY;

                            if (arrayOfPiece[saveCounter].positionX + saveRnd < 21 || arrayOfPiece[saveCounter].positionX + saveRnd > 28)
                            {
                                return false;
                            }
                            realChessMove += 2;

                            if (CheckWalkRook(arrayOfPiece, saveCounter, realChessMove, ref numberOfPiece))
                            {
                                Behavior(ref arrayOfPiece, saveCounter, realChessMove, numberOfPiece, ref game, true);
                                return true;
                            }
                            else return false;
                        }
                    }
                    else if (rnd1 == 26 || rnd1 == 27)
                    {
                        saveCounter = rnd1;

                        if (rnd.Next(0, 8) == 0)
                        {
                            realChessMove = Convert.ToString(arrayOfPiece[saveCounter].positionX);
                            realChessMove += arrayOfPiece[saveCounter].positionY;
                            realChessMove += arrayOfPiece[saveCounter].positionX + 1;
                            realChessMove += arrayOfPiece[saveCounter].positionY + 2;

                            if (arrayOfPiece[saveCounter].positionX + 1 < 21 || arrayOfPiece[saveCounter].positionX + 1 > 28 || arrayOfPiece[saveCounter].positionY + 2 < 11 || arrayOfPiece[saveCounter].positionY + 2 > 18)
                            {
                                return false;
                            }
                            realChessMove += 2;

                            if (CheckWalkBishop(arrayOfPiece, saveCounter, realChessMove, ref numberOfPiece))
                            {
                                Behavior(ref arrayOfPiece, saveCounter, realChessMove, numberOfPiece, ref game, true);
                                return true;
                            }
                            else return false;
                        }
                        else if (rnd.Next(0, 8) == 1)
                        {
                            realChessMove = Convert.ToString(arrayOfPiece[saveCounter].positionX);
                            realChessMove += arrayOfPiece[saveCounter].positionY;
                            realChessMove += arrayOfPiece[saveCounter].positionX - 1;
                            realChessMove += arrayOfPiece[saveCounter].positionY + 2;

                            if (arrayOfPiece[saveCounter].positionX - 1 < 21 || arrayOfPiece[saveCounter].positionX - 1 > 28 || arrayOfPiece[saveCounter].positionY + 2 < 11 || arrayOfPiece[saveCounter].positionY + 2 > 18)
                            {
                                return false;
                            }
                            realChessMove += 2;

                            if (CheckWalkBishop(arrayOfPiece, saveCounter, realChessMove, ref numberOfPiece))
                            {
                                Behavior(ref arrayOfPiece, saveCounter, realChessMove, numberOfPiece, ref game, true);
                                return true;
                            }
                            else return false;
                        }
                        else if (rnd.Next(0, 8) == 2)
                        {
                            realChessMove = Convert.ToString(arrayOfPiece[saveCounter].positionX);
                            realChessMove += arrayOfPiece[saveCounter].positionY;
                            realChessMove += arrayOfPiece[saveCounter].positionX + 1;
                            realChessMove += arrayOfPiece[saveCounter].positionY - 2;

                            if (arrayOfPiece[saveCounter].positionX + 1 < 21 || arrayOfPiece[saveCounter].positionX + 1 > 28 || arrayOfPiece[saveCounter].positionY - 2 < 11 || arrayOfPiece[saveCounter].positionY - 2 > 18)
                            {
                                return false;
                            }
                            realChessMove += 2;

                            if (CheckWalkBishop(arrayOfPiece, saveCounter, realChessMove, ref numberOfPiece))
                            {
                                Behavior(ref arrayOfPiece, saveCounter, realChessMove, numberOfPiece, ref game, true);
                                return true;
                            }
                            else return false;
                        }
                        else if (rnd.Next(0, 8) == 3)
                        {
                            realChessMove = Convert.ToString(arrayOfPiece[saveCounter].positionX);
                            realChessMove += arrayOfPiece[saveCounter].positionY;
                            realChessMove += arrayOfPiece[saveCounter].positionX - 1;
                            realChessMove += arrayOfPiece[saveCounter].positionY - 2;

                            if (arrayOfPiece[saveCounter].positionX - 1 < 21 || arrayOfPiece[saveCounter].positionX - 1 > 28 || arrayOfPiece[saveCounter].positionY - 2 < 11 || arrayOfPiece[saveCounter].positionY - 2 > 18)
                            {
                                return false;
                            }
                            realChessMove += 2;

                            if (CheckWalkBishop(arrayOfPiece, saveCounter, realChessMove, ref numberOfPiece))
                            {
                                Behavior(ref arrayOfPiece, saveCounter, realChessMove, numberOfPiece, ref game, true);
                                return true;
                            }
                            else return false;
                        }
                        else if (rnd.Next(0, 8) == 4)
                        {
                            realChessMove = Convert.ToString(arrayOfPiece[saveCounter].positionX);
                            realChessMove += arrayOfPiece[saveCounter].positionY;
                            realChessMove += arrayOfPiece[saveCounter].positionX + 2;
                            realChessMove += arrayOfPiece[saveCounter].positionY + 1;

                            if (arrayOfPiece[saveCounter].positionX + 2 < 21 || arrayOfPiece[saveCounter].positionX + 2 > 28 || arrayOfPiece[saveCounter].positionY + 1 < 11 || arrayOfPiece[saveCounter].positionY + 1 > 18)
                            {
                                return false;
                            }
                            realChessMove += 2;

                            if (CheckWalkBishop(arrayOfPiece, saveCounter, realChessMove, ref numberOfPiece))
                            {
                                Behavior(ref arrayOfPiece, saveCounter, realChessMove, numberOfPiece, ref game, true);
                                return true;
                            }
                            else return false;
                        }
                        else if (rnd.Next(0, 8) == 5)
                        {
                            realChessMove = Convert.ToString(arrayOfPiece[saveCounter].positionX);
                            realChessMove += arrayOfPiece[saveCounter].positionY;
                            realChessMove += arrayOfPiece[saveCounter].positionX - 2;
                            realChessMove += arrayOfPiece[saveCounter].positionY + 1;

                            if (arrayOfPiece[saveCounter].positionX - 2 < 21 || arrayOfPiece[saveCounter].positionX - 2 > 28 || arrayOfPiece[saveCounter].positionY + 1 < 11 || arrayOfPiece[saveCounter].positionY + 1 > 18)
                            {
                                return false;
                            }
                            realChessMove += 2;

                            if (CheckWalkBishop(arrayOfPiece, saveCounter, realChessMove, ref numberOfPiece))
                            {
                                Behavior(ref arrayOfPiece, saveCounter, realChessMove, numberOfPiece, ref game, true);
                                return true;
                            }
                            else return false;
                        }
                        else if (rnd.Next(0, 8) == 6)
                        {
                            realChessMove = Convert.ToString(arrayOfPiece[saveCounter].positionX);
                            realChessMove += arrayOfPiece[saveCounter].positionY;
                            realChessMove += arrayOfPiece[saveCounter].positionX + 2;
                            realChessMove += arrayOfPiece[saveCounter].positionY - 1;

                            if (arrayOfPiece[saveCounter].positionX + 2 < 21 || arrayOfPiece[saveCounter].positionX + 2 > 28 || arrayOfPiece[saveCounter].positionY - 1 < 11 || arrayOfPiece[saveCounter].positionY - 1 > 18)
                            {
                                return false;
                            }
                            realChessMove += 2;

                            if (CheckWalkBishop(arrayOfPiece, saveCounter, realChessMove, ref numberOfPiece))
                            {
                                Behavior(ref arrayOfPiece, saveCounter, realChessMove, numberOfPiece, ref game, true);
                                return true;
                            }
                            else return false;
                        }
                        else if (rnd.Next(0, 8) == 7)
                        {
                            realChessMove = Convert.ToString(arrayOfPiece[saveCounter].positionX);
                            realChessMove += arrayOfPiece[saveCounter].positionY;
                            realChessMove += arrayOfPiece[saveCounter].positionX - 2;
                            realChessMove += arrayOfPiece[saveCounter].positionY - 1;

                            if (arrayOfPiece[saveCounter].positionX - 2 < 21 || arrayOfPiece[saveCounter].positionX - 2 > 28 || arrayOfPiece[saveCounter].positionY - 1 < 11 || arrayOfPiece[saveCounter].positionY - 1 > 18)
                            {
                                return false;
                            }
                            realChessMove += 2;

                            if (CheckWalkBishop(arrayOfPiece, saveCounter, realChessMove, ref numberOfPiece))
                            {
                                Behavior(ref arrayOfPiece, saveCounter, realChessMove, numberOfPiece, ref game, true);
                                return true;
                            }
                            else return false;
                        }                        
                    }
                }
            }
        }
        #endregion

        
    }
}
