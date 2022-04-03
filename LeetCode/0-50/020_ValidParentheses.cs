using System.Collections.Generic;

namespace LeetCode._0_50
{
    public class _020_ValidParentheses
    {
        public bool IsValid(string s)
        {
            var stackBrackets = new Stack<char>();

            foreach (var symbol in s)
            {
                if (IsOpenBracket(symbol))
                {
                    stackBrackets.Push(symbol);
                }
                else if (IsCloseBracket(symbol))
                {
                    if (stackBrackets.Count == 0)
                    {
                        return false;
                    }

                    var openBracket = stackBrackets.Pop();
                    if (!IsPairOfBracket(openBracket, symbol))
                    {
                        return false;
                    }
                }
            }

            return stackBrackets.Count == 0;
        }

        private bool IsPairOfBracket(char openBracket, char closeBracket)
        {
            switch (openBracket)
            {
                case '(' when closeBracket == ')':
                case '{' when closeBracket == '}':
                case '[' when closeBracket == ']':
                    return true;
                default:
                    return false;
            }
        }

        private bool IsOpenBracket(char bracket)
        {
            return bracket switch
            {
                '(' => true,
                '{' => true,
                '[' => true,
                _ => false
            };
        }

        private bool IsCloseBracket(char bracket)
        {
            return bracket switch
            {
                ')' => true,
                '}' => true,
                ']' => true,
                _ => false
            };
        }
    }
}