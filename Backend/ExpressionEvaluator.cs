using System;
using System.Collections.Generic;

namespace Backend;

public static class ExpressionEvaluator
{
    public static double Evalute(string infix) => EvalutePostfix(ToPostfix(infix));

    private static string ToPostfix(string infix)
    {
        var posfix = string.Empty;
        var stack = new Stack<char>();

        for (int i = 0; i < infix.Length; i++)
        {
            var item = infix[i];

            if (IsOperator(item))
            {
                if (item == ')')
                {
                    var ope = stack.Pop();
                    while (ope != '(')
                    {
                        posfix += ope + " "; 
                        ope = stack.Pop();
                    }
                }
                else
                {
                   
                    while (stack.Count > 0 && PriorityInfix(item) <= PriorityStack(stack.Peek()))
                    {
                        posfix += stack.Pop() + " ";
                    }
                    stack.Push(item);
                }
            }
            else
            {
                
                string number = "";
                while (i < infix.Length && (char.IsDigit(infix[i]) || infix[i] == '.'))
                {
                    number += infix[i];
                    i++;
                }
                i--;
                posfix += number + " ";
            }
        }

        while (stack.Count != 0)
        {
            posfix += stack.Pop() + " ";
        }

        return posfix;
    }

    private static int PriorityStack(char op) => op switch
    {
        '^' => 3,
        '*' => 2,
        '/' => 2,
        '+' => 1,
        '-' => 1,
        '(' => 0,
        _ => throw new Exception("Invalid expression."),
    };

    private static int PriorityInfix(char op) => op switch
    {
        '^' => 4,
        '*' => 2,
        '/' => 2,
        '+' => 1,
        '-' => 1,
        '(' => 5,
        _ => throw new Exception("Invalid expression."),
    };

    private static bool IsOperator(char item) => item == '^' || item == '*' || item == '/' || item == '+' || item == '-' || item == '(' || item == ')';

    private static double EvalutePostfix(string postfix)
    {
        var stack = new Stack<double>();

        
        var items = postfix.Trim().Split(' ');

        foreach (var item in items)
        {
            
            if (item.Length == 1 && IsOperator(item[0]))
            {
                var ope2 = stack.Pop();
                var ope1 = stack.Pop();
                stack.Push(Calculate(ope1, ope2, item[0]));
            }
            else
            {
                stack.Push(double.Parse(item));
            }
        }
        return stack.Pop();
    }

    private static double Calculate(double ope1, double ope2, char item) => item switch
    {
        '*' => ope1 * ope2,
        '/' => ope1 / ope2,
        '+' => ope1 + ope2,
        '-' => ope1 - ope2,
        '^' => Math.Pow(ope1, ope2),
        _ => throw new Exception("Invalid expression."),
    };
}