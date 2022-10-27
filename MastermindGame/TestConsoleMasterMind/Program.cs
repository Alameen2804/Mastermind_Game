using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MastermindGame;
using System.Threading;

namespace TestConsoleMasterMind
{
    class Program
    {
        public static int[] SystemCodeMaker;
        public static int[,] CodeBreaker;
        public static int Size;
        public static int No;

        static void Main(string[] args)
        {
            MastermindBoard mmBoard = new MastermindBoard();
            MastermindKeys mmKeys = new MastermindKeys();
            MastermindColors mmColors = new MastermindColors();

            int temp = 1;
            SystemCodeMaker = new int[4];
            CodeBreaker = new int[10, 4];
            Size = CodeBreaker.Length;

            Console.WriteLine("MyMasterMind Game");
            Console.WriteLine(Print2DIntegerArray(CodeBreaker));
            int[] RandomArray = mmColors.GenerateMakerArrayHard();
            Console.WriteLine(PrintIntegerArray(RandomArray));
            while (Size > 0)
            {

                Console.Clear();
                Console.WriteLine("Enter the 4 numbers such as(1234): ");
                No = int.Parse(Console.ReadLine());
                Console.WriteLine(Print2DIntegerArray(mmBoard.AllocateElements(CodeBreaker, mmBoard.GetDigits(No), temp)));
                Console.Write("Keys:\t");
                Console.WriteLine(PrintCharArray(mmKeys.CompareMakerAndBreakerArray(RandomArray, mmBoard.GetDigits(No))));
                mmKeys.CompareMakerAndBreakerArray(mmColors.GenerateMakerArrayEasy(), mmBoard.GetDigits(No));
                Size = Size - 4;
                temp++;
                if (mmKeys.CheckWin(mmKeys.CompareMakerAndBreakerArray(RandomArray, mmBoard.GetDigits(No))) == 1)
                {
                    Console.WriteLine("Codemaker value: " + PrintIntegerArray(RandomArray));
                    Console.WriteLine("CodeBreaker has won the match!!!");
                    break;
                }
                else if (Size == 0)
                {
                    Console.WriteLine("Codemaker value: " + PrintIntegerArray(RandomArray));
                    Console.WriteLine("CodeMaker has won the match!!!");
                }
            }
        }

        public static string PrintIntegerArray(int[] Array)
        {
            string X = "";
            for (int i = 0; i < Array.Length; i++)
            {
                X += Array[i] + "   ";
            }
            return X;
        }

        public static string Print2DIntegerArray(int[,] Array)
        {
            string X = "";
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    X += Array[i, j] + "\t";
                }
                X += "\n\n";
            }
            return X;
        }

        public static string PrintCharArray(char[] Array)
        {
            string X = "";
            for (int i = 0; i < Array.Length; i++)
            {
                X += Array[i] + "   ";
            }
            return X;
        }
    }
}