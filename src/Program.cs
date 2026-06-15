using Calculator;
bool user = true;
while (user)
{
    string choice = "";
    Console.WriteLine("-------------------------------");
    Console.WriteLine("           Calculator");
    Console.WriteLine("-------------------------------");
    Console.WriteLine("Select your choice");
    bool vChoice = true; // validity of the choice
    while (vChoice)
    {
        Console.WriteLine("1. Add \n2. Substract\n3. Multiplication\n4. Division");

        Console.Write("Enter your choice here: ");
        choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
            case "2":
            case "3":
            case "4":
                vChoice = false;
                break;
            default:
                Console.WriteLine();
                Console.WriteLine("Enter a valid choice(1/2/3/4)....!");
                break;
        }

    }
    double doubleNum1 = 0;
    double doubleNum2 = 0;

    //check the inputs are numbers
    while (true)
    {
        Console.Write("Enter number one: ");
        string Num_1 = Console.ReadLine();
        Console.Write("Enter number two: ");
        string Num_2 = Console.ReadLine();
        if (double.TryParse(Num_1, out doubleNum1) && double.TryParse(Num_2, out doubleNum2))
        {
            break;
        }
        else
        {
            Console.WriteLine("Please enter numbers only");
        }
    }

    // connect to the class
    executions c = new executions();
    c.num_1 = doubleNum1;
    c.num_2 = doubleNum2;
    if (choice == "1")
    {
        double result = c.Add();
        Console.WriteLine($"Summation of {doubleNum1} + {doubleNum2} is {result}");
    }
    else if (choice == "2")
    {
        double result = c.substraction();
        if (doubleNum1 > doubleNum2)
        {
            Console.WriteLine($"Substraction of {doubleNum1} - {doubleNum2} is {result}");
        }
        else
        {
            Console.WriteLine($"Substraction of {doubleNum2} - {doubleNum1} is {result}");
        }

    }
    else if (choice == "3")
    {
        double result = c.multiplication();
        Console.WriteLine($"Multiplication of {doubleNum1} x {doubleNum2} is {result}");
    }
    else if (choice == "4")
    {

        double result = c.division();
        if (doubleNum2 != 0) 
        {
            Console.WriteLine($"Division of {doubleNum1}/{doubleNum2} is {result}");
        }
    }
    Console.Write("Do you want to continue to do operations(y/n): ");
    string userChoice = Console.ReadLine();
    if (userChoice.ToLower() == "n" || userChoice.ToLower() == "y")
    {
        if (userChoice.ToLower() == "n")
        {
            user = false;
        }
    }

}
