using System.Text;

namespace Demo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Looping Statements
            #region for - foreach
            //int[] numbers = { 1, 2, 3, 4, 5 };

            //// for loop
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    //numbers[i] += 10;
            //    if (i == 2) break;                         //continue;
            //    Console.WriteLine($"Number {i} is {numbers[i]}");

            //}

            //// foreach loop
            //foreach (int item in numbers)
            //{

            //    Console.WriteLine($"Number {item + 10}");
            //}

            #endregion

            #region Do....While Loop
            //int num;
            //bool isParse;

            //do
            //{
            //    Console.Write("Enter Even Number : ");
            //    isParse = int.TryParse(Console.ReadLine(), out num);
            //}
            //while (num % 2 == 1 || !isParse ) ;

            #endregion

            #region While Loop
            //Console.Write("Enter a Number : ");
            //int num;
            //bool isParse;
            //isParse = int.TryParse(Console.ReadLine(), out num);

            //if (isParse)
            //{
            //    while (num <= 10)
            //    {
            //        Console.WriteLine(num);
            //        num++;
            //    }
            //}
            #endregion

            #endregion

            #region String
            ////Example 01 
            //string name = new string("Route");

            //Console.WriteLine($"Name is : {name}");
            //Console.WriteLine($"Hash code is : {name.GetHashCode()}");

            //string name02 = new string("Route");

            //Console.WriteLine($"Name is : {name}");
            //Console.WriteLine($"Hash code is : {name.GetHashCode()}");

            //// Example 02
            //string name01 = "Amr";
            //string name02 = "May";

            //Console.WriteLine($"Name01 is : {name01}");
            //Console.WriteLine($"Hash code of Name0  1 is : {name01.GetHashCode()}");

            //Console.WriteLine($"Name02 is : {name02}");
            //Console.WriteLine($"Hash code of Name02 is : {name02.GetHashCode()}");

            //name02 = name01;
            //Console.WriteLine("After Assign .");
            //Console.WriteLine($"Name01 is : {name01}");
            //Console.WriteLine($"Hash code of Name01 is : {name01.GetHashCode()}");

            //Console.WriteLine($"Name02 is : {name02}");
            //Console.WriteLine($"Hash code of Name02 is : {name02.GetHashCode()}");

            //name01 = "amira";

            //Console.WriteLine("After change value of Name01 .");
            //Console.WriteLine($"Name01 is : {name01}");
            //Console.WriteLine($"Hash code of Name01 is : {name01.GetHashCode()}");

            //Console.WriteLine($"Name02 is : {name02}");
            //Console.WriteLine($"Hash code of Name02 is : {name02.GetHashCode()}");

            //// Example 03
            //string message = "hello";
            //Console.WriteLine($"Message is {message}");
            //Console.WriteLine($"hash Code of Message is {message.GetHashCode()}");

            //message += " route";
            //Console.WriteLine("After Change .");
            //Console.WriteLine($"Message is {message}");
            //Console.WriteLine($"hash Code of Message is {message.GetHashCode()}");

            #endregion

            #region String Methods
            //string message = "            Hello Route            ";
            //Console.WriteLine(message.Length);
            //Console.WriteLine(message.ToUpper());
            //Console.WriteLine(message.ToLower());
            //Console.WriteLine(message.Trim());
            //Console.WriteLine(message.TrimEnd());
            //Console.WriteLine(message.TrimStart());
            //Console.WriteLine(message.Substring(12,5));
            //Console.WriteLine(message.Replace(' ' , '-'));
            //Console.WriteLine(message.Contains('e'));
            //Console.WriteLine( message.Clone());
            //Console.WriteLine(message.LastIndexOf('H'));

            #endregion

            #region StringBuilder

            //StringBuilder name = new StringBuilder("Route");

            //Console.WriteLine($"Name is : {name}");
            //Console.WriteLine($"Hash code is : {name.GetHashCode()}");

            //name.Append(" Academy");

            //Console.WriteLine($"Name is : {name}");
            //Console.WriteLine($"Hash code is : {name.GetHashCode()}");


            #endregion

            #region StringBuilder Methods
            StringBuilder message = new StringBuilder("Hello ");

            message.Append("Route");
            Console.WriteLine(message);

            message.AppendLine(" Academy");
            Console.WriteLine(message);

            message.Append("Amira");
            Console.WriteLine(message);

            message.Replace("Hello", "Welcome");
            Console.WriteLine(message);

            //message.Clear();
            //Console.WriteLine(message);

            message.Remove(0, 8);
            Console.WriteLine(message);

            message.Insert(0, "HI ");
            Console.WriteLine(message);

            message.AppendFormat(" Your Age is {0} .", 22);
            Console.WriteLine(message);

            message.AppendJoin("_", "Amira", "Alaa", "Eldin");
            Console.WriteLine(message);
            #endregion
        }
    }
}
