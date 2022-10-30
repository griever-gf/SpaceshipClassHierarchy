using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceshipClassHierarchy.SlotDevices
{
    class SlotDoubleMachineGun : SlotDevice
    {
        public SlotDoubleMachineGun(int level)
        {
            size = SlotSize.Medium;
            numberOfDeviceComponents = 2;
            deviceComponents = new DeviceComponent[numberOfDeviceComponents];
            deviceComponents[0] = new DeviceComponentMachineGun(level);
            deviceComponents[1] = new DeviceComponentMachineGun(level);
        }
    }
}
