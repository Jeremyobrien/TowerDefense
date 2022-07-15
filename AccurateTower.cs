using System;
namespace TowerDefense
{
    class AccurateTower : Tower
    {
        protected override double Accuracy { get; } = .9;
        public AccurateTower(MapLocation location) : base(location)
        {
        }
    }
}

