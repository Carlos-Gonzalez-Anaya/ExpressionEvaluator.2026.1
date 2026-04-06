namespace ExpressionEvaluator.Core;

public class Evaluator
{
    public static double Evaluate(string infix)
    {
        var numbers = SeparateNumbers(infix);
        var postfix = InfixToPostfix(numbers);
        return EvaluatePostfix(postfix);
    }

    private static List<string> InfixToPostfix(List<string> numbers)
    {
        var postfix = new List<string>();
        var stack = new Stack<string>();

        foreach (var item in numbers)
        {
            if (IsOperator(item))
            {
                if (stack.Count == 0)
                {
                    stack.Push(item);
                }
                else
                {
                    if (item == ")")
                    {
                        do
                        {
                           postfix.Add(stack.Pop());
                        } while (stack.Peek() != "(");
                        stack.Pop();
                    }
                    else
                    {
                        if (PriorityInfix(item) > PriorityStack(stack.Peek()))
                        {
                            stack.Push(item);
                        }
                        else
                        {
                            postfix.Add(stack.Pop());
                            stack.Push(item);
                        }
                    }
                }
            }
            else
            {
                postfix.Add(item);
            }
        }
        while (stack.Count > 0)
        {
            postfix.Add(stack.Pop());
        }
        return postfix;
    }

    private static int PriorityStack(string item) => item switch
    {
        "^" => 3,
        "*" => 2,
        "/" => 2,
        "+" => 1,
        "-" => 1,
        "(" => 0,
        _ => throw new Exception("Sintax error."),
    };

    private static int PriorityInfix(string item) => item switch
    {
        "^" => 4,
        "*" => 2,
        "/" => 2,
        "+" => 1,
        "-" => 1,
        "(" => 5,
        _ => throw new Exception("Sintax error."),
    };

    private static double EvaluatePostfix(List<string> postfix)
    {
        var stack = new Stack<double>();
        foreach (var item in postfix)
        {
            if (IsOperator(item))
            {
                var b = stack.Pop();
                var a = stack.Pop();
                stack.Push(item switch
                {
                    "+" => a + b,
                    "-" => a - b,
                    "*" => a * b,
                    "/" => a / b,
                    "^" => Math.Pow(a, b),
                    _ => throw new Exception("Sintax error."),
                });
            }
            else
            {
                stack.Push(double.Parse(item.Replace('.', ',')));

            }
        }
        return stack.Pop();
    }

    private static bool IsOperator(string item) => "+-*/^()".Contains(item);

    private static List<string> SeparateNumbers(string infix)
    {
        var numbers = new List<string>();
        string currentNumber = "";

        foreach (var character in infix)
        {

            if (IsOperator(character.ToString())&&character!='.')
            {
                if (!string.IsNullOrEmpty(currentNumber))
                {
                    numbers.Add(currentNumber);
                    currentNumber = "";
                }
                numbers.Add(character.ToString());
            }
            else
            {
                currentNumber += character;
            }
        }

        if (!string.IsNullOrEmpty(currentNumber))
            numbers.Add(currentNumber);

        return numbers;
    }



}