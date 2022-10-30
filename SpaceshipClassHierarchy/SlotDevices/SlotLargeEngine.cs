using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceshipClassHierarchy.SlotDevices
{
    class SlotLargeEngine: SlotDevice
    {
        SlotLargeEngine(int level)
        {
            size = SlotSize.Big;
            numberOfDeviceComponents = 1;
            deviceComponents = new DeviceComponent[numberOfDeviceComponents];
            deviceComponents[0] = new DeviceComponentLargeEngine(level);
        }
    }
}
