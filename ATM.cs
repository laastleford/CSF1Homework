using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class ATM
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your 7-digit account number:\n");
            string acctNbr = Console.ReadLine();


            int nbrAttempts = 0;
            ////if (acctNbr != "1234567")
            ////{
            ////    nbrAttempts++;
            ////}

            if (acctNbr != "1234567")
            {
               
                while (acctNbr != "1234567" && nbrAttempts < 5)
                {

                    nbrAttempts++;
                    Console.WriteLine("Account number was not valid.  Please try again.\n");
                    

                acctNbr = Console.ReadLine();//update
                    
                }//while

            }//if
            else
            {
                //Console.WriteLine("You have successfully entered a valid account number.");
            Console.Clear();
            Console.WriteLine("Please enter 4-digit user PIN:\n");
            string pinNbr = Console.ReadLine();
                int pinAttempts = 0;


                if (pinNbr != "0411")
                {


                    while (pinNbr != "0411" && pinAttempts < 5)
                    {

                        pinAttempts++;
                        Console.WriteLine("PIN was not valid.  Please try again.\n");
                        pinNbr = Console.ReadLine();//update

                    }//while
                }//if
                else
                {



                    Console.Clear();
                    bool programRun = true;
                    decimal userBalance = 500.5m;

                    do
                    {
                        Console.WriteLine("Viridian Banking\n");
                        Console.WriteLine("\nB) Balance\nD) Deposit\nW) Withdraw\nX) Exit");
                        string userSelect = Console.ReadLine().ToLower();
                        Console.Clear();//clear

                        switch (userSelect)
                        { 
                            case "d":
                            case "deposit":
                                Console.WriteLine("Please enter amount for deposit.");
                                decimal depositAmt = decimal.Parse(Console.ReadLine());
                                Console.WriteLine($"{depositAmt:c} has been deposited to account 1234567.\n\n");
                                Console.WriteLine($"Your current balance is {userBalance += depositAmt:c}.");
                                break;

                            case "w":
                            case "withdraw":
                                Console.WriteLine("Please enter amount for withdrawal.");
                                decimal withdrawalAmt = decimal.Parse(Console.ReadLine());
                                if (withdrawalAmt <= userBalance)
                                {


                                    Console.WriteLine($"{withdrawalAmt:c} has been withdrawn from account 1234567.\n\n");
                                    Console.WriteLine($"Your current balance is {userBalance -= withdrawalAmt:c}.\n\n");
                                }
                                else
                                {
                                    Console.WriteLine($"Your request to withdraw {withdrawalAmt:c} was rejected.  You cannot overdraw your account.\n\n");
                                }

                                break;

                            case "x":
                            case "e":
                            case "exit":
                                Console.WriteLine("Viridian Banking thanks you for your business!\n\n");
                                
                                break;

                            case "b":
                            case "balance":
                                Console.WriteLine($"Account 1234567 currently has a balance of {userBalance:c}.\n\n");
                                break;


                            default:
                                Console.WriteLine("Please make a selection from the menu provided.\n\n");
                                break;
                        }//switch


                    } while (programRun);
                    Console.Clear();
                }
               

            }//else   

            

        }//Main()
    }
}
