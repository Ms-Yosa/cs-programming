namespace cs_programming;
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
          // 0 = same | negative = var1 < var2 (vice versa for positive)
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

*/

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




     }
}
