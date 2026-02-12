Console.Write(" Task = ");

switch (Console.ReadLine())  {
  case "1":
    Console.Write(" Base number = ");
    int baseValue = Convert.ToInt32(Console.ReadLine());
    Console.Write(" Exponent = ");
    int powerValue = Convert.ToInt32(Console.ReadLine());

    int calculationResult = 1;

    for (int loopCounter = 0; loopCounter < powerValue; ++loopCounter)
    {
      calculationResult *= baseValue;
    }
    Console.WriteLine($" Power = {baseValue}^{powerValue} = {calculationResult} ");
    break;

  case "2":
    Console.Write(" Number(>= 100) = ");
    string userInput = Console.ReadLine();
                
    char middleDigit = userInput[1];
    string transformedNumber = userInput[0] + userInput.Substring(2) + middleDigit;

    Console.WriteLine($" Result = {transformedNumber} ");
    break;
}

Console.ReadKey();