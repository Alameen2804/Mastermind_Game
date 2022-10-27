using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MastermindGame
{
    public class MastermindColors
    {
        public int[] GenerateMakerArrayHard()
        {
            int[] retArr = new int[4];
            Random ran = new Random();
            for (int i = 0; i < retArr.Length; i++)
            {
                int temp = ran.Next(1, 9);
                retArr[i] = temp;
            }
            return retArr;
        }

        public int[] GenerateMakerArrayEasy()
        {
            int[] retArr = new int[4];
            Random rand = new Random();
            for (int i = 0; i < retArr.Length; i++)
            {
                while (true)
                {
                    int Next = rand.Next(1, 9);
                    if (!IsContains(retArr, Next))
                    {
                        break;
                    }
                    retArr[i] = Next;
                }
            }
            return retArr;
        }

        public bool IsContains(int[] Array, int Value)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] == Value)
                {
                    return true;
                }
            }
            return false;
        }
    }
}