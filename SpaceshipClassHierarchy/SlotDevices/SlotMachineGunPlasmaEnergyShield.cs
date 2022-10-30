using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceshipClassHierarchy
{
    class SlotMachineGunPlasmaEnergyShield : SlotDevice
    {
        SlotMachineGunPlasmaEnergyShield(int level)
        {
            size = SlotSize.Big;
            numberOfDeviceComponents = 3;
            deviceComponents = new DeviceComponent[numberOfDeviceComponents];
            deviceComponents[0] = new DeviceComponentMachineGun(level);
            deviceComponents[1] = new DeviceComponentPlasmaCannon(level);
            deviceComponents[2] = new DeviceComponentEnergyShield(level);
        }
    }
}
