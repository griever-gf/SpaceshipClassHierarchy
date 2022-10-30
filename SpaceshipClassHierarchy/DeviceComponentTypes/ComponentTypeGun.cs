using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceshipClassHierarchy
{
    abstract class ComponentTypeGun : DeviceComponent
    {
        protected int damage;
        protected int bulletsPerSecond;
        protected int magazineSize;
        public float magazineReloadTime { get; set; }
        public int shootingDistance;

        public bool IsReloadTime { get; set; }
        int bulletsLeftInMagazine;
        public float reloadStartTime { get; set; }

        public ComponentTypeGun()
        {
            bulletsLeftInMagazine = magazineSize;
        }

        public virtual int GetCurrentDamagePerSecond()
        {
            int val;
            if (!IsReloadTime)
            {
                val = damage * bulletsPerSecond;
                bulletsLeftInMagazine -= bulletsPerSecond;
            }
            else
            {
                val = 0;
                bulletsLeftInMagazine = 0;
            }
            return val;
        }

        public virtual int GetShootingDistance()
        {
            return shootingDistance;
        }
    }
}
