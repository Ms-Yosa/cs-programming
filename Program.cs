﻿namespace cs_programming;
class Program
{

     //  enum dayOfWeek
     //  {
     //       SUNDAY,
     //       MONDAY,
     //       TUESDAY,
     //       WEDNESDAY,
     //       THURSDAY,
     //       FRIDAY,
     //       SATURDAY
     //  }

     static void Main(string[] args)
     {
          /*

            int myInt = 5;
            double myDouble = 2.2;

            Console.WriteLine("the value of myInt is {0} and the value of myDouble is {1}", myInt, myDouble);

            // allocate 5 more spaces
            Console.WriteLine("the value of myInt is {0,5} and the value of myDouble is {1,5}", myInt, myDouble);

            //concat
            Console.WriteLine("The value of myInt is " + myInt + " " + " and the value of myDouble is " + myDouble + " ");

            // operators
            int result = 2 + 3 * 4;
            Console.WriteLine(result);

            //pre&post
            int a = 5;
            int c = a++;
            Console.WriteLine("" + a + " " + c);

            

          //String

          string name1 = "Jesse";
          string name2 = "Jesse";

          //comparing strings

          //   bool namesEquals = name1 == name2;
          //   bool namesEquals = string.Equals(name1, name2);
          //   int namesEquals = string.Compare(name1, name2);
          int namesEquals = name1.CompareTo(name2);
          // 0 = same | 1 = different | negative = var1 < var2 (vice versa for positive)
          System.Console.WriteLine(namesEquals);
          Console.WriteLine(name1.Substring(0, 1));
          // substring = Substring (startIndex, numberOfChartersTaken);


            

          //Conversion / Casting

          int x = 5;
          double y = x; //implicit cast
          Console.WriteLine(y);

          double myDouble = 5.5;
          int myInt = (int)myDouble; // explicit cast
          Console.WriteLine(myInt);

          

          //Declaring constant

          //   const int myConstInt = 5;

          // enum = group of constant

          dayOfWeek today = dayOfWeek.FRIDAY;
          int numberOfDay = (int)today;
          Console.WriteLine(numberOfDay);



          //Console input
          //   Console.Write("What is your name?");
          //   string name = Console.ReadLine();
          //   Console.Write("What is your last name?");
          //   string lname = Console.ReadLine();
          //   Console.WriteLine("Hello {0} {1}", name, lname);

          // parsing = convert string to numeric value
          Console.WriteLine("Enter a number");
          int number = int.Parse(Console.ReadLine());
          Console.WriteLine(number);




          // EXERCISE 1 calculator

          Console.Write("Enter first number: ");
          double firstNum = double.Parse(Console.ReadLine());
          Console.Write("Enter second number: ");
          double secNum = double.Parse(Console.ReadLine());
          Console.Write("What operation?");
          string operand = Console.ReadLine();
          double result;

          switch (operand)
          {
               case "+":
                    result = firstNum + secNum;
                    Console.WriteLine("Answer: " + result);
                    break;
               case "-":
                    result = firstNum - secNum;
                    Console.WriteLine("Answer: " + result);
                    break;
               case "*":
                    result = firstNum * secNum;
                    Console.WriteLine("Answer: " + result);
                    break;
               case "/":
                    result = firstNum / secNum;
                    Console.WriteLine("Answer: " + result);
                    break;
               default:
                    Console.WriteLine("Invalid input!");
                    break;
          }



          // EXERCISE 2 length & width;

          const double pricePerSquareFoot = 25.3;

          Console.WriteLine("Price per sq/ft is: $25.3");

          Console.Write("Enter length: ");
          double length = double.Parse(Console.ReadLine());
          Console.Write("Enter width: ");
          double width = double.Parse(Console.ReadLine());
          double totalArea = length * width;
          double totalAmount = totalArea * pricePerSquareFoot;

          Console.WriteLine("You purchased: {0} sq/ft of carpet with a total price of {1}", totalArea, totalAmount);

*/

          // EXERCISE 3

          const int minute = 60;

          Console.WriteLine("Enter total minutes: ");
          int input = int.Parse(Console.ReadLine());

          if (input <= minute)
          {
               Console.WriteLine(input + " minutes");
          }
          else
          {
               int hour = input / minute;
               int minuteLeft = input % minute;
               Console.WriteLine("{0} hour/s and {1} minute/s", hour, minuteLeft);


          }







     }
}
