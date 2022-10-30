using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceshipClassHierarchy
{
    class DeviceComponentEnergyShield: ComponentTypeShield
    {
        public DeviceComponentEnergyShield(int level)
        {
            plasmaRayResistancePercent = 15;
            componentLevel = level;
        }

        public override float GetResistance()
        {
            //need to insert resistance formula
            return (plasmaRayResistancePercent * (1 + (float)componentLevel / 10));
        }
    }
}
