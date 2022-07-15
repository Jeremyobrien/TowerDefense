using System;
namespace TowerDefense
{
    class FarRangeTower : Tower
    {
        protected override int Range { get; } = 2;
        public FarRangeTower(MapLocation location) : base(location)
        {
        }
    }
}

