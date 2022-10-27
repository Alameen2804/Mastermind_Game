using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MastermindGame
{
    public class CodeMaker
    {
        public int[] GenerateMakerArray()
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
    }
}