// See https://aka.ms/new-console-template for more information
static bool ValidateInputIsNumber(string input)
{
    try
    {
        int number = int.Parse(input);
        return true;
    }
    catch (FormatException e)
    {
        Console.WriteLine("There was an error: " + e.Message);
        return false;
    }
    catch (Exception)
    {
        throw;
    }
}

Console.WriteLine("Welcome to simple calulator. What would you like to do?");
Console.WriteLine("Add - 1");
Console.WriteLine("Subtract - 2");
Console.WriteLine("Muliply - 3");
Console.WriteLine("Divide - 4");
Console.WriteLine("Please enter your selection: ");
var input = Console.ReadLine();

if (!ValidateInputIsNumber(input))
{
    Console.WriteLine("Selection is not a number");
    return;
}

int selection = int.Parse(input);

if (!Enumerable.Range(1, 4).Contains(selection))
{
    throw new Exception("Invalid selection range");
}

Console.WriteLine("Enter first number");
var number1 = Console.ReadLine();

if (!ValidateInputIsNumber(number1))
{
    Console.WriteLine(number1 + " is not a valid number");
    return;
}

Console.WriteLine("Enter second number");
var number2 = Console.ReadLine();

if (!ValidateInputIsNumber(number2))
{
    Console.WriteLine(number2 + " is not a valid number");
    return;
}

int num1 = int.Parse(number1);
int num2 = int.Parse(number2);


if (selection == 1)
{
    Console.WriteLine("Addind {0} and {1}", num1, num2);
    Console.WriteLine("Result is {0}", num1 + num2);
}

if (selection == 2)
{
    Console.WriteLine("subtracting {0} and {1}", num1, num2);
    Console.WriteLine("Result is {0}", num1 - num2);
}

if (selection == 3)
{
    Console.WriteLine("Multipling {0} and {1}", num1, num2);
    Console.WriteLine("Result is {0}", num1 * num2);
}

if (selection == 4)
{
    Console.WriteLine("Dividing {0} and {1}", num1, num2);
    Console.WriteLine("Result is {0}", num1 / num2);
}


Console.WriteLine("Thanks for using this shit calculator");

