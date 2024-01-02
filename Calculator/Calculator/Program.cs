using System;
using System.Threading;
using System.Collections.Generic;

namespace Calculator
{
	class Program
	{
		static List<string> calculationHistory = new List<string>();
		
		static void Main(string [] args)
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.SetWindowSize(80, 30);
			Console.WriteLine("===================================================");
			Console.WriteLine();
			Console.WriteLine("     Welcome to Calculator by Edmar A. Suayan      ");
			Console.WriteLine();
			Console.WriteLine("===================================================");
			Console.WriteLine();
			Console.WriteLine();
			Console.Write("Press any key to enter...");
			Console.ReadKey(true);
			
			while (true)
			{
				Console.Clear();
				Console.WriteLine("Choose from different calculations: ");
				Console.WriteLine("====================================================");
            	Console.WriteLine();
				Console.WriteLine("1. Basic Operations (+, -, *, /, %)");
				Console.WriteLine("====================================================");
            	Console.WriteLine();
				Console.WriteLine("2. Scientific Calculations (sin, cos, tan)");
				Console.WriteLine("====================================================");
            	Console.WriteLine();
				Console.WriteLine("3. Unit Conversion (m to km)");
				Console.WriteLine("====================================================");
            	Console.WriteLine();
				Console.WriteLine("4. View Calculation History");
				Console.WriteLine("====================================================");
            	Console.WriteLine();
				Console.WriteLine("5. Play Minigame");
				Console.WriteLine("====================================================");
            	Console.WriteLine();
				Console.WriteLine("6. Exit");
				
				Console.WriteLine();
				Console.Write("Enter your choice (1-6): ");
				string choice = Console.ReadLine();
				
				switch (choice)
				{
					case "1":
						PerformBasicOperations();
						break;
					
					case "2":
						PerformScientificCalculations();
						break;
						
					case "3":
						PerformUnitConversion();
						break;
						
					case "4":
						ViewHistory();
						break;
						
					case "5":
						MiniGame();
						break;
						
					case "6":
						Console.Clear();
						Console.WriteLine("Calculator program closed.");
						Thread.Sleep(1000);
						Console.WriteLine("Thankyou for staying...");
						Thread.Sleep(2000);
						Environment.Exit(0);
						break;
						
					default:
						Console.Clear();
						Console.WriteLine("Invalid choice. Please enter a number between 1 to 5.");
						Console.Write("Press any key to continue...");
						Console.ReadKey(true);
						break;
				} 
			}
		}
		
		static void PerformBasicOperations()
	{
		while (true)
		{
			Console.Clear();
			Console.WriteLine("Perform Basic Operations");
			Console.WriteLine();
			
			Console.WriteLine("Choose a calculation:");
			Console.WriteLine("====================================================");
            Console.WriteLine();
			Console.WriteLine("1. Addition");
			Console.WriteLine("====================================================");
            Console.WriteLine();
			Console.WriteLine("2. Subtraction");
			Console.WriteLine("====================================================");
            Console.WriteLine();
			Console.WriteLine("3. Multiplication");
			Console.WriteLine("====================================================");
            Console.WriteLine();
			Console.WriteLine("4. Division");
			Console.WriteLine("====================================================");
            Console.WriteLine();
			Console.WriteLine("5. Remainder");
			Console.WriteLine("====================================================");
            Console.WriteLine();
			Console.WriteLine("6. Return to the main calculation choices");
			Console.WriteLine();
			
			Console.Write("Enter your choice (1-6): ");
			string operationChoice = Console.ReadLine();
			
			switch (operationChoice)
			{
				case "1":
					while (true)
					{
						Console.Clear();
						Console.Write("Enter the first number: ");
						double num1;
						if (double.TryParse(Console.ReadLine(), out num1))
						{
							while (true)
							{
								Console.Write("Enter the second number: ");
								double num2;
								if (double.TryParse(Console.ReadLine(), out num2))
								{
									double sum = num1 + num2;
									Console.WriteLine("{0} + {1} = {2}", num1, num2, sum);
									string historyEntry = string.Format("{0} + {1} = {2}", num1, num2, sum);
									AddToHistory(historyEntry);
									Console.WriteLine("Press any key to make another calculations...");
                    				Console.ReadKey();
                    				break;
								}
								else
								{
									Console.WriteLine("Invalid input. Please enter a valid number.");
									Console.ReadKey();
								}
							}
							break;
						}
							else
							{
								Console.WriteLine("Invalid input. Please enter a valid number.");
								Console.ReadKey();
							}
						}
                    break;
                    
                   case "2":
					while (true)
					{
						Console.Clear();
						Console.Write("Enter the first number: ");
						double num1;
						if (double.TryParse(Console.ReadLine(), out num1))
						{
							while (true)
							{
								Console.Write("Enter the second number: ");
								double num2;
								if (double.TryParse(Console.ReadLine(), out num2))
								{
									double difference = num1 - num2;
									Console.WriteLine("{0} - {1} = {2}", num1, num2, difference);
									string historyEntry = string.Format("{0} - {1} = {2}", num1, num2, difference);
									AddToHistory(historyEntry);
									Console.WriteLine("Press any key to make another calculations...");
                    				Console.ReadKey();
                    				break;
								}
								else
								{
									Console.WriteLine("Invalid input. Please enter a valid number.");
									Console.ReadKey();
								}
							}
							break;
						}
							else
							{
								Console.WriteLine("Invalid input. Please enter a valid number.");
								Console.ReadKey();
							}
						}
                    break;
                    
                    case "3":
					while (true)
					{
						Console.Clear();
						Console.Write("Enter the first number: ");
						double num1;
						if (double.TryParse(Console.ReadLine(), out num1))
						{
							while (true)
							{
								Console.Write("Enter the second number: ");
								double num2;
								if (double.TryParse(Console.ReadLine(), out num2))
								{
									double product = num1 * num2;
									Console.WriteLine("{0} * {1} = {2}", num1, num2, product);
									string historyEntry = string.Format("{0} * {1} = {2}", num1, num2, product);
									AddToHistory(historyEntry);
									Console.WriteLine("Press any key to make another calculations...");
                    				Console.ReadKey();
                    				break;
								}
								else
								{
									Console.WriteLine("Invalid input. Please enter a valid number.");
									Console.ReadKey();
								}
							}
							break;
						}
							else
							{
								Console.WriteLine("Invalid input. Please enter a valid number.");
								Console.ReadKey();
							}
						}
                    break;
                    
                    case "4":
					while (true)
					{
						Console.Clear();
						Console.Write("Enter the first number: ");
						double num1;
						if (double.TryParse(Console.ReadLine(), out num1))
						{
							while (true)
							{
								Console.Write("Enter the second number: ");
								double num2;
								if (double.TryParse(Console.ReadLine(), out num2))
								{
									double quotient = num1 / num2;
									Console.WriteLine("{0} / {1} = {2}", num1, num2, quotient);
									string historyEntry = string.Format("{0} / {1} = {2}", num1, num2, quotient);
									AddToHistory(historyEntry);
									Console.WriteLine("Press any key to make another calculations...");
                    				Console.ReadKey();
                    				break;
								}
								else
								{
									Console.WriteLine("Invalid input. Please enter a valid number.");
									Console.ReadKey();
								}
							}
							break;
						}
							else
							{
								Console.WriteLine("Invalid input. Please enter a valid number.");
								Console.ReadKey();
							}
						}
                    break;
                    
                    case "5":
					while (true)
					{
						Console.Clear();
						Console.Write("Enter the first number: ");
						double num1;
						if (double.TryParse(Console.ReadLine(), out num1))
						{
							while (true)
							{
								Console.Write("Enter the second number: ");
								double num2;
								if (double.TryParse(Console.ReadLine(), out num2))
								{
									double modulus = num1 % num2;
									Console.WriteLine("{0} % {1} = {2}", num1, num2, modulus);
									string historyEntry = string.Format("{0} % {1} = {2}", num1, num2, modulus);
									AddToHistory(historyEntry);
									Console.WriteLine("Press any key to make another calculations...");
                    				Console.ReadKey();
                    				break;
								}
								else
								{
									Console.WriteLine("Invalid input. Please enter a valid number.");
									Console.ReadKey();
								}
							}
							break;
						}
							else
							{
								Console.WriteLine("Invalid input. Please enter a valid number.");
								Console.ReadKey();
							}
						}
                    break;
                    
                   case "6":
                    Console.Clear();
                    return;
                    
                   default:
                    Console.Clear();
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                    break;
			}
		}
	}
			
		static void PerformScientificCalculations()
    {
        while (true)
        {
        	Console.Clear();
        	Console.WriteLine("Performing Scientific Calculations");
        	Console.WriteLine();

            Console.WriteLine("Choose a calculation:");
            Console.WriteLine("====================================================");
            Console.WriteLine();
            Console.WriteLine("1. sin");
            Console.WriteLine("====================================================");
            Console.WriteLine();
            Console.WriteLine("2. cos");
            Console.WriteLine("====================================================");
            Console.WriteLine();
            Console.WriteLine("3. tan");
            Console.WriteLine("====================================================");
            Console.WriteLine();
            Console.WriteLine("4. π");
            Console.WriteLine("====================================================");
            Console.WriteLine();
            Console.WriteLine("5. Hypotenuse (hyp)");
            Console.WriteLine("====================================================");
            Console.WriteLine();
            Console.WriteLine("6. Arcsin (sin^-1)");
            Console.WriteLine("====================================================");
            Console.WriteLine();
            Console.WriteLine("7. Arccos (cos^-1)");
            Console.WriteLine("====================================================");
            Console.WriteLine();
            Console.WriteLine("8. Arctan (tan^-1)");
            Console.WriteLine("====================================================");
            Console.WriteLine();
            Console.WriteLine("9. Return to main calculation choices");
            Console.WriteLine();

            Console.Write("Enter your choice (1-9): ");
            string operationChoice = Console.ReadLine();

            switch (operationChoice)
            {
                case "1":
            		Console.Clear();
                    Console.Write("Enter angle in degrees: ");
                    double angleDegreesSin;
                    if (double.TryParse(Console.ReadLine(), out angleDegreesSin))
                    {
                        double angleRadiansSin = angleDegreesSin * (Math.PI / 180);
                        Console.WriteLine("sin({0}°) = {1}", angleDegreesSin, Math.Sin(angleRadiansSin));
                        string historyEntry = string.Format("sin({0}°) = {1}", angleDegreesSin, Math.Sin(angleRadiansSin));
						AddToHistory(historyEntry);
                        Console.WriteLine("Press any key to make another calculations...");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                    break;
                case "2":
                    Console.Clear();
                    Console.Write("Enter angle in degrees: ");
                    double angleDegreesCos;
                    if (double.TryParse(Console.ReadLine(), out angleDegreesCos))
                    {
                        double angleRadiansCos = angleDegreesCos * (Math.PI / 180);
                        Console.WriteLine("cos({0}°) = {1}", angleDegreesCos, Math.Cos(angleRadiansCos));
                        string historyEntry = string.Format("cos({0}°) = {1}", angleDegreesCos, Math.Cos(angleRadiansCos));
						AddToHistory(historyEntry);
                        Console.WriteLine("Press any key to make another calculations...");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                    break;
                case "3":
                    Console.Clear();
                    Console.Write("Enter angle in degrees: ");
                    double angleDegreesTan;
                    if (double.TryParse(Console.ReadLine(), out angleDegreesTan))
                    {
                        double angleRadiansTan = angleDegreesTan * (Math.PI / 180);
                        Console.WriteLine("tan({0}°) = {1}", angleDegreesTan, Math.Tan(angleRadiansTan));
                        string historyEntry = string.Format("tan({0}°) = {1}", angleDegreesTan, Math.Tan(angleRadiansTan));
						AddToHistory(historyEntry);
                        Console.WriteLine("Press any key to make another calculations...");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("π = {0}", Math.PI);
                    Console.WriteLine("Press any key to make another calculations...");
                    Console.ReadKey();
                    break;
                case "5":
                    Console.Clear();
                    Console.Write("Enter side length A: ");
                    double sideA;
                    if (double.TryParse(Console.ReadLine(), out sideA))
                    {
                        Console.Write("Enter side length B: ");
                        double sideB;
                        if (double.TryParse(Console.ReadLine(), out sideB))
                        {
                            double hypotenuse = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
                            Console.WriteLine("Hypotenuse (hyp) = {0}", hypotenuse);
                            string historyEntry = string.Format("Hypotenuse (hyp) = {0}", hypotenuse);
						    AddToHistory(historyEntry);
                            Console.WriteLine("Press any key to make another calculations...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                    break;
                case "6":
                    Console.Clear();
                    Console.Write("Enter value for arcsin: ");
                    double arcsinValue;
                    if (double.TryParse(Console.ReadLine(), out arcsinValue))
                    {
                        Console.WriteLine("Arcsin({0}) = {1}°", arcsinValue, Math.Asin(arcsinValue) * (180 / Math.PI));
                        string historyEntry = string.Format("Arcsin({0}) = {1}°", arcsinValue, Math.Asin(arcsinValue) * (180 / Math.PI));
						AddToHistory(historyEntry);
                        Console.WriteLine("Press any key to make another calculations...");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                    break;
                case "7":
                    Console.Clear();
                    Console.Write("Enter value for arccos: ");
                    double arccosValue;
                    if (double.TryParse(Console.ReadLine(), out arccosValue))
                    {
                        Console.WriteLine("Arccos({0}) = {1}°", arccosValue, Math.Acos(arccosValue) * (180 / Math.PI));
                        string historyEntry = string.Format("Arccos({0}) = {1}°", arccosValue, Math.Acos(arccosValue) * (180 / Math.PI));
						AddToHistory(historyEntry);
                        Console.WriteLine("Press any key to make another calculations...");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                    break;
                case "8":
                    Console.Clear();
                    Console.Write("Enter value for arctan: ");
                    double arctanValue;
                    if (double.TryParse(Console.ReadLine(), out arctanValue))
                    {
                        Console.WriteLine("Arctan({0}) = {1}°", arctanValue, Math.Atan(arctanValue) * (180 / Math.PI));
                        string historyEntry = string.Format("Arctan({0}) = {1}°", arctanValue, Math.Atan(arctanValue) * (180 / Math.PI));
						AddToHistory(historyEntry);
                        Console.WriteLine("Press any key to make another calculations...");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                    break;
                case "9":
                    Console.Clear();
                    return;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 9.");
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                    break;
            }
		}
		}
		
		static void PerformUnitConversion()
		{
			while (true)
			{
			 Console.Clear();
			 Console.WriteLine("Perform Unit Conversions");
			 Console.WriteLine();
			 Console.WriteLine("Choose from different units: ");
			 Console.WriteLine("====================================================");
             Console.WriteLine();
			 Console.WriteLine("1. Length");
			 Console.WriteLine("====================================================");
             Console.WriteLine();
			 Console.WriteLine("2. Area");
			 Console.WriteLine("====================================================");
             Console.WriteLine();
			 Console.WriteLine("3. Volume");
			 Console.WriteLine("====================================================");
             Console.WriteLine();
			 Console.WriteLine("4. Weight");
			 Console.WriteLine("====================================================");
             Console.WriteLine();
			 Console.WriteLine("5. Temperature");
			 Console.WriteLine("====================================================");
             Console.WriteLine();
			 Console.WriteLine("6. Speed");
			 Console.WriteLine("====================================================");
             Console.WriteLine();
			 Console.WriteLine("7. Pressure");
			 Console.WriteLine("====================================================");
             Console.WriteLine();
             Console.WriteLine("8. Power");
			 Console.WriteLine("====================================================");
             Console.WriteLine();
			 Console.WriteLine("9. Return to main calculation choices");
			 Console.WriteLine();
			 
			 Console.Write("Enter your choice (1-9): ");
			 string operationChoice = Console.ReadLine();
			 
			 switch (operationChoice)
			 {
			 	case "1":
			 		Console.Clear();
			 		Console.WriteLine("Perform Length Unit Conversions");
			 		Console.WriteLine();
			 		Console.WriteLine("Metric Units: ");
			 		Console.WriteLine("====================================================");
             		Console.WriteLine();
			 		Console.WriteLine("1. Kilometer (km)");
			 		Console.WriteLine("====================================================");
             		Console.WriteLine();
			 		Console.WriteLine("2. Meter (m)");
			 		Console.WriteLine("====================================================");
             		Console.WriteLine();
			 		Console.WriteLine("3. Return to unit conversions");
			 		Console.WriteLine();
			 		
			 
			 Console.Write("Enter your choice (1-3): ");
			 string choiceCase1 = Console.ReadLine();
			 switch (choiceCase1)
			 {
			 		case "1":
			 		while (true)
			 		{
			 			Console.Clear();
			 			Console.Write("Enter the number in kilometers (km): ");
			 			double kilometers;
                    	if (double.TryParse(Console.ReadLine(), out kilometers))
                    		{
                        	Console.WriteLine(kilometers + " km = " + kilometers + " km");
                    		Console.WriteLine(kilometers + " km = " + kilometers * 1000 + " m");
                   			Console.WriteLine(kilometers + " km = " + kilometers * 10000 + " dm");
                    		Console.WriteLine(kilometers + " km = " + kilometers * 100000 + " cm");
                    		Console.WriteLine(kilometers + " km = " + kilometers * 1000000 + " mm");
                    		Console.WriteLine(kilometers + " km = " + kilometers * 1000000000 + " µm");
                    		Console.WriteLine(kilometers + " km = " + kilometers * 1000000000000 + " nm");
                    		Console.WriteLine(kilometers + " km = " + kilometers * 1000000000000000 + " pm");
                    		Console.WriteLine();
                    		Console.WriteLine();
                    		Console.WriteLine(kilometers + " km = " + Math.Round(kilometers * 39370.07874015748031, 7) + " inches");
                    		Console.WriteLine(kilometers + " km = " + Math.Round(kilometers * 0.0621371192237333969, 7) + " miles");
                    		Console.WriteLine(kilometers + " km = " + Math.Round(kilometers * 3280.83989501312336, 7) + " feet");
                    		Console.WriteLine(kilometers + " km = " + Math.Round(kilometers * 1093.613298337707787, 7) + " yards");
                    		
                    		string historyEntry = string.Format(kilometers + " km = " + kilometers + " km");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(kilometers + " km = " + kilometers * 1000 + " m");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(kilometers + " km = " + kilometers * 10000 + " dm");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(kilometers + " km = " + kilometers * 100000 + " cm");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(kilometers + " km = " + kilometers * 1000000 + " mm");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(kilometers + " km = " + kilometers * 1000000000 + " µm");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(kilometers + " km = " + kilometers * 1000000000000 + " nm");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(kilometers + " km = " + kilometers * 1000000000000000 + " pm");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(kilometers + " km = " + Math.Round(kilometers * 39370.07874015748031, 7) + " inches");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(kilometers + " km = " + Math.Round(kilometers * 0.0621371192237333969, 7) + " miles");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(kilometers + " km = " + Math.Round(kilometers * 3280.83989501312336, 7) + " feet");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(kilometers + " km = " + Math.Round(kilometers * 1093.613298337707787, 7) + " yards");
							AddToHistory(historyEntry);
							
                    		Console.WriteLine("Press any key to make another conversions...");
                        	Console.ReadKey();
                    		}
                    	else
                    	{
                        	Console.WriteLine("Invalid input. Please enter a valid number.");
                        	Console.Write("Press any key to continue...");
                        	Console.ReadKey(); continue;
                    	}
                    	break; 
			 		}
			 		break;
			 		
			 		case "2":
			 		while (true)
			 		{
			 			Console.Clear();
			 			Console.Write("Enter the number in meters (m): ");
			 			double meters;
                    	if (double.TryParse(Console.ReadLine(), out meters))
                    		{
                        	Console.WriteLine(meters + " m = " + meters + " m");
                    		Console.WriteLine(meters + " m = " + meters * 0.001 + " km");
                   			Console.WriteLine(meters + " m = " + meters * 10 + " dm");
                    		Console.WriteLine(meters + " m = " + meters * 100 + " cm");
                    		Console.WriteLine(meters + " m = " + meters * 1000 + " mm");
                    		Console.WriteLine(meters + " m = " + meters * 1000000 + " µm");
                    		Console.WriteLine(meters + " m = " + meters * 1000000000 + " nm");
                    		Console.WriteLine(meters + " m = " + meters * 1000000000000 + " pm");
                    		Console.WriteLine();
                    		Console.WriteLine();
                    		Console.WriteLine(meters + " m = " + Math.Round(meters * 39.3700787, 7) + " inches");
                    		Console.WriteLine(meters + " m = " + Math.Round(meters * 0.0006214, 7) + " miles");
                    		Console.WriteLine(meters + " m = " + Math.Round(meters * 3.2808399, 7) + " feet");
                    		Console.WriteLine(meters + " m = " + Math.Round(meters * 1.0936133, 7) + " yards");
                    		
                    		string historyEntry = string.Format(meters + " m = " + meters + " m");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(meters + " m = " + meters * 0.001 + " km");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(meters + " m = " + meters * 10 + " dm");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(meters + " m = " + meters * 100 + " cm");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(meters + " m = " + meters * 1000 + " mm");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(meters + " m = " + meters * 1000000 + " µm");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(meters + " m = " + meters * 1000000000 + " nm");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(meters + " m = " + meters * 1000000000000 + " pm");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(meters + " m = " + Math.Round(meters * 39.3700787, 7) + " inches");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(meters + " m = " + Math.Round(meters * 0.0006214, 7) + " miles");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(meters + " m = " + Math.Round(meters * 3.2808399, 7) + " feet");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(meters + " m = " + Math.Round(meters * 1.0936133, 7) + " yards");
							AddToHistory(historyEntry);
                        	
                    		Console.WriteLine("Press any key to make another conversions...");
                        	Console.ReadKey();
                    		}
                    	else
                    	{
                        	Console.WriteLine("Invalid input. Please enter a valid number.");
                        	Console.Write("Press any key to continue...");
                        	Console.ReadKey(); continue;
                    	}
                    	break; 
			 		}
			 		break;
			 		

			 		case "3":
                    Console.Clear();
                    PerformUnitConversion();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                    break;
			 }
			 break;
			 
			case "2":
			 	Console.Clear();
			 	Console.WriteLine("Perform Area Conversions");
			 		Console.WriteLine();
			 		Console.WriteLine("Metric Units: ");
			 		Console.WriteLine("====================================================");
             		Console.WriteLine();
			 		Console.WriteLine("1. Square Kilometer (km2)");
			 		Console.WriteLine("====================================================");
             		Console.WriteLine();
			 		Console.WriteLine("2. Square Meter (m2)");
			 		Console.WriteLine("====================================================");
             		Console.WriteLine();
			 		Console.WriteLine("3. Return to unit conversions");
			 		Console.WriteLine();
			 		
			 
			 Console.Write("Enter your choice (1-3): ");
			 string choiceCase2 = Console.ReadLine();
			 
			 switch (choiceCase2) {
			 		
			 	case "1":
			 		while (true) {
			 			Console.Clear();
			 			Console.Write("Enter the number in square kilometers (km2): ");
			 			double squareKilometers;
			 			if (double.TryParse(Console.ReadLine(), out squareKilometers)) {
			 				Console.WriteLine(squareKilometers + " km2 = " + Math.Round(squareKilometers * 1000000, 7) + " m2");
			 				Console.WriteLine(squareKilometers + " km2 = " + Math.Round(squareKilometers, 7) + " km2");
			 				Console.WriteLine(squareKilometers + " km2 = " + Math.Round(squareKilometers * 100000000, 7) + " dm2");
			 				Console.WriteLine(squareKilometers + " km2 = " + Math.Round(squareKilometers * 10000000000, 7) + " cm2");
			 				Console.WriteLine(squareKilometers + " km2 = " + Math.Round(squareKilometers * 1000000000000, 7) + " mm2");
			 				Console.WriteLine(squareKilometers + " km2 = " + Math.Round(squareKilometers * 100, 7) + " ha");
			 				Console.WriteLine(squareKilometers + " km2 = " + Math.Round(squareKilometers * 10000, 7) + " a");
			 				Console.WriteLine();
			 				Console.WriteLine();
			 				Console.WriteLine(squareKilometers + " km2 = " + Math.Round(squareKilometers * 1550003100.006200012, 7) + " in2");
			 				Console.WriteLine(squareKilometers + " km2 = " + Math.Round(squareKilometers * 0.386102158542445847, 7) + " mi2");
			 				Console.WriteLine(squareKilometers + " km2 = " + Math.Round(squareKilometers * 10763910.41670972231, 7) + " ft2");
			 				Console.WriteLine(squareKilometers + " km2 = " + Math.Round(squareKilometers * 1195990.046301080256, 7) + " yd2");
			 				Console.WriteLine(squareKilometers + " km2 = " + Math.Round(squareKilometers * 247.1054072593638123, 7) + " ac");
			 				Console.WriteLine(squareKilometers + " km2 = " + Math.Round(squareKilometers * 39536.86103474645476, 7) + " rd2");
			 				
			 				string historyEntry = string.Format(squareKilometers + " km2 = " + Math.Round(squareKilometers * 1000000, 7) + " m2");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(squareKilometers + " km2 = " + Math.Round(squareKilometers, 7) + " km2");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(squareKilometers + " km2 = " + Math.Round(squareKilometers * 100000000, 7) + " dm2");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(squareKilometers + " km2 = " + Math.Round(squareKilometers * 10000000000, 7) + " cm2");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(squareKilometers + " km2 = " + Math.Round(squareKilometers * 1000000000000, 7) + " mm2");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(squareKilometers + " km2 = " + Math.Round(squareKilometers * 100, 7) + " ha");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(squareKilometers + " km2 = " + Math.Round(squareKilometers * 10000, 7) + " a");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(squareKilometers + " km2 = " + Math.Round(squareKilometers * 1550003100.006200012, 7) + " in2");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(squareKilometers + " km2 = " + Math.Round(squareKilometers * 0.386102158542445847, 7) + " mi2");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(squareKilometers + " km2 = " + Math.Round(squareKilometers * 10763910.41670972231, 7) + " ft2");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(squareKilometers + " km2 = " + Math.Round(squareKilometers * 1195990.046301080256, 7) + " yd2");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(squareKilometers + " km2 = " + Math.Round(squareKilometers * 247.1054072593638123, 7) + " ac");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(squareKilometers + " km2 = " + Math.Round(squareKilometers * 39536.86103474645476, 7) + " rd2");
							AddToHistory(historyEntry);
			 				
			 				Console.WriteLine("Press any key to make another conversions...");
                        	Console.ReadKey();
			 			}
			 			else {
			 				Console.WriteLine("Invalid input. Please enter a valid number.");
                        	Console.Write("Press any key to continue...");
                        	Console.ReadKey(); continue;
			 			} break;
			 		}
			 		break;
			 		
			 	case "2":
			 		while (true)
			 		{
			 			Console.Clear();
			 			Console.Write("Enter the number in meters (m): ");
			 			double squareMeters;
                    	if (double.TryParse(Console.ReadLine(), out squareMeters))
                    		{
                        	Console.WriteLine(squareMeters + " m2 = " + Math.Round(squareMeters, 7) + " m2");
							Console.WriteLine(squareMeters + " m2 = " + Math.Round(squareMeters * 0.000001, 7) + " km2");
							Console.WriteLine(squareMeters + " m2 = " + Math.Round(squareMeters * 100, 7) + " dm2");
							Console.WriteLine(squareMeters + " m2 = " + Math.Round(squareMeters * 10000, 7) + " cm2");
							Console.WriteLine(squareMeters + " m2 = " + Math.Round(squareMeters * 1000000, 7) + " mm2");
							Console.WriteLine(squareMeters + " m2 = " + Math.Round(squareMeters * 0.0001, 7) + " ha");
							Console.WriteLine(squareMeters + " m2 = " + Math.Round(squareMeters * 0.01, 7) + " a");
							Console.WriteLine();
							Console.WriteLine();
							Console.WriteLine(squareMeters + " m2 = " + Math.Round(squareMeters * 1550.0031, 7) + " in2");
							Console.WriteLine(squareMeters + " m2 = " + Math.Round(squareMeters * 3.861e-7, 7) + " mi2");
							Console.WriteLine(squareMeters + " m2 = " + Math.Round(squareMeters * 10.7639104, 7) + " ft2");
							Console.WriteLine(squareMeters + " m2 = " + Math.Round(squareMeters * 1.19599, 7) + " yd2");
							Console.WriteLine(squareMeters + " m2 = " + Math.Round(squareMeters * 0.0002471, 7) + " ac");
							Console.WriteLine(squareMeters + " m2 = " + Math.Round(squareMeters * 0.0395369, 7) + " rd2");
							
							string historyEntry = string.Format(squareMeters + " m2 = " + Math.Round(squareMeters, 7) + " m2");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(squareMeters + " m2 = " + Math.Round(squareMeters * 0.000001, 7) + " km2");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(squareMeters + " m2 = " + Math.Round(squareMeters * 100, 7) + " dm2");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(squareMeters + " m2 = " + Math.Round(squareMeters * 10000, 7) + " cm2");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(squareMeters + " m2 = " + Math.Round(squareMeters * 1000000, 7) + " mm2");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(squareMeters + " m2 = " + Math.Round(squareMeters * 0.0001, 7) + " ha");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(squareMeters + " m2 = " + Math.Round(squareMeters * 0.01, 7) + " a");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(squareMeters + " m2 = " + Math.Round(squareMeters * 1550.0031, 7) + " in2");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(squareMeters + " m2 = " + Math.Round(squareMeters * 3.861e-7, 7) + " mi2");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(squareMeters + " m2 = " + Math.Round(squareMeters * 10.7639104, 7) + " ft2");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(squareMeters + " m2 = " + Math.Round(squareMeters * 1.19599, 7) + " yd2");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(squareMeters + " m2 = " + Math.Round(squareMeters * 0.0002471, 7) + " ac");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(squareMeters + " m2 = " + Math.Round(squareMeters * 0.0395369, 7) + " rd2");
							AddToHistory(historyEntry);

                        	Console.WriteLine("Press any key to make another conversions...");
                        	Console.ReadKey();
                    		}
                    	else
                    	{
                        	Console.WriteLine("Invalid input. Please enter a valid number.");
                        	Console.Write("Press any key to continue...");
                        	Console.ReadKey(); continue;
                    	}
                    	break; 
			 		}
			 		break;
			 		
			 	case "3":
			 		Console.Clear();
                    PerformUnitConversion();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                    break;
			 } break;
			 
			case "3":
			 Console.Clear();
			 	Console.WriteLine("Perform Volume Conversions");
			 		Console.WriteLine();
			 		Console.WriteLine("Metric Units: ");
			 		Console.WriteLine("====================================================");
             		Console.WriteLine();
			 		Console.WriteLine("1. Cubic meter (m3)");
			 		Console.WriteLine("====================================================");
             		Console.WriteLine();
			 		Console.WriteLine("2. Liter (l)");
			 		Console.WriteLine("====================================================");
             		Console.WriteLine();
			 		Console.WriteLine("3. Return to unit conversions");
			 		Console.WriteLine();
			 		
			 
			 Console.Write("Enter your choice (1-3): ");
			 string choiceCase3 = Console.ReadLine();
			 
			 switch (choiceCase3) {
			 	
			 	case "1":
			 		while (true) {
			 			Console.Clear();
			 			Console.Write("Enter the number in cubic meters (m3): ");
			 			double cubicMeters;
			 			if (double.TryParse(Console.ReadLine(), out cubicMeters)) {
			 				Console.WriteLine(cubicMeters + " m3 = " + Math.Round(cubicMeters, 7) + " m3");
			 				Console.WriteLine(cubicMeters + " m3 = " + Math.Round(cubicMeters * 10, 7) + " hl");
			 				Console.WriteLine(cubicMeters + " m3 = " + Math.Round(cubicMeters * 1000, 7) + " dm3");
			 				Console.WriteLine(cubicMeters + " m3 = " + Math.Round(cubicMeters * 1000000, 7) + " cm3");
			 				Console.WriteLine(cubicMeters + " m3 = " + Math.Round(cubicMeters * 1000000000, 7) + " mm3");
			 				Console.WriteLine();
			 				Console.WriteLine();
			 				Console.WriteLine(cubicMeters + " m3 = " + Math.Round(cubicMeters * 1000, 7) + " l");
			 				Console.WriteLine(cubicMeters + " m3 = " + Math.Round(cubicMeters * 10000, 7) + " dl");
			 				Console.WriteLine(cubicMeters + " m3 = " + Math.Round(cubicMeters * 100000, 7) + " cl");
			 				Console.WriteLine(cubicMeters + " m3 = " + Math.Round(cubicMeters * 1000000, 7) + " ml");
			 				
			 				string historyEntry = string.Format(cubicMeters + " m3 = " + Math.Round(cubicMeters, 7) + " m3");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(cubicMeters + " m3 = " + Math.Round(cubicMeters * 10, 7) + " hl");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(cubicMeters + " m3 = " + Math.Round(cubicMeters * 1000, 7) + " dm3");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(cubicMeters + " m3 = " + Math.Round(cubicMeters * 1000000, 7) + " cm3");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(cubicMeters + " m3 = " + Math.Round(cubicMeters * 1000000000, 7) + " mm3");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(cubicMeters + " m3 = " + Math.Round(cubicMeters * 1000, 7) + " l");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(cubicMeters + " m3 = " + Math.Round(cubicMeters * 10000, 7) + " dl");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(cubicMeters + " m3 = " + Math.Round(cubicMeters * 100000, 7) + " cl");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(cubicMeters + " m3 = " + Math.Round(cubicMeters * 1000000, 7) + " ml");
							AddToHistory(historyEntry);
			 				
			 			Console.WriteLine("Press any key to make another conversions...");
                        	Console.ReadKey();
                    		}
                    	else
                    	{
                        	Console.WriteLine("Invalid input. Please enter a valid number.");
                        	Console.Write("Press any key to continue...");
                        	Console.ReadKey(); continue;
                    	} break;
			 		}
			 		break;
			 		
			 	case "2":
			 		while (true) {
			 			Console.Clear();
			 			Console.Write("Enter the number in liters (l): ");
			 			double liters;
			 			if (double.TryParse(Console.ReadLine(), out liters)) {
			 				Console.WriteLine(liters + " l = " + Math.Round(liters * 0.001, 7) + " m3");
			 				Console.WriteLine(liters + " l = " + Math.Round(liters * 0.01, 7) + " hl");
			 				Console.WriteLine(liters + " l = " + Math.Round(liters * 1, 7) + " dm3");
			 				Console.WriteLine(liters + " l = " + Math.Round(liters * 1000, 7) + " cm3");
			 				Console.WriteLine(liters + " l = " + Math.Round(liters * 1000000, 7) + " mm3");
			 				Console.WriteLine();
			 				Console.WriteLine();
			 				Console.WriteLine(liters + " l = " + Math.Round(liters * 1, 7) + " l");
			 				Console.WriteLine(liters + " l = " + Math.Round(liters * 10, 7) + " dl");
			 				Console.WriteLine(liters + " l = " + Math.Round(liters * 100, 7) + " cl");
			 				Console.WriteLine(liters + " l = " + Math.Round(liters * 1000, 7) + " ml");
			 				
			 				string historyEntry = string.Format(liters + " l = " + Math.Round(liters * 0.001, 7) + " m3");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(liters + " l = " + Math.Round(liters * 0.01, 7) + " hl");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(liters + " l = " + Math.Round(liters * 1, 7) + " dm3");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(liters + " l = " + Math.Round(liters * 1000, 7) + " cm3");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(liters + " l = " + Math.Round(liters * 1000000, 7) + " mm3");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(liters + " l = " + Math.Round(liters * 1, 7) + " l");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(liters + " l = " + Math.Round(liters * 10, 7) + " dl");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(liters + " l = " + Math.Round(liters * 100, 7) + " cl");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(liters + " l = " + Math.Round(liters * 1000, 7) + " ml");
							AddToHistory(historyEntry);
			 				
			 				Console.WriteLine("Press any key to make another conversions...");
                        	Console.ReadKey();
			 			}
			 			else {
			 				Console.WriteLine("Invalid input. Please enter a valid number.");
                        	Console.Write("Press any key to continue...");
                        	Console.ReadKey(); continue;
			 			} break;
			 		}
			 		break;
			 		
			 	case "3":
			 		Console.Clear();
			 		PerformUnitConversion();
			 		break;
			 	default:
                    Console.Clear();
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                    break;
			 } break;
			 
			case "4":
			 Console.Clear();
			 Console.WriteLine("Perform Weight Conversion");
			 Console.WriteLine();
			 Console.WriteLine("====================================================");
             Console.WriteLine();
			 Console.WriteLine("1. Kilogram (kg)");
			 Console.WriteLine("====================================================");
             Console.WriteLine();
			 Console.WriteLine("2. Pound (lb)");
			 Console.WriteLine("====================================================");
             Console.WriteLine();
			 Console.WriteLine("3. Return to unit conversions");
			 Console.WriteLine();
			 
			 Console.WriteLine();
			 Console.Write("Enter your choice (1-3): ");
			 string choiceCase4 = Console.ReadLine();
			 switch (choiceCase4) {
			 		
			 	case "1":
			 		while (true) {
			 			Console.Clear();
			 			Console.Write("Enter the number in kilograms (kg): ");
			 			double kilograms;
			 			if (double.TryParse(Console.ReadLine(), out kilograms)) {
			 				Console.WriteLine(kilograms + " kg = " + Math.Round(kilograms, 7) + " kg");
			 				Console.WriteLine(kilograms + " kg = " + Math.Round(kilograms * 1000, 7) + " g");
			 				Console.WriteLine(kilograms + " kg = " + Math.Round(kilograms * 1000000, 7) + " mg");
			 				Console.WriteLine(kilograms + " kg = " + Math.Round(kilograms * 0.001, 7) + " t");
			 				Console.WriteLine(kilograms + " kg = " + Math.Round(kilograms * 5000, 7) + " ct");
			 				Console.WriteLine();
			 				Console.WriteLine();
			 				Console.WriteLine(kilograms + " kg = " + Math.Round(kilograms * 2.2046226, 7) + " lb");
			 				Console.WriteLine(kilograms + " kg = " + Math.Round(kilograms * 35.2739619, 7) + " oz");
			 				Console.WriteLine(kilograms + " kg = " + Math.Round(kilograms * 15432.3583529, 7) + " gr");
			 				
			 				string historyEntry = string.Format(kilograms + " kg = " + Math.Round(kilograms, 7) + " kg");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(kilograms + " kg = " + Math.Round(kilograms * 1000, 7) + " g");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(kilograms + " kg = " + Math.Round(kilograms * 1000000, 7) + " mg");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(kilograms + " kg = " + Math.Round(kilograms * 0.001, 7) + " t");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(kilograms + " kg = " + Math.Round(kilograms * 5000, 7) + " ct");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(kilograms + " kg = " + Math.Round(kilograms * 2.2046226, 7) + " lb");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(kilograms + " kg = " + Math.Round(kilograms * 35.2739619, 7) + " oz");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(kilograms + " kg = " + Math.Round(kilograms * 15432.3583529, 7) + " gr");
							AddToHistory(historyEntry);
			 				
			 				Console.WriteLine("Press any key to make another conversions...");
                        	Console.ReadKey();
			 			}
			 			else {
			 				Console.WriteLine("Invalid input. Please enter a valid number.");
                        	Console.Write("Press any key to continue...");
                        	Console.ReadKey(); continue;
			 			} break;
			 		}
			 		break;
			 		
			 	case "2":
			 		while (true) {
			 			Console.Clear();
			 			Console.Write("Enter the number in pounds (lb): ");
			 			double pounds;
			 			if (double.TryParse(Console.ReadLine(), out pounds)) {
			 				Console.WriteLine(pounds + " lb = " + Math.Round(pounds * 0.453592374495299, 7) + " kg");
			 				Console.WriteLine(pounds + " lb = " + Math.Round(pounds * 453.592374495299, 7) + " g");
			 				Console.WriteLine(pounds + " lb = " + Math.Round(pounds * 453529.374495299, 7) + " mg");
			 				Console.WriteLine(pounds + " lb = " + Math.Round(pounds * 0.000453592374495299, 7) + " t");
			 				Console.WriteLine(pounds + " lb = " + Math.Round(pounds * 2267.961872476495, 7) + " ct");
			 				Console.WriteLine();
			 				Console.WriteLine();
			 				Console.WriteLine(pounds + " lb = " + Math.Round(pounds * 1, 7) + " lb");
			 				Console.WriteLine(pounds + " lb = " + Math.Round(pounds * 16.0000001360777086551081, 7) + " oz");
			 				Console.WriteLine(pounds + " lb = " + Math.Round(pounds * 7000.0000693542724444330171, 7) + " gr");
			 				
			 				string historyEntry = string.Format(pounds + " lb = " + Math.Round(pounds * 0.453592374495299, 7) + " kg");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(pounds + " lb = " + Math.Round(pounds * 453.592374495299, 7) + " g");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(pounds + " lb = " + Math.Round(pounds * 453529.374495299, 7) + " mg");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(pounds + " lb = " + Math.Round(pounds * 0.000453592374495299, 7) + " t");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(pounds + " lb = " + Math.Round(pounds * 2267.961872476495, 7) + " ct");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(pounds + " lb = " + Math.Round(pounds * 1, 7) + " lb");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(pounds + " lb = " + Math.Round(pounds * 16.0000001360777086551081, 7) + " oz");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(pounds + " lb = " + Math.Round(pounds * 7000.0000693542724444330171, 7) + " gr");
							AddToHistory(historyEntry);
			 				
			 				Console.WriteLine("Press any key to make another conversions...");
                        	Console.ReadKey();
			 			}
			 			else {
			 				Console.WriteLine("Invalid input. Please enter a valid number.");
                        	Console.Write("Press any key to continue...");
                        	Console.ReadKey(); continue;
			 			} break;
			 		}
			 		break;
			 		
			 	case "3":
			 		Console.Clear();
			 		PerformUnitConversion();
			 		break;
			 	default:
                    Console.Clear();
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                    break;
			 }
			 break;
			 
			case "5":
			 Console.Clear();
			 Console.WriteLine("Perform Temperature Conversion");
			 Console.WriteLine();
			 Console.WriteLine("====================================================");
             Console.WriteLine();
			 Console.WriteLine("1. Degree Celsius (°C)");
			 Console.WriteLine("====================================================");
             Console.WriteLine();
			 Console.WriteLine("2. Degrees Fahrenheit (°F)");
			 Console.WriteLine("====================================================");
             Console.WriteLine();
			 Console.WriteLine("3. Kelvin (K)");
			 Console.WriteLine("====================================================");
             Console.WriteLine();
			 Console.WriteLine("4. Return to unit conversions");
			 Console.WriteLine();
			 
			 Console.WriteLine();
			 Console.Write("Enter your choice (1-4): ");
			 string choiceCase5 = Console.ReadLine();
			 switch (choiceCase5) {
			 		
			 	case "1":
			 		while (true) {
			 			Console.Clear();
			 			Console.Write("Enter the number in degree celsius (°C): ");
			 			double celsius;
			 			if (double.TryParse(Console.ReadLine(), out celsius)) {
			 				Console.WriteLine(celsius + " °C = " + celsius + "°C");
			 				Console.WriteLine(celsius + " °C = " + ((1.8 * celsius) + 32) + "°F");
			 				Console.WriteLine(celsius + " °C = " + (celsius + 273.15) + " K");
			 				
			 				string historyEntry = string.Format(celsius + " °C = " + celsius + "°C");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(celsius + " °C = " + ((1.8 * celsius) + 32) + "°F");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(celsius + " °C = " + (celsius + 273.15) + " K");
							AddToHistory(historyEntry);
			 				
			 				Console.WriteLine("Press any key to make another conversions...");
                        	Console.ReadKey();
			 			}
			 			else {
			 				Console.WriteLine("Invalid input. Please enter a valid number.");
                        	Console.Write("Press any key to continue...");
                        	Console.ReadKey(); continue;
			 			} break;
			 		}
			 		break;
			 		
			 	case "2":
			 		while (true) {
			 			Console.Clear();
			 			Console.Write("Enter the number in degree fahrenheit (°F): ");
			 			double fahrenheit;
			 			if (double.TryParse(Console.ReadLine(), out fahrenheit)) {
			 				Console.WriteLine(fahrenheit + " °F = " + fahrenheit + "°F");
			 				Console.WriteLine(fahrenheit + " °F = " + ((fahrenheit - 32) / 1.8) + "°C");
			 				Console.WriteLine(fahrenheit + " °F = " + (((fahrenheit - 32) / 1.8) + 273.15) + " K");
			 				
			 				string historyEntry = string.Format(fahrenheit + " °F = " + fahrenheit + "°F");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(fahrenheit + " °F = " + ((fahrenheit - 32) / 1.8) + "°C");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(fahrenheit + " °F = " + (((fahrenheit - 32) / 1.8) + 273.15) + " K");
							AddToHistory(historyEntry);
			 				
			 				Console.WriteLine("Press any key to make another conversions...");
                        	Console.ReadKey();
			 			}
			 			else {
			 				Console.WriteLine("Invalid input. Please enter a valid number.");
                        	Console.Write("Press any key to continue...");
                        	Console.ReadKey(); continue;
			 			} break;
			 		}
			 		break;
			 		
			 	case "3":
			 		while (true) {
			 			Console.Clear();
			 			Console.Write("Enter the number in kelvin (K): ");
			 			double kelvin;
			 			if (double.TryParse(Console.ReadLine(), out kelvin)) {
			 				Console.WriteLine(kelvin + " K = " + kelvin + " K");
			 				Console.WriteLine(kelvin + " K = " + (kelvin - 273.15) + "°C");
			 				Console.WriteLine(kelvin + " K = " + (((kelvin - 273.15) * 1.8) + 32) + "°F");
			 				
			 				string historyEntry = string.Format(kelvin + " K = " + kelvin + " K");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(kelvin + " K = " + (kelvin - 273.15) + "°C");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(kelvin + " K = " + (((kelvin - 273.15) * 1.8) + 32) + "°F");
							AddToHistory(historyEntry);
			 				
			 				Console.WriteLine("Press any key to make another conversions...");
                        	Console.ReadKey();
			 			}
			 			else {
			 				Console.WriteLine("Invalid input. Please enter a valid number.");
                        	Console.Write("Press any key to continue...");
                        	Console.ReadKey(); continue;
			 			} break;
			 		}
			 		break;
			 		
			 	case "4":
			 		Console.Clear();
			 		PerformUnitConversion();
			 		break;
			 	default:
                    Console.Clear();
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                    break;
			 }
			 break;
			 
			case "6":
			 Console.Clear();
			 Console.WriteLine("Perform Speed Conversion");
			 Console.WriteLine();
			 Console.WriteLine("====================================================");
             Console.WriteLine();
			 Console.WriteLine("1. Meter/second (m/s)");
			 Console.WriteLine("====================================================");
             Console.WriteLine();
			 Console.WriteLine("2. Kilometer/hour (km/h)");
			 Console.WriteLine("====================================================");
             Console.WriteLine();
			 Console.WriteLine("3. Mile/hour (mph)");
			 Console.WriteLine("====================================================");
             Console.WriteLine();
			 Console.WriteLine("4. Mach (Ma)");
			 Console.WriteLine("====================================================");
             Console.WriteLine();
			 Console.WriteLine("5. Return to unit conversions");
			 
			 Console.WriteLine();
			 Console.Write("Enter your choice (1-5): ");
			 string choiceCase6 = Console.ReadLine();
			 switch (choiceCase6) {
			 	
			 	case "1":
			 		while (true) {
			 			Console.Clear();
			 			Console.Write("Enter the number in meter/second (m/s): ");
			 			double meterPerSecond;
			 			if (double.TryParse(Console.ReadLine(), out meterPerSecond)) {
			 				Console.WriteLine(meterPerSecond + " m/s = " + meterPerSecond + "m/s");
			 				Console.WriteLine(meterPerSecond + " m/s = " + (meterPerSecond * 3.6) + "km/h");
			 				Console.WriteLine(meterPerSecond + " m/s = " + (meterPerSecond * 2.236936) + " mph");
			 				Console.WriteLine(meterPerSecond + " m/s = " + (meterPerSecond * 0.0029386) + "Ma");
			 				
			 				string historyEntry = string.Format(meterPerSecond + " m/s = " + meterPerSecond + "m/s");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(meterPerSecond + " m/s = " + (meterPerSecond * 3.6) + "km/h");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(meterPerSecond + " m/s = " + (meterPerSecond * 2.236936) + " mph");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(meterPerSecond + " m/s = " + (meterPerSecond * 0.0029386) + "Ma");
							AddToHistory(historyEntry);
			 				
			 				Console.WriteLine("Press any key to make another conversions...");
                        	Console.ReadKey();
			 			}
			 			else {
			 				Console.WriteLine("Invalid input. Please enter a valid number.");
                        	Console.Write("Press any key to continue...");
                        	Console.ReadKey(); continue;
			 			} break;
			 		}
			 		break;
			 		
			 	case "2":
			 		while (true) {
			 			Console.Clear();
			 			Console.Write("Enter the number in kilometer/hour (km/h): ");
			 			double kilometerPerHour;
			 			if (double.TryParse(Console.ReadLine(), out kilometerPerHour)) {
			 				Console.WriteLine(kilometerPerHour + " km/h = " + (kilometerPerHour * 0.277777777777778) + "m/s");
			 				Console.WriteLine(kilometerPerHour + " km/h = " + kilometerPerHour + "km/h");
			 				Console.WriteLine(kilometerPerHour + " km/h = " + (kilometerPerHour * 0.621371111111111608208) + " mph");
			 				Console.WriteLine(kilometerPerHour + " km/h = " + (kilometerPerHour * 0.0008162777777777784308) + "Ma");
			 				
			 				string historyEntry = string.Format(kilometerPerHour + " km/h = " + (kilometerPerHour * 0.277777777777778) + "m/s");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(kilometerPerHour + " km/h = " + kilometerPerHour + "km/h");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(kilometerPerHour + " km/h = " + (kilometerPerHour * 0.621371111111111608208) + " mph");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(kilometerPerHour + " km/h = " + (kilometerPerHour * 0.0008162777777777784308) + "Ma");
							AddToHistory(historyEntry);
			 				
			 				Console.WriteLine("Press any key to make another conversions...");
                        	Console.ReadKey();
			 			}
			 			else {
			 				Console.WriteLine("Invalid input. Please enter a valid number.");
                        	Console.Write("Press any key to continue...");
                        	Console.ReadKey(); continue;
			 			} break;
			 		}
			 		break;
			 		
			 	case "3":
			 		while (true) {
			 			Console.Clear();
			 			Console.Write("Enter the number in mile/hour (mph): ");
			 			double milePerHour;
			 			if (double.TryParse(Console.ReadLine(), out milePerHour)) {
			 				Console.WriteLine(milePerHour + " mph = " + (milePerHour * 0.44704005836555) + "m/s");
			 				Console.WriteLine(milePerHour + " mph = " + (milePerHour * 1.60934421011598) + "km/h");
			 				Console.WriteLine(milePerHour + " mph = " + milePerHour + " mph");
			 				Console.WriteLine(milePerHour + " mph = " + (milePerHour * 0.00131367191551300523) + "Ma");
			 				
			 				string historyEntry = string.Format(milePerHour + " mph = " + (milePerHour * 0.44704005836555) + "m/s");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(milePerHour + " mph = " + (milePerHour * 1.60934421011598) + "km/h");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(milePerHour + " mph = " + milePerHour + " mph");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(milePerHour + " mph = " + (milePerHour * 0.00131367191551300523) + "Ma");
							AddToHistory(historyEntry);
			 				
			 				Console.WriteLine("Press any key to make another conversions...");
                        	Console.ReadKey();
			 			}
			 			else {
			 				Console.WriteLine("Invalid input. Please enter a valid number.");
                        	Console.Write("Press any key to continue...");
                        	Console.ReadKey(); continue;
			 			} break;
			 		}
			 		break;
			 		
			 	case "4":
			 		while (true) {
			 			Console.Clear();
			 			Console.Write("Enter the number in Mach (Ma): ");
			 			double mach;
			 			if (double.TryParse(Console.ReadLine(), out mach)) {
			 				Console.WriteLine(mach + " Ma = " + (mach * 340.2981101136595658) + "m/s");
			 				Console.WriteLine(mach + " Ma = " + (mach * 1225.0731640917443688) + "km/h");
			 				Console.WriteLine(mach + " Ma = " + (mach * 761.225073164091744823888) + " mph");
			 				Console.WriteLine(mach + " Ma = " + mach + "Ma");
			 				
			 				string historyEntry = string.Format(mach + " Ma = " + (mach * 340.2981101136595658) + "m/s");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(mach + " Ma = " + (mach * 1225.0731640917443688) + "km/h");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(mach + " Ma = " + (mach * 761.225073164091744823888) + " mph");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(mach + " Ma = " + mach + "Ma");
							AddToHistory(historyEntry);
			 				
			 				Console.WriteLine("Press any key to make another conversions...");
                        	Console.ReadKey();
			 			}
			 			else {
			 				Console.WriteLine("Invalid input. Please enter a valid number.");
                        	Console.Write("Press any key to continue...");
                        	Console.ReadKey(); continue;
			 			} break;
			 		}
			 		break;
			 		
			 	case "5":
			 		Console.Clear();
			 		PerformUnitConversion();
			 		break;
			 	default:
                    Console.Clear();
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                    break;
			 }
			 break;
			 
			case "7":
			 Console.Clear();
			 Console.WriteLine("Perform Pressure Conversion");
			 Console.WriteLine();
			 Console.WriteLine("====================================================");
             Console.WriteLine();
			 Console.WriteLine("1. Standard atmosphere (atm)");
			 Console.WriteLine("====================================================");
             Console.WriteLine();
			 Console.WriteLine("2. Hectopascal (hPa)");
			 Console.WriteLine("====================================================");
             Console.WriteLine();
			 Console.WriteLine("3. Kilopascal (kPa)");
			 Console.WriteLine("====================================================");
             Console.WriteLine();
			 Console.WriteLine("4. Pounds/square inch (psi)");
			 Console.WriteLine("====================================================");
             Console.WriteLine();
			 Console.WriteLine("5. Return to unit conversions");
			 
			 Console.WriteLine();
			 Console.Write("Enter your choice (1-5): ");
			 string choiceCase7 = Console.ReadLine();
			 switch (choiceCase7) {
			 		
			 	case "1":
			 		while (true) {
			 			Console.Clear();
			 			Console.Write("Enter the number in standard atmosphere (atm): ");
			 			double atm;
			 			if (double.TryParse(Console.ReadLine(), out atm)) {
			 				Console.WriteLine(atm + " atm = " + atm + " atm");
			 				Console.WriteLine(atm + " atm = " + (atm * 1013.250273830886503) + " hPa");
			 				Console.WriteLine(atm + " atm = " + (atm * 101.3250273830886503) + " kPa");
			 				Console.WriteLine(atm + " atm = " + (atm * 14.695952977081292059162322) + " psi");
			 				
			 				string historyEntry = string.Format(atm + " atm = " + atm + " atm");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(atm + " atm = " + (atm * 1013.250273830886503) + " hPa");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(atm + " atm = " + (atm * 101.3250273830886503) + " kPa");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(atm + " atm = " + (atm * 14.695952977081292059162322) + " psi");
							AddToHistory(historyEntry);
			 				
			 				Console.WriteLine("Press any key to make another conversions...");
                        	Console.ReadKey();
			 			}
			 			else {
			 				Console.WriteLine("Invalid input. Please enter a valid number.");
                        	Console.Write("Press any key to continue...");
                        	Console.ReadKey(); continue;
			 			} break;
			 		}
			 		break;
			 		
			 	case "2":
			 		while (true) {
			 			Console.Clear();
			 			Console.Write("Enter the number in hectopascal (hPa): ");
			 			double hPa;
			 			if (double.TryParse(Console.ReadLine(), out hPa)) {
			 				Console.WriteLine(hPa + " hPa = " + (hPa * 0.000986923) + " atm");
			 				Console.WriteLine(hPa + " hPa = " + hPa + " hPa");
			 				Console.WriteLine(hPa + " hPa = " + (hPa * 0.01) + " kPa");
			 				Console.WriteLine(hPa + " hPa = " + (hPa * 0.014503774) + " psi");
			 				
			 				string historyEntry = string.Format(hPa + " hPa = " + (hPa * 0.000986923) + " atm");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(hPa + " hPa = " + hPa + " hPa");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(hPa + " hPa = " + (hPa * 0.01) + " kPa");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(hPa + " hPa = " + (hPa * 0.014503774) + " psi");
							AddToHistory(historyEntry);
			 				
			 				Console.WriteLine("Press any key to make another conversions...");
                        	Console.ReadKey();
			 			}
			 			else {
			 				Console.WriteLine("Invalid input. Please enter a valid number.");
                        	Console.Write("Press any key to continue...");
                        	Console.ReadKey(); continue;
			 			} break;
			 		}
			 		break;
			 		
			 	case "3":
			 		while (true) {
			 			Console.Clear();
			 			Console.Write("Enter the number in kilopascal (kPa): ");
			 			double kPa;
			 			if (double.TryParse(Console.ReadLine(), out kPa)) {
			 				Console.WriteLine(kPa + " hPa = " + (kPa * 0.00986923) + " atm");
			 				Console.WriteLine(kPa + " hPa = " + (kPa * 10) + " hPa");
			 				Console.WriteLine(kPa + " hPa = " + kPa + " kPa");
			 				Console.WriteLine(kPa + " hPa = " + (kPa * 0.14503774) + " psi");
			 				
			 				string historyEntry = string.Format(kPa + " hPa = " + (kPa * 0.00986923) + " atm");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(kPa + " hPa = " + (kPa * 10) + " hPa");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(kPa + " hPa = " + kPa + " kPa");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(kPa + " hPa = " + (kPa * 0.14503774) + " psi");
							AddToHistory(historyEntry);
			 				
			 				Console.WriteLine("Press any key to make another conversions...");
                        	Console.ReadKey();
			 			}
			 			else {
			 				Console.WriteLine("Invalid input. Please enter a valid number.");
                        	Console.Write("Press any key to continue...");
                        	Console.ReadKey(); continue;
			 			} break;
			 		}
			 		break;
			 		
			 	case "4":
			 		while (true) {
			 			Console.Clear();
			 			Console.Write("Enter the number in pounds/square inch (psi): ");
			 			double psi;
			 			if (double.TryParse(Console.ReadLine(), out psi)) {
			 				Console.WriteLine(psi + " hPa = " + (psi * 0.068045944455560325500939) + " atm");
			 				Console.WriteLine(psi + " hPa = " + (psi * 68.947571852677793) + " hPa");
			 				Console.WriteLine(psi + " hPa = " + (psi * 6.8947571852677793) + " kPa");
			 				Console.WriteLine(psi + " hPa = " + psi + " psi");
			 				
			 				string historyEntry = string.Format(psi + " hPa = " + (psi * 0.068045944455560325500939) + " atm");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(psi + " hPa = " + (psi * 68.947571852677793) + " hPa");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(psi + " hPa = " + (psi * 6.8947571852677793) + " kPa");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(psi + " hPa = " + psi + " psi");
							AddToHistory(historyEntry);
			 				
			 				Console.WriteLine("Press any key to make another conversions...");
                        	Console.ReadKey();
			 			}
			 			else {
			 				Console.WriteLine("Invalid input. Please enter a valid number.");
                        	Console.Write("Press any key to continue...");
                        	Console.ReadKey(); continue;
			 			} break;
			 		}
			 		break;
			 		
			 	case "5":
			 		Console.Clear();
			 		PerformUnitConversion();
			 		break;
			 	default:
                    Console.Clear();
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                    break;	
			 }
			 break;
			 
			case "8":
			 Console.Clear();
			 Console.WriteLine("Perform Power Conversion");
			 Console.WriteLine();
			 Console.WriteLine("====================================================");
             Console.WriteLine();
			 Console.WriteLine("1.Watt (W)");
			 Console.WriteLine("====================================================");
             Console.WriteLine();
			 Console.WriteLine("2. Kilowatt (kW)");
			 Console.WriteLine("====================================================");
             Console.WriteLine();
			 Console.WriteLine("3. Imperial Horsepower (hp)");
			 Console.WriteLine("====================================================");
             Console.WriteLine();
			 Console.WriteLine("4. Metric Horsepower (PS)");
			 Console.WriteLine("====================================================");
             Console.WriteLine();
			 Console.WriteLine("5. Return to unit conversions");
			 
			 Console.WriteLine();
			 Console.Write("Enter your choice (1-5): ");
			 string choiceCase8 = Console.ReadLine();
			 switch (choiceCase8) {
			 		
			 	case "1":
			 		while (true) {
			 			Console.Clear();
			 			Console.Write("Enter the number in watt (W): ");
			 			double watt;
			 			if (double.TryParse(Console.ReadLine(), out watt)) {
			 				Console.WriteLine(watt + " W = " + watt + " W");
			 				Console.WriteLine(watt + " W = " + (watt * 0.001) + " kW");
			 				Console.WriteLine(watt + " W = " + (watt * 0.0013410221) + " hp");
			 				Console.WriteLine(watt + " W = " + (watt * 0.0013596216) + " PS");
			 				
			 				string historyEntry = string.Format(watt + " W = " + watt + " W");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(watt + " W = " + (watt * 0.001) + " kW");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(watt + " W = " + (watt * 0.0013410221) + " hp");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(watt + " W = " + (watt * 0.0013596216) + " PS");
							AddToHistory(historyEntry);
			 				
			 				Console.WriteLine("Press any key to make another conversions...");
                        	Console.ReadKey();
			 			}
			 			else {
			 				Console.WriteLine("Invalid input. Please enter a valid number.");
                        	Console.Write("Press any key to continue...");
                        	Console.ReadKey(); continue;
			 			} break;
			 		}
			 		break;
			 		
			 	case "2":
			 		while (true) {
			 			Console.Clear();
			 			Console.Write("Enter the number in kilowatt (kW): ");
			 			double kilowatt;
			 			if (double.TryParse(Console.ReadLine(), out kilowatt)) {
			 				Console.WriteLine(kilowatt + " kW = " + (kilowatt * 1000) + " W");
			 				Console.WriteLine(kilowatt + " kW = " + kilowatt + " kW");
			 				Console.WriteLine(kilowatt + " kW = " + (kilowatt * 1.3410221) + " hp");
			 				Console.WriteLine(kilowatt + " kW = " + (kilowatt * 1.3596216) + " PS");
			 				
			 				string historyEntry = string.Format(kilowatt + " kW = " + (kilowatt * 1000) + " W");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(kilowatt + " kW = " + kilowatt + " kW");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(kilowatt + " kW = " + (kilowatt * 1.3410221) + " hp");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(kilowatt + " kW = " + (kilowatt * 1.3596216) + " PS");
							AddToHistory(historyEntry);
			 				
			 				Console.WriteLine("Press any key to make another conversions...");
                        	Console.ReadKey();
			 			}
			 			else {
			 				Console.WriteLine("Invalid input. Please enter a valid number.");
                        	Console.Write("Press any key to continue...");
                        	Console.ReadKey(); continue;
			 			} break;
			 		}
			 		break;
			 		
			 	case "3":
			 		while (true) {
			 			Console.Clear();
			 			Console.Write("Enter the number in imperial horsepower (hp): ");
			 			double iHorsepower;
			 			if (double.TryParse(Console.ReadLine(), out iHorsepower)) {
			 				Console.WriteLine(iHorsepower + " hp = " + (iHorsepower * 745.699865796395153) + " W");
			 				Console.WriteLine(iHorsepower + " hp = " + (iHorsepower * 0.745699865796395153) + " kW");
			 				Console.WriteLine(iHorsepower + " hp = " + iHorsepower + " hp");
			 				Console.WriteLine(iHorsepower + " hp = " + (iHorsepower * 1.0138696446538800521541048) + " PS");
			 				
			 				string historyEntry = string.Format(iHorsepower + " hp = " + (iHorsepower * 745.699865796395153) + " W");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(iHorsepower + " hp = " + (iHorsepower * 0.745699865796395153) + " kW");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(iHorsepower + " hp = " + iHorsepower + " hp");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(iHorsepower + " hp = " + (iHorsepower * 1.0138696446538800521541048) + " PS");
							AddToHistory(historyEntry);
			 				
			 				Console.WriteLine("Press any key to make another conversions...");
                        	Console.ReadKey();
			 			}
			 			else {
			 				Console.WriteLine("Invalid input. Please enter a valid number.");
                        	Console.Write("Press any key to continue...");
                        	Console.ReadKey(); continue;
			 			} break;
			 		}
			 		break;
			 		
			 	case "4":
			 		while (true) {
			 			Console.Clear();
			 			Console.Write("Enter the number in metric horsepower (PS): ");
			 			double mHorsepower;
			 			if (double.TryParse(Console.ReadLine(), out mHorsepower)) {
			 				Console.WriteLine(mHorsepower + " PS = " + (mHorsepower * 735.49875936069271) + " W");
			 				Console.WriteLine(mHorsepower + " PS = " + (mHorsepower * 0.73549875936069271) + " kW");
			 				Console.WriteLine(mHorsepower + " PS = " + (mHorsepower * 0.986320090825270795418891) + " hp");
			 				Console.WriteLine(mHorsepower + " PS = " + mHorsepower + " PS");
			 				
			 				string historyEntry = string.Format(mHorsepower + " PS = " + (mHorsepower * 735.49875936069271) + " W");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(mHorsepower + " PS = " + (mHorsepower * 0.73549875936069271) + " kW");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(mHorsepower + " PS = " + (mHorsepower * 0.986320090825270795418891) + " hp");
							AddToHistory(historyEntry);
							
							historyEntry = string.Format(mHorsepower + " PS = " + mHorsepower + " PS");
							AddToHistory(historyEntry);
			 				
			 				Console.WriteLine("Press any key to make another conversions...");
                        	Console.ReadKey();
			 			}
			 			else {
			 				Console.WriteLine("Invalid input. Please enter a valid number.");
                        	Console.Write("Press any key to continue...");
                        	Console.ReadKey(); continue;
			 			} break;
			 		}
			 		break;
			 		
			 	case "5":
			 		Console.Clear();
			 		PerformUnitConversion();
			 		break;
			 	default:
                    Console.Clear();
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    Console.Write("Press any key to continue...");
                    Console.ReadKey();
                    break;	
			 }
			 break;
			 
			case "9":
                Console.Clear();
                return;
            default:
                Console.Clear();
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 8.");
                Console.Write("Press any key to continue...");
                Console.ReadKey();
                break;
			 
			 }
			}
		   
		}
		
	static void MiniGame()
    {
        Console.Clear();
        Console.WriteLine("Mini_Game");
        Console.WriteLine();
        Console.WriteLine("====================================================");
        Console.WriteLine();

        int score = 0;

        while (true)
        {
            Console.WriteLine("Main Menu:");
            Console.WriteLine("====================================================");
            Console.WriteLine();
            Console.WriteLine("1. Easy (One digit)");
            Console.WriteLine("====================================================");
            Console.WriteLine();
            Console.WriteLine("2. Normal (Two digits)");
            Console.WriteLine("====================================================");
            Console.WriteLine();
            Console.WriteLine("3. Hard (Three digits)");
            Console.WriteLine("====================================================");
            Console.WriteLine();
            Console.WriteLine("4. Extreme (Four digits)");
            Console.WriteLine("====================================================");
            Console.WriteLine();
            Console.WriteLine("5. Exit");
            Console.WriteLine("====================================================");
            Console.WriteLine();

            Console.Write("Select difficulty (1-4): ");
            int choice;

            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        PlayGame(1, 10, ref score);
                        break;
                    case 2:
                        PlayGame(10, 100, ref score);
                        break;
                    case 3:
                        PlayGame(100, 1000, ref score);
                        break;
                    case 4:
                        PlayGame(1000, 10000, ref score);
                        break;
                    case 5:
                        Console.Clear();
                        Console.Write("The game is closing. Please wait...");
                        Thread.Sleep(3000);
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
	
	    static void PlayGame(int minRange, int maxRange, ref int score)
    {
        Random random = new Random();
        int lives = 3;

        while (lives > 0)
        {
            int num1 = random.Next(minRange, maxRange);
            int num2 = random.Next(minRange, maxRange);
            char[] operators = { '+', '-', '*' };
            char randomOperator = operators[random.Next(operators.Length)];

            Console.WriteLine("Loading...");
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine(lives + " lives remaining.");
            Console.WriteLine();
	        Console.WriteLine("Score: " + score);
	        Console.WriteLine();
            Console.WriteLine("Game Start!");
            Console.WriteLine();
            Console.Write("Solve the problem: " + num1 + " " + randomOperator + " " + num2 + " = ");

            int userAnswer;

            if (int.TryParse(Console.ReadLine(), out userAnswer))
            {
                int correctAnswer = CalculateAnswer(num1, num2, randomOperator);

                if (userAnswer == correctAnswer)
                {
                    Console.WriteLine("Correct! Well done.");
                    Console.WriteLine("//");
                    Thread.Sleep(200);
                    Console.Clear();
                    Console.WriteLine("Correct! Well done.");
	                Console.WriteLine("//");
	                Console.WriteLine(" //");
	                Thread.Sleep(200);
	                Console.Clear();
	                Console.WriteLine("Correct! Well done.");
	                Console.WriteLine("// //");
	                Console.WriteLine(" //");
	                Thread.Sleep(200);
	                Console.Clear();
	                Console.WriteLine("Correct! Well done.");
	                Console.WriteLine("     //");
	                Console.WriteLine("// //");
	                Console.WriteLine(" //");
	                Thread.Sleep(200);
	                Console.Clear();
	                Console.WriteLine("Correct! Well done.");
	                Console.WriteLine("       //");
	                Console.WriteLine("     //");
	                Console.WriteLine("// //");
	                Console.WriteLine(" //");
	                Thread.Sleep(200);
	                Console.Clear();
	                Console.WriteLine("Correct! Well done.");
	                Console.WriteLine("          //");
	                Console.WriteLine("        //");
	                Console.WriteLine("      //");
	                Console.WriteLine("//  //");
	                Console.WriteLine(" //");
	                Thread.Sleep(1200);
	                Console.Clear();
	                score += 10;
	                Console.WriteLine("Loading Next Question...");
	                Thread.Sleep(2000);
	                Console.Clear();
                }
                else
                {
                    Console.WriteLine("\\");
	                Thread.Sleep(200);
	                Console.Clear();
	                Console.WriteLine("\\");
	                Console.WriteLine("  \\");
	                Thread.Sleep(200);
	                Console.Clear();
	                Console.WriteLine("\\");
	                Console.WriteLine("  \\");
	                Console.WriteLine("    \\");
	                Thread.Sleep(200);
	                Console.Clear();
	                Console.WriteLine("\\");
	                Console.WriteLine("  \\");
	                Console.WriteLine("    \\");
	                Console.WriteLine("      \\");
	                Thread.Sleep(200);
	                Console.Clear();
	                Console.WriteLine("\\");
	                Console.WriteLine("  \\");
	                Console.WriteLine("    \\");
	                Console.WriteLine("      \\");
	                Console.WriteLine("        \\");
	                Thread.Sleep(200);
	                Console.Clear();
	                Console.WriteLine("\\");
	                Console.WriteLine("  \\");
	                Console.WriteLine("    \\");
	                Console.WriteLine("      \\");
	                Console.WriteLine("//      \\");
	                Thread.Sleep(200);
	                Console.Clear();
	                Console.WriteLine("\\");
	                Console.WriteLine("  \\");
	                Console.WriteLine("    \\");
	                Console.WriteLine("  //  \\");
	                Console.WriteLine("//      \\");
	                Thread.Sleep(200);
	                Console.Clear();
	                Console.WriteLine("\\");
	                Console.WriteLine("  \\  //");
	                Console.WriteLine("    \\");
	                Console.WriteLine("  //  \\");
	                Console.WriteLine("//      \\");
	                Thread.Sleep(200);
	                Console.Clear();
	                Console.WriteLine("\\      //");
	                Console.WriteLine("  \\  //");
	                Console.WriteLine("    \\");
	                Console.WriteLine("  //  \\");
	                Console.WriteLine("//      \\");
	                Thread.Sleep(200);
	                Console.WriteLine();
	               	Console.WriteLine("Incorrect. The correct answer is " + correctAnswer + ".");
	                lives--;
	                Console.WriteLine();
	                Console.WriteLine("You have " + lives + " lives remaining.");
	                Thread.Sleep(5000);
	            	Console.Clear();
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        Console.WriteLine("Game over! You ran out of lives.");
        Thread.Sleep(1000);
        Console.WriteLine();
        Console.WriteLine("Going back to main menu in 3...");
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("Game over! You ran out of lives.");
        Console.WriteLine();
        Console.WriteLine("Going back to main menu in 2...");
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("Game over! You ran out of lives.");
        Console.WriteLine();
        Console.WriteLine("Going back to main menu in 1...");
        Thread.Sleep(1000);
        Console.Clear();
    }
	
	    static int CalculateAnswer(int num1, int num2, char op)
    {
        switch (op)
        {
            case '+':
                return num1 + num2;
            case '-':
                return num1 - num2;
            case '*':
                return num1 * num2;
            default:
                throw new ArgumentException("Invalid operator");
        }
	    }
	    
	    static void ViewHistory()
	    {
	    	Console.Clear();
	    	Console.WriteLine("Calculation Histoy:");
	    	Console.WriteLine();
	    	
	    	foreach (var entry in calculationHistory) {
	    		Console.WriteLine(entry);
	    		Console.WriteLine();
	    	}
	    	Console.Write("Press any key to return in main menu...");
	    	Console.ReadKey(true);
	    }
		
	    static void AddToHistory(string entry)
	    {
	    	calculationHistory.Add(entry);
	    }
	}
}