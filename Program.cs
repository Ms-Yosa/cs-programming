namespace cs_programming;
class Program
{
     static void Main(string[] args)
     {

          int myInt = 5;
          double myDouble = 2.2;

          Console.WriteLine("the value of myInt is {0} and the value of myDouble is {1}", myInt, myDouble);

          // allocate 5 more spaces
          Console.WriteLine("the value of myInt is {0,5} and the value of myDouble is {1,5}", myInt, myDouble);

          //concat
          Console.WriteLine("The value of myInt is " + myInt + " " + " and the value of myDouble is " + myDouble + " ");
     }
}
