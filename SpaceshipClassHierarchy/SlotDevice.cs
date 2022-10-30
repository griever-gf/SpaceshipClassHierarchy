using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceshipClassHierarchy
{
    class SlotDevice: IDamageable, ITrainable
    {
        public int currentHealth { get; private set; }

        public void ApplyDamage(int damage)
        {
            if (currentHealth >= 0)
                currentHealth -= damage;
            else
                currentHealth = 0;
        }

        public bool HasZeroHealth()
        {
            return (currentHealth == 0);
        }

        public int currentExp { get; set; }
        public int currentLevel { get; set; }

        public SlotSize size;

        public int numberOfDeviceComponents;
        public DeviceComponent[] deviceComponents;

        public void AddExp(int value)
        {
            currentExp += value;
            CheckForLevelUp();
        }

        public void CheckForLevelUp()
        {
            int newLevel = CalculateLevelFromExp();
            if (currentLevel != newLevel)
                currentLevel = newLevel;
        }

        public int CalculateLevelFromExp()
        {
            //заглушка, в дальнейшем заменить на формулу расчёта уровня
            return (currentExp / 1000);
        }
    }
}
