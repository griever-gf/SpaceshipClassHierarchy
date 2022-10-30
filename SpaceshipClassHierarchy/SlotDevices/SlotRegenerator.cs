using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceshipClassHierarchy
{
    class SlotRegenerator: SlotDevice
    {
        SlotRegenerator(int level)
        {
            size = SlotSize.Small;
            numberOfDeviceComponents = 1;
            deviceComponents = new DeviceComponent[numberOfDeviceComponents];
            deviceComponents[0] = new DeviceComponentRegenerator(level);
        }
    }
}
