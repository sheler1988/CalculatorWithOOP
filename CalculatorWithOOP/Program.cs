

// calc with OOP

using CalculatorWithOOP.Base;
using CalculatorWithOOP.MathOperators;

while (true)
{
	Console.Clear();
	MathOperation operation = null;
	Console.WriteLine("Welcome To My Calculator");
	Console.WriteLine("--------------------------");
	Console.WriteLine("1. Add");
	Console.WriteLine("2. Subtract");
	Console.WriteLine("3. Multiply");
	Console.WriteLine("4. Divide");
	Console.WriteLine("5. Exit");
	Console.WriteLine();

	Console.Write("Select an option: ");
	var selectedOption = Console.ReadLine();
	Console.Clear();


	// اول دوتا عدد رو میخوام بکیرم که بتونم به اون کلاس ها ارسال کنم
	Console.Write("Enter first number: ");
	var firstNumber = decimal.Parse(Console.ReadLine());

	Console.Write("Enter second number: ");
	var lastNumber = decimal.Parse(Console.ReadLine());

	// زمانی که هر کدوم از این کزینه ها انتخاب شد
	// میخوام یک شی از روی یک مت اوپریشن بسازم
	switch (selectedOption)
	{
		case "1":
			operation = new AddOperator(firstNumber, lastNumber);
			break;
		case "2":
			operation = new SubOperator(firstNumber, lastNumber);
			break;
		case "3":
			operation = new MultiplyOperator(firstNumber, lastNumber);
			break;
		case "4":
			operation = new DividOperator(firstNumber, lastNumber);
			break;
		case "5":
			return;
		default:
			Console.WriteLine("Invalid option!");
			Console.ReadKey();
			continue;
	}

	if (operation != null)
	{
		if (!operation.Validate())
		{
			Console.WriteLine("Invalid inputs!");
			Console.WriteLine("press any key to continue");
			Console.ReadKey();
			continue;
		}

		var result = operation.Operate();
		Console.WriteLine($"Result: {result}");
		Console.WriteLine("press any key to continue");
		Console.ReadKey();
	}




}