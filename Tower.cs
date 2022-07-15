using System;

namespace TowerDefense
{
    class Tower
    {
        protected virtual int Range { get; } = 1;

        protected virtual int Power { get; } = 1;

        protected virtual double Accuracy { get; } = .75;

        private static readonly Random _random = new Random();

        private readonly MapLocation _location;

        public Tower(MapLocation location)
        {
            _location = location;
        }

        public bool IsSuccessfulShot()
        {
            return _random.NextDouble() < Accuracy;
        }
        public void FireOnInvaders(Invader[] invaders)
        {
            foreach(Invader invader in invaders)
            {
                if(invader.IsActive && _location.InRangeOf(invader.Location, Range))
                {
                    if(IsSuccessfulShot())
                    {
                        invader.DecreaseHealth(Power);
                        Console.WriteLine("hit");

                        if(invader.IsNeutralized)
                        {
                            Console.WriteLine("Invader neutralized");
                        }
                    }
                    else
                    {
                        Console.WriteLine("miss");
                    }
                    break;
                }
            }
        }
    }
}