using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Reflection.Emit;
using System.Threading;
using System.Threading.Tasks;

namespace Week06.Practice
{
    class Program
    {
        public delegate void MathOperation(int a, int b);
        static void Main(string[] args)
        {
            #region Task.Lesson11
            //Dictionary<char, int> airports = new Dictionary<char, int>();
            //airports.Add('A', 0);
            //airports.Add('B', 10);
            //airports.Add('C', 35);
            //airports.Add('D', 40);
            ////Get Airport
            //char destination = char.Parse(Console.ReadLine());
            //int destinationDistance = 0;
            //foreach(KeyValuePair<char, int> kV in airports)
            //{
            //    destinationDistance += kV.Value;
            //    if(kV.Key == destination)
            //    {
            //        break;
            //    }
            //}    
            ////New rocket
            //Rocket myRocket = new Rocket(250);
            //Console.WriteLine(myRocket.FlyToDestination(destinationDistance));
            #endregion
            #region ATM
            //An ATM class
            //Methods:
            //1. Check balance
            //2. Cash Withdrawal (maximum possible withdrawal amount, check amount in the card)
            //3. Cash Description (Show card balance after the withdrawal)

            //Create a new ATM
            //ATM myATM = new ATM(400);
            ////Create a card
            //Card myCard = new Card(1000);
            ////Offer menu to the user
            //Console.WriteLine("Which operation would you like to do: ");
            //Console.WriteLine("1. Cash Withdrawal: ");
            //Console.WriteLine("2. Balance Check");
            ////Get choice
            //Console.Write("Your choice: ");
            //byte choice = byte.Parse(Console.ReadLine());
            ////Output the result
            //switch (choice)
            //{
            //    case 1:
            //        myATM.CashWithdrawal(myCard);
            //        break;
            //    case 2:
            //        myATM.BalanceCheck(myCard);
            //        break;
            //    default:
            //        Console.WriteLine("Incorrect Operation!!!");
            //        break;
            //}

            #endregion
            #region Task
            //int a = 5;
            //int b = 6;
            //MathOperation m1 = new MathOperation(Sum);
            List<int> numbers = new List<int>() { 4, 5, 9, 17, 22, 27 };
            foreach(var item in Numbers(numbers))
            {
                Console.WriteLine(item);
            }
            static List<int> Numbers(List<int> ints)
            {
                List<int> newList = new List<int>();
                foreach(int number in ints)
                {
                    if(number > 15)
                    {
                        newList.Add(number);
                    }
                }
                return newList;
            }
            #endregion

        }
        public void Sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }
}

