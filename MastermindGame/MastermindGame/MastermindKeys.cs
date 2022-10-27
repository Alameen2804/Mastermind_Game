using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MastermindGame
{
    public class MastermindKeys
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

        public int CheckWin(char[] CharArr)
        {
            int Flag = 0;
            int Count = 0;
            for (int i = 0; i < CharArr.Length; i++)
            {
                if (CharArr[i] == 'R')
                {
                    Count++;
                    if (Count == CharArr.Length)
                    {
                        Flag = 1;
                        break;
                    }
                }
                else
                {
                    Count = 0;
                    Flag = -1;
                }
            }
            return Flag;
        }
    }
}