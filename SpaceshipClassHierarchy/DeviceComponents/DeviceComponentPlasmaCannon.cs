using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceshipClassHierarchy
{
    class DeviceComponentPlasmaCannon : ComponentTypeGun
    {
        RayType rayType { get; set; }

        public DeviceComponentPlasmaCannon(int level)
        {
            componentLevel = level;
            damage = 200;
            bulletsPerSecond = 5;
            magazineSize = 6;
            magazineReloadTime = 2;
            shootingDistance = 100;
        }

        public override int GetShootingDistance()
        {
            int val = base.GetShootingDistance();

            switch (rayType)
            {
                case RayType.standard:
                default:
                    return val* componentLevel;
                case RayType.enforced:
                    return val * componentLevel * 2;
            }
        }
    }
}
