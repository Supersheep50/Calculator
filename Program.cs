
while (true) {
    Console.WriteLine("Welcome to the Calculator!");
    Console.WriteLine("Please enter the first number:");
    string input1 = Console.ReadLine();
    Console.WriteLine("Please enter the second number:");
    string input2 = Console.ReadLine();

    Console.WriteLine("Would you like to 1.Add 2.Subtract 3.Divide 4.Multiply");
    string userInput = Console.ReadLine();


    if (userInput == "1")
    {
        int answer = int.Parse(input1) + int.Parse(input2);
        Console.WriteLine($"Your answer is {answer}");
        
        
    }

}