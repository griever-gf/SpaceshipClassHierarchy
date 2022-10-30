using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceshipClassHierarchy
{
    class SlotMachineGun: SlotDevice
    {
        SlotMachineGun(int level)
        {
            size = SlotSize.Small;
            numberOfDeviceComponents = 1;
            deviceComponents = new DeviceComponent[numberOfDeviceComponents];
            deviceComponents[0] = new DeviceComponentMachineGun(level);
        }
    }
}
