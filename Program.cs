using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Program

    {
        private static object a;

        public static void EnglishMethod()
        {


            int amount = 1000, deposit, withdraw;
            int choice, pin = 0, x = 0;
            Console.WriteLine("Enter Your Pin Number ");
            pin = int.Parse(Console.ReadLine());

            Console.WriteLine("********Welcome to ATM Service**************\n");
            Console.WriteLine("1. Check Balance\n");
            Console.WriteLine("2. Withdraw Cash\n");
            Console.WriteLine("3. Deposit Cash\n");
            Console.WriteLine("4. Quit\n");
            Console.WriteLine("*********************************************\n\n");
            Console.WriteLine("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());
            switch (choice)

            {
                case 1:
                    Console.WriteLine("\n YOUR BALANCE IN Rs : {0} ", amount);
                    break;
                case 2:
                    Console.WriteLine("\n ENTER THE AMOUNT TO WITHDRAW: ");
                    withdraw = int.Parse(Console.ReadLine());
                    if (withdraw % 100 != 0)
                    {
                        Console.WriteLine("\n PLEASE ENTER THE AMOUNT IN MULTIPLES OF 100");
                    }
                    else if (withdraw > (amount - 500))
                    {
                        Console.WriteLine("\n INSUFFICENT BALANCE");
                    }
                    else
                    {
                        amount = amount - withdraw;
                        Console.WriteLine("\n\n PLEASE COLLECT CASH");
                        Console.WriteLine("\n YOUR CURRENT BALANCE IS {0}", amount);
                    }
                    break;
                case 3:
                    Console.WriteLine("\n ENTER THE AMOUNT TO DEPOSIT");
                    deposit = int.Parse(Console.ReadLine());
                    amount = amount + deposit;
                    Console.WriteLine("YOUR BALANCE IS {0}", amount);
                    break;

                case 4:
                    Console.WriteLine("\n THANK YOU FOR USING OUR ATM");
                    break;
            }
            return;

        }
        private static object b;
        private static void SpanishMethod()
        {
            int amount = 1000, deposit, withdraw;
            int choice, pin = 0, x = 0;
            Console.WriteLine("Ingrese su número de PIN ");
            pin = int.Parse(Console.ReadLine());

            {
                Console.WriteLine("********Bienvenido al servicio de cajero automático**************\n");
                Console.WriteLine("1. Comprobar saldo\n");
                Console.WriteLine("2. Retirar dinero\n");
                Console.WriteLine("3. Depósito en efectivo\n");
                Console.WriteLine("4. Dejar\n");
                Console.WriteLine("*********************************************\n\n");
                Console.WriteLine("Ingrese su elección: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\n Tu equilibrio en Rs : {0} ", amount);
                        break;
                    case 2:
                        Console.WriteLine("\n INTRODUZCA LA CANTIDAD PARA RETIRAR ");
                        withdraw = int.Parse(Console.ReadLine());
                        if (withdraw % 100 != 0)
                        {
                            Console.WriteLine("\n POR FAVOR INGRESE LA CANTIDAD EN MULTIPLES DE 100");
                        }
                        else if (withdraw > (amount - 500))
                        {
                            Console.WriteLine("\n SALDO INSUFICIENTE");
                        }
                        else
                        {
                            amount = amount - withdraw;
                            Console.WriteLine("\n\n POR FAVOR RECOGER EFECTIVO");
                            Console.WriteLine("\n TU SALDO ACTUAL ES {0}", amount);
                        }
                        break;
                    case 3:
                        Console.WriteLine("\n INTRODUZCA LA CANTIDAD DE DEPÓSITO");
                        deposit = int.Parse(Console.ReadLine());
                        amount = amount + deposit;
                        Console.WriteLine("SU BALANCE ES {0}", amount);
                        break;
                    case 4:
                        Console.WriteLine("\n GRACIAS POR USAR ATM");
                        break;
                }
                return;
            }
        }


        public static void Main()
        {

            while (true)
            {
                Console.WriteLine("Press 1 for English and 2 for Spanish");
                int userinput = int.Parse(Console.ReadLine());

                if (userinput == 1)
                {

                    EnglishMethod();
                }
                else if (userinput == 2)
                {

                    SpanishMethod();
                }
            }
        }

    }

}

