using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class Calculator
    {
        public void Calculate()
        {
            string[] operators = new string[4] { "+", "_", "/", "*" };
            //declare all variables

            string type;
            decimal number1;
            decimal number2;
            decimal answer;
            string restartCheck;

            Console.WriteLine("Choose your operator: (+, _,/ or * ");
            type = GetCalcType(operators);

            Console.Write("Choose your first number  ");
            number1= int.Parse(Console.ReadLine());

            Console.Write("Choose your second number ");
            number2 = int.Parse(Console.ReadLine());

            answer = Result (number1, number2, type);

            Console.WriteLine("Your answer is "    + answer + "Write 'yes' to restart the application") ;

            restartCheck= Console.ReadLine();
            if (restartCheck== "yes")
            {
                Calculate();
            }
            else
            {
                Environment.Exit(0);
            }




        }

        public string GetCalcType(string[] operators)
        {

           
           string  type = Console.ReadLine();

            //check if correct operator is selected

            while (!operators.Contains(type))
            {
                
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Choose the correct operator!");
                type = Console.ReadLine();
            }
            return type;




            
        }




        public static decimal Result(decimal number1, decimal number2, string type)
        {


            decimal result;

            if (type == "+")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                result = number1 + number2;
                return result;
            }


            else if (type =="_")
            {
              
                result = number1 - number2;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                return result;

            }


            else if (type =="/")
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.Black;
                result = number1 / number2;
                return result;

            }

            else if (type =="*")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                result = number1 * number2;
                return result;
            }

            else
            {
                
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid operator type");
                

            }
            return 0;
        }






        



            
       


    }
}
