bool isRuning = true;
while (isRuning)
{
    double firstNumber = GetInput("Insert first number: ");
    double secondNumber = GetInput("Insert second number: ");

    double symbol = GetInput("select the desired action: \n1. | + | \n2. | - | \n3. | * | \n4. | / | \n5. | % |");
    double result = GetSymbol(firstNumber, secondNumber, symbol);
    Console.WriteLine($"Result: {result}");
    bool end = TheEnd("continue Y/N?", ref isRuning);
    






    static double GetInput(string str)
    {
        double number;
        Console.WriteLine(str);
        string input = Console.ReadLine();
        bool isSucces = double.TryParse(input, out number);
        return number;

    }

    static double GetSymbol(double a, double b, double c)
    {
        double res = 0;
        if (c == 1)
            res = a + b;
        else if (c == 2)
            res = a - b;
        else if (c == 3)
            res = a * b;
        else if (c == 4 && b == 0)
            Console.WriteLine("division by zero");
        else if (c == 4)
            res = a / b;
        else if (c == 5)
            res = a % b;
        else
            Console.WriteLine("Invalid argument");
        return res;


    }
    static bool TheEnd(string str, ref bool isRuning)
    {

        Console.WriteLine(str);
        string value = Console.ReadLine();
        switch (value)
        {
            case "Y":
            case "y":
            case "Н":
            case "н":
                isRuning = true;
                break;
            default:
                Console.WriteLine("Bye Bye!");
                isRuning = false;
                break;
        }
        return isRuning;
    
    }
}
