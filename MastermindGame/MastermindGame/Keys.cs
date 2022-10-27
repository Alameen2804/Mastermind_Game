using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MastermindGame
{
    public class Keys
    {
        public char[] CompareMakerAndBreakerArray(int[] MakerArray, int[] BreakerArray)
        {
            char[] retKeysArr = new char[4];
            for (int i = 0; i < retKeysArr.Length; i++)
            {
                if (MakerArray[i] == BreakerArray[i])
                {
                    retKeysArr[i] = 'R';
                }
                else if (MakerArray.Contains(BreakerArray[i]))
                {
                    retKeysArr[i] = 'W';
                }
                else
                {
                    retKeysArr[i] = 'N';
                }
            }
            return retKeysArr;
        }

        public bool CheckWin(char[] CharArray)
        {
            bool IsWin = false;
            int Count = 0;
            for (int i = 0; i < CharArray.Length; i++)
            {
                if (CharArray[i] == 'R')
                {
                    Count++;
                    if (Count == CharArray.Length)
                    {
                        IsWin = true;
                    }
                }
            }
            return IsWin;
        }
    }
}