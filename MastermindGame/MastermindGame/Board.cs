using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MastermindGame
{
    public class Board
    {
        public int[,] SetInputInBoard(int[,] Arr, int[] Digits, int temp)
        {
            int i = Arr.GetLength(0) - temp;
            for (int j = 0; j < Arr.GetLength(1); j++)
            {
                Arr[i, j] = Digits[j];
            }
            return Arr;
        }

        public int[] GetDigitsArrayFromInput(int Number)
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
    }
}