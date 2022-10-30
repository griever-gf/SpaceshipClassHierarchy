using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceshipClassHierarchy
{
    class DeviceComponentMachineGun : ComponentTypeGun
    {
        BulletType bulletType { get; set; }

        public DeviceComponentMachineGun(int level)
        {
            componentLevel = level;
            damage = 100;
            bulletsPerSecond = 4;
            magazineSize = 2;
            magazineReloadTime = 1;
            shootingDistance = 100;
        }

        public override int GetCurrentDamagePerSecond()
        {
            int val = base.GetCurrentDamagePerSecond();
            switch (bulletType)
            {
                case BulletType.standard:
                default:
                    return val* componentLevel;
                case BulletType.piercing:
                    return val* componentLevel * 2;
            }
        }
    }
}
