namespace Backend;
public static class ExpressionEvaluator
{
    public static double Evalute(string infix) => EvalutePostfix(ToPostfix(infix));

    private static string ToPostfix(string infix)
    {
        var posfix = string.Empty;
        var stack = new Stack<char>();

        // Using a for loop instead of foreach to control the index 'i' when reading multi-digit numbers
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
                        posfix += ope + " "; // Added a space as a delimiter between tokens
                        ope = stack.Pop();
                    }
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        stack.Push(item);
                    }
                    else
                    {
                        if (PriorityInfix(item) > PriorityStack(stack.Peek()))
                        {
                            stack.Push(item);
                        }
                        else
                        {
                            posfix += stack.Pop() + " "; // Added a space as a delimiter between tokens
                            stack.Push(item);
                        }
                    }
                }
            }
            else
            {
                // Accumulate consecutive digits or decimal points into a single number string
                string number = "";
                while (i < infix.Length && (char.IsDigit(infix[i]) || infix[i] == '.'))
                {
                    number += infix[i];
                    i++;
                }
                i--; // Step back one position since the outer 'for' loop will increment 'i'

                posfix += number + " "; // Append the full number followed by a space
            }
        }

        do
        {
            posfix += stack.Pop() + " "; // Added a space as a delimiter between tokens
        } while (stack.Count != 0);

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

        // Split the postfix string by spaces to get each complete number or operator token
        var items = postfix.Trim().Split(' ');

        foreach (var item in items)
        {
            if (IsOperator(item[0]) && item.Length == 1)
            {
                var ope2 = stack.Pop();
                var ope1 = stack.Pop();
                stack.Push(Calculate(ope1, ope2, item[0]));
            }
            else
            {
                // Convert full number strings (including multi-digit and decimals) to double
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