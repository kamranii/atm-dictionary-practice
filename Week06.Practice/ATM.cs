using System;

namespace Week06.Practice
{
    //class Rocket: IFly, IFuel
    //{
    //    //Initial fuel amount
    //    private double InitialFuel { get; set; }
    //    //Remaining fuel amount
    //    public double CurrentFuel { get; set; }

    //    private double Gasolinefor100km = 10;
    //    public double FlyToDestination(int distance)
    //    {
    //        CurrentFuel = InitialFuel - FuelSpend(distance);
    //        return CurrentFuel;
    //    }

    //    public double FuelSpend(int distance)
    //    {
    //        return  (distance * 10) / 100;
    //    }
    //    public Rocket(double fuel)
    //    {
    //        InitialFuel = fuel;
    //    }
    //}
    //interface IFly
    //{
    //    public double FlyToDestination(int distance);
    //}
    //interface IFuel
    //{
    //    public double FuelSpend(int distance);
    //}
    class ATM
    {
        private int maxWithdrawalAmount;


        public void BalanceCheck(Card card)
        {
            Console.WriteLine($"Your balance is: {card.Balance} AZN");
        }
        public void CashWithdrawal(Card card)
        {
            Console.WriteLine("Input an amount: ");
            int amount = int.Parse(Console.ReadLine());
            if (amount > maxWithdrawalAmount)
            {
                Console.WriteLine("The amount exceeds maximum possible withdrawal amount!!!");
            }
            else
            {
                card.Balance -= amount;
                BalanceCheck(card);
            }
        }
        public ATM(int amount)
        {
            maxWithdrawalAmount = amount;
        }
    }
}

