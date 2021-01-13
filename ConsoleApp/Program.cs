using OOP;
using System;
using System.IO;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your name?");
            //var name = Console.ReadLine();
            //var date = DateTime.Now;
            //Console.WriteLine($"\nHello, {name}, on {date:d} at {date:t}!");

            //int anIntegerValue;
            //anIntegerValue = 1;
            //long aLongValue;
            //aLongValue = 121;
            //double aDoubleValue = 546.5;
            //float aFloatValue = 546.5F;
            //decimal aDecimal = 546.5M;
            //bool aBoolValue = true;
            //char aCharValue = 'a';
            //string aStringValue = "My name is Dara";
            //var myVar = 1656.5M;
            //Console.WriteLine(myVar.GetType());

            //string firstName = "Dara";
            //int age;
            //age = 53;
            //int age = 53;
            //Console.WriteLine("Name is " + firstName + ", age is: " + age);

            /*
             * variableNames are mostly camelCase
             * MethodNames are PascalCase
             * ClassNames are PascalCase
             * Public field names are PascalCase
             * Private field names are camelCase
             */
            //var Power = Math.Pow(3, 2);
            //Console.WriteLine(Power);
            //var myMax = Math.Max(5, 5);
            //var myMin = Math.Min(5, 5);
            //var myAbs = Math.Abs(-4544);

            //var myValue = 5;
            //Console.WriteLine(myValue);
            //myValue++;
            //Console.WriteLine(myValue);
            //myValue += 12;
            //Console.WriteLine(myValue);
            //myValue -= 2;
            //Console.WriteLine(myValue);
            //string niceStatement = "Today is a beautiful day";
            //Console.WriteLine(niceStatement);
            //var niceStatementSplit = niceStatement.Split();
            //foreach (var word in niceStatementSplit)
            //{
            //    Console.WriteLine(word);
            //}
            //var niceStatementContains = niceStatement.Contains("beautiful");
            //Console.WriteLine(niceStatementContains);
            //var niceStatementReplace = niceStatement.Replace("beautiful", "great");
            //Console.WriteLine(niceStatementReplace);

            //string quotedStatement = "Dara is a very good guy, she said.";
            //string anotherQuotedStatement = "She said \"Dara is age very good guy\"\nI am continuing on a \nnew line and I on a \ttab";
            //Console.WriteLine(anotherQuotedStatement);

            //string someString = "Today is", anotherString = "a good", lastString = "day";
            //var firstConcatMethod = someString + " " + anotherString + " " + lastString;
            //Console.WriteLine(firstConcatMethod);
            //Console.WriteLine("{0} {1} {2}", someString, anotherString, lastString);
            //var stringInterpolationMethod = $"{someString} {anotherString} {lastString}";
            //Console.WriteLine(stringInterpolationMethod);

            //string fileDir = @"C:\Users\Dara\source\Repos\ConsoleApp";
            //Console.WriteLine(fileDir);
            //string anotherfileDir = "C:\\Users\\Dara\\source\\Repos\\ConsoleApp";
            //Console.WriteLine(anotherfileDir);

            //Console.WriteLine("What is your name?");
            //string userName = Console.ReadLine();
            ////Console.WriteLine($"Hello {userName}");
            //Console.WriteLine("What is your age?");
            //string ageInputFromConsole = Console.ReadLine();
            //int age = Convert.ToInt32(ageInputFromConsole);
            //Console.WriteLine($"You were born {2020 - age}");
            //int ageSecondWay = int.Parse(ageInputFromConsole);
            //Console.WriteLine($"You were born {2020 - ageSecondWay}");
            //Console.WriteLine("What is your year of birth?");
            //int userYOB = int.Parse(Console.ReadLine());
            //int userAge = DateTime.Now.Year - userYOB;
            //if (userAge < 13)
            //{
            //    Console.WriteLine("Sorry, you are not old enough to use this application");
            //}
            //else
            //{
            //    Console.WriteLine("Welcome, you can now complete your registration");
            //}
            //var messageToUser = (userAge < 13) ? "Sorry, you are not old enough to use this application" : "Welcome, you can now complete your registration";
            //Console.WriteLine(messageToUser);
            //switch (userAge)
            //{
            //    case var exp when (exp < 13):
            //        Console.WriteLine("Sorry, you are not old enough to use this application");
            //        break;
            //    default:
            //        Console.WriteLine("Welcome, you can now complete your registration");
            //        break;
            //}
            //switch (DateTime.Now.AddDays(3).DayOfWeek)
            //{
            //    case DayOfWeek.Sunday:
            //        Console.WriteLine($"Today is {DateTime.Now.DayOfWeek}");
            //        break;
            //    case DayOfWeek.Monday:
            //        Console.WriteLine($"Today is Man Crush Monday");
            //        break;
            //    case DayOfWeek.Tuesday:
            //        Console.WriteLine($"Today is Tuesday");
            //        break;
            //    case DayOfWeek.Wednesday:
            //        Console.WriteLine($"Today is Woman Crush Wednesday");
            //        break;
            //    case DayOfWeek.Thursday:
            //        Console.WriteLine($"Today is Throwback Thursday");
            //        break;
            //    case DayOfWeek.Friday:
            //        Console.WriteLine($"Today is Flashback Friday");
            //        break;
            //    case DayOfWeek.Saturday:
            //        Console.WriteLine($"Today is Saturday");
            //        break;
            //    default:
            //        break;
            //}
            //our grading system
            //Console.WriteLine("What is the student score?");
            //int userScore = int.Parse(Console.ReadLine());
            //switch (userScore)
            //{
            /* 0-39:F
             * 40-44:E
             * 45-49:D
             * 50-59:C
             * 60-69:B
             * 70-100:A
             */
            //|| or
            //&& and
            //case var exp when (exp >= 0 && exp <= 39):
            //    Console.WriteLine("Grade: F");
            //    break;
            //case var exp when (exp >= 40 && exp <= 44):
            //    Console.WriteLine("Grade: E");
            //    break;
            //case var exp when (exp >= 45 && exp <= 49):
            //    Console.WriteLine("Grade: D");
            //    break;
            //case var exp when (exp >= 50 && exp <= 59):
            //    Console.WriteLine("Grade: C");
            //    break;
            //case var exp when (exp >= 60 && exp <= 69):
            //    Console.WriteLine("Grade: B");
            //    break;
            //case var exp when (exp >= 70 && exp <= 100):
            //    Console.WriteLine("Grade: A");
            //    break;
            //default:
            //    Console.WriteLine("Invalid input. Please try again");
            //    break;

            //}
            //print out values from 1-10
            //int myInt = 1;
            //while loop
            //while (myInt <= 10)
            //{
            //    Console.WriteLine(myInt);
            //    myInt++;
            //}

            //do while loop
            //do
            //{
            //    Console.WriteLine(myInt);
            //    myInt++;
            //} while (myInt <= 10);

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //string myString="ABCDEFGHIJKLMNOPQRSTUVQXYZ";
            //foreach (var alpahabet in myString)
            //{
            //    Console.WriteLine(alpahabet);
            //}


            //array
            //string[] People = new string[5];
            //People[0] = "Smith";
            //People[1] = "Sam";
            //People[2] = "Samantha";
            //People[3] = "Sammie";
            //People[4] = "Sammo";
            //for (int i = 0; i < People.Length; i++)
            //{
            //    Console.WriteLine(People[i]);
            //}

            //string[] Cars = { "Volvo", "Toyota", "Vauxhall", "Ford" };
            //foreach (var car in Cars)
            //{
            //    Console.WriteLine(car);
            //}

            //int[] someNumbers = { 1, 5, 8, 56, 894, 52, 56, 6, 548 };
            //Console.WriteLine($"Max value in array is {someNumbers.Max()}");
            //Console.WriteLine($"Min value in array is {someNumbers.Min()}");
            //Console.WriteLine($"Sum of array is {someNumbers.Sum()}");

            //Car myNissan = new Car("Nissan", "Qashqai", 2018);
            //Console.WriteLine(myNissan.ID);
            //myNissan.Start();
            //myNissan.Accelerate();
            //myNissan.Deccelerate();
            //myNissan.Stop();

            //string textToWrite = "Hello World";
            //File.WriteAllText(@"C:\Users\Dara\Desktop\textfile.txt", textToWrite);
            //File.AppendAllText(@"C:\Users\Dara\Desktop\textfile.txt", textToWrite);
            //File.AppendAllText(@"C:\Users\Dara\Desktop\textfile.txt", textToWrite);
            //File.AppendAllText(@"C:\Users\Dara\Desktop\textfile.txt", textToWrite);
            //if (File.Exists(@"C:\Users\Dara\Desktop\textfile.txt"))
            //{
            //    string textToRead = File.ReadAllText(@"C:\Users\Dara\Desktop\textfile.txt");
            //    Console.WriteLine(textToRead);
            //}
            //else
            //{
            //    Console.WriteLine("Nothing to read");
            //}
            //try
            //{
            //    string originalFile = "originalFile.txt";
            //    string fileToReplace = "fileToReplace.txt";
            //    string fileToReplaceBackup = "fileToReplace.txt.bac";
            //    Console.WriteLine($"Moving the contents of {originalFile} into " +
            //        $"{fileToReplace}, then delete the {originalFile} " +
            //        $"and create the backup for {fileToReplace}");

            //    //replace file
            //    ReplaceFile(originalFile, fileToReplace, fileToReplaceBackup);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            var filePath = @"C:\Users\Dara\Desktop\textfile.txt";
            //var streamReader = new StreamReader(filePath);
            //var fileContent = streamReader.ReadToEnd();
            //Console.WriteLine(fileContent);
            using (var streamReader = new StreamReader(filePath))
            {
                var fileContent = streamReader.ReadToEnd();
                Console.WriteLine(fileContent);
            }
        }

        private static void ReplaceFile(string originalFile, string fileToReplace, string fileToReplaceBackup)
        {
            File.Replace(originalFile, fileToReplace, fileToReplaceBackup, false);
        }
    }
    class HyBridCar : Car, IDisposable
    {
        public HyBridCar()
        {
            ID = Guid.NewGuid();
        }

        public void Dispose()
        {
            //release memory
        }
    }
}

