using System.Collections.Generic;
using System.Text;

namespace LeetCode._0_50
{
    public class _006_ZigzagConversion
    {
        public string Convert(string s, int numRows)
        {
            if (numRows is 0 or 1)
            {
                return s;
            }

            var stringBuilders = new List<StringBuilder>();
            for (var i = 0; i < numRows; i++)
            {
                stringBuilders.Add(new StringBuilder());
            }

            var isGoingDown = true;
            var currentRow = 0;
            foreach (var symbol in s)
            {
                stringBuilders[currentRow].Append(symbol);
                if (currentRow == 0 || currentRow == numRows - 1) isGoingDown = !isGoingDown;
                currentRow += !isGoingDown ? 1 : -1;
            }

            var result = new StringBuilder();
            for (var i = 0; i < numRows; i++)
            {
                result.Append(stringBuilders[i].ToString());
            }

            return result.ToString();
        }
    }
}