Console.Write(" Task = ");

switch (Console.ReadLine()) {
  case "1":
    int baseValue;
    int powerValue;
    int calculationResult;

    Console.Write(" Base number = ");
    baseValue = Convert.ToInt32(Console.ReadLine());
    Console.Write(" Exponent = ");
    powerValue = Convert.ToInt32(Console.ReadLine());

    calculationResult = 1;

    for (int loopCounter = 0; loopCounter < powerValue; ++loopCounter) {
      calculationResult *= baseValue;
    }
    
    Console.WriteLine($" Power = {baseValue}^{powerValue} = {calculationResult} ");
    
    break;

  case "2":
    string userInput;
    string transformedNumber;
    char middleDigit;

    Console.Write(" Number(>= 100) = ");
    userInput = Console.ReadLine();
                
    middleDigit = userInput[1];
    transformedNumber = userInput[0] + userInput.Substring(2) + middleDigit;

    Console.WriteLine($" Result = {transformedNumber} ");

    break;
}

Console.ReadKey();