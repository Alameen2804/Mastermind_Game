using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MastermindGame
{
    public class MastermindBoard
    {
        public string StateOfWinning(int CheckWin, int Size)
        {
            string X = "";
            if (CheckWin == 1)
            {
                X = "Code Breaker has won the match!";
            }
            else if (Size == 0)
            {
                X = "Code Maker has won the match!";
            }
            return X;
        }

        public int[,] AllocateElements(int[,] Arr, int[] Digits, int temp)
        {
            int i = Arr.GetLength(0) - temp;
            for (int j = 0; j < Arr.GetLength(1); j++)
            {
                Arr[i, j] = Digits[j];
            }
            return Arr;
        }

        public int[] GetDigits(int Number)
        {
            int[] DigitsArray = new int[4];
            int i = DigitsArray.Length - 1;
            while (Number != 0)
            {
                int rem = Number % 10;
                DigitsArray[i] = rem;
                i--;
                Number = Number / 10;
            }
            return DigitsArray;
        }

        public int[] GetIntArrayElementsFromIntNumber(int Number)
        {
            if (Number == 0)
            {
                return new int[1] { 0 };
            }
            List<int> digits = new List<int>();
            while (Number != 0)
            {
                digits.Add(Number % 10);
                Number = Number / 10;
            }
            int[] Array = digits.ToArray();
            System.Array.Reverse(Array);

            return Array;
        }
    }
}