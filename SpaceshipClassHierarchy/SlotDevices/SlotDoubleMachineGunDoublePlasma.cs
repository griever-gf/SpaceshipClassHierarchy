using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceshipClassHierarchy
{
    class SlotDoubleMachineGunDoublePlasma: SlotDevice
    {
        SlotDoubleMachineGunDoublePlasma(int level)
        {
            size = SlotSize.Big;
            numberOfDeviceComponents = 4;
            deviceComponents = new DeviceComponent[numberOfDeviceComponents];
            deviceComponents[0] = new DeviceComponentMachineGun(level);
            deviceComponents[1] = new DeviceComponentMachineGun(level);
            deviceComponents[2] = new DeviceComponentPlasmaCannon(level);
            deviceComponents[3] = new DeviceComponentPlasmaCannon(level);
        }
    }
}
