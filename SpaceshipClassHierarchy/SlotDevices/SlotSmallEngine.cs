using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceshipClassHierarchy.SlotDevices
{
    class SlotSmallEngine: SlotDevice
    {
        SlotSmallEngine(int level)
        {
            size = SlotSize.Medium;
            numberOfDeviceComponents = 1;
            deviceComponents = new DeviceComponent[numberOfDeviceComponents];
            deviceComponents[0] = new DeviceComponentSmallEngine(level);
        }
    }
}
