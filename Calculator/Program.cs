// Ask user to input first number
Console.WriteLine("Type in the first number followed by the Enter key");
int firstNumber = Convert.ToInt32(Console.ReadLine());

// Ask user for second number
Console.WriteLine("Type the second number followed by the Enter key");
int secondNumber = Convert.ToInt32(Console.ReadLine());

// Perform Calculation
int result = firstNumber + secondNumber;

// Output the asnwer to console
Console.WriteLine("Adding {0} and {1} give the answer {2}", firstNumber, secondNumber, result);



