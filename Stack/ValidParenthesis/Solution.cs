namespace neetcode.Stack.ValidParenthesis;

using System;
using System.Linq;

public class Solution
{
    public bool ValidParenthesis(string s)
    {
        var stack = new Stack<char>();

        foreach (var c in s)
        {
            if (c == ')')
            {
                if (stack.TryPop(out char c2))
                {
                    if (c2 != '(')
                    {
                        return false;
                    }
                    continue;
                }
                return false;
            }

            if (c == ']')
            {
                if (stack.TryPop(out char c2))
                {
                    if (c2 != '[')
                    {
                        return false;
                    }
                    continue;
                }
                return false;
            }

            if (c == '}')
            {
                if (stack.TryPop(out char c2))
                {
                    if (c2 != '{')
                    {
                        return false;
                    }
                    continue;
                }
                return false;
            }

            else
            {
                stack.Push(c);
            }
        }

        return stack.Count() == 0;
    }

}