using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variaveis para o menu
             string input;
             
            //variaveis para operações
             decimal result=0;
             decimal num1, num2;

            //menu calculadora
                Console.WriteLine("Welcome to the Calculator!\n");

                Console.WriteLine("please select your mathematical operation");
           
            while(true)          
            { 
                  Console.WriteLine(" > " + "1 - adiction\n" + " > " + "2 - subtraction\n" + " > " + "3 - division\n" + " > " + "4 - multiplication\n" + " > " + " 5 - exit app\n" );

                               
                // se carregar adicion Vai retornar a soma
                
                input = Console.ReadLine();

                // forma de validação para dar imput. Caso o utilizador digitar outra coisa que não seja o que pede.

                if (input == "5")
                {
                    break;
                }


                Console.WriteLine("please input your number");

                num1 = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine(" Please input other number");

                num2 = Convert.ToDecimal(Console.ReadLine());

               

                if (input == "1")
                {                                        
                    result = num1 += num2;                                       
                }
                
               // Vai retornar a subtração
                if (input == "2")
                {                                                          
                   result = num1 -= num2;

                }

                //Vai Retornar a Divisão
                if(input == "3")

                {                                                                             
                    result = (num1 / num2);
                }
              
                // Vai Retornar Multiplicação
                if (input == "4")
                {
                    result = (num1 * num2);
                }

                

                if ((input != "1") && (input != "2") && (input != "3") && (input != "4") && (input != "5"))
                {
                    Console.WriteLine("Wrong Operation, please select the correct option");
                }
                else
                {
                     Console.WriteLine("The Total Is: " + " " + result);
                }

           
   
            }
 
        }
    }       
}

