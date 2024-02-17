using System;

namespace Week06.Practice
{
    class Card
    {
        private short pinCode;
        public short PinSet { get; set; }
        public int Balance { get; set; }
        public Card(int balance)
        {
            Balance = balance;
            Console.Write("Set your pin code of 4 digits: ");
            short input = short.Parse(Console.ReadLine());
            pinCode = input;
        }
    }
}

