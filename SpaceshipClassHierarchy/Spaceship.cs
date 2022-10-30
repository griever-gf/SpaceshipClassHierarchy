using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceshipClassHierarchy
{
    class Spaceship : IDamageable, ITrainable
    {
        public int currentHealth { get; private set; }

        public int currentExp { get; set; }
        public int currentLevel { get; set; }

        Spaceship()
        {
            currentHealth = CalculateHealthFromLevel();
        }

        public void ApplyDamage(int damage)
        {
            int energyShieldCounter = 0;
            float damageReducePercent = 0;
            for (int j = 0; j < numberOfSlots; j++)
                if (!slotDevices[j].HasZeroHealth())
                    for (int i = 0; i < slotDevices[j].numberOfDeviceComponents; i++)
                    {
                        var trycast = slotDevices[j].deviceComponents[i] as ComponentTypeShield;
                        if (trycast != null)
                        {
                            energyShieldCounter++;
                            damageReducePercent += trycast.GetResistance();
                        }
                    }
            damage -= damage * (int)(damageReducePercent / 100);

            if (energyShieldCounter > 0) //if any alive shield present
            {
                int regen_hp = 0;
                for (int j = 0; j < numberOfSlots; j++)
                    if (!slotDevices[j].HasZeroHealth())
                        for (int i = 0; i < slotDevices[j].numberOfDeviceComponents; i++)
                        {
                            var trycast = slotDevices[j].deviceComponents[i] as ComponentTypeRegenerator;
                            if (trycast != null)
                            {
                                regen_hp += trycast.GetRegenerationValue();
                            }
                        }
                damage -= regen_hp;
            }

            currentHealth -= damage;

            if (currentHealth < 0)
                DestroyShip();
        }

        private void DestroyShip()
        {

        }

        public int numberOfSlots;
        public SlotDevice[] slotDevices;

        public void ApplyDamageToSlot(int damage, int slot)
        {
            slotDevices[slot].ApplyDamage(damage);
        }

        public virtual void ShootBySlotDeviceOnAnotherSpaceship(int slot, Spaceship enemyShip)
        {
            int damage = 0;
            if (!slotDevices[slot].HasZeroHealth())
                for (int i = 0; i < slotDevices[slot].numberOfDeviceComponents; i++)
                {
                    var trycast = slotDevices[slot].deviceComponents[i] as ComponentTypeGun;
                    if (trycast != null)
                    {
                        damage += (trycast as ComponentTypeGun).GetCurrentDamagePerSecond();
                    }
                }
            enemyShip.ApplyDamage(damage);
        }

        public int GetTotalThrust()
        {
            int thrust = 0;
            for (int j = 0; j < numberOfSlots; j++)
                if (!slotDevices[j].HasZeroHealth())
                    for (int i = 0; i < slotDevices[j].numberOfDeviceComponents; i++)
                    {
                        var trycast = slotDevices[j].deviceComponents[i] as ComponentTypeEngine;
                        if (trycast != null)
                        {
                            thrust += (trycast as ComponentTypeEngine).thrust;
                        }
                    }
            return thrust;
        }

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

        int CalculateHealthFromLevel()
        {
            //заглушка, в дальнейшем заменить на формулу расчёта здоровья в зависимости от уровня
            return (currentLevel * currentHealth);
        }
    }
}
