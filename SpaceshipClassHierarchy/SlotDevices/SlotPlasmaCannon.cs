using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceshipClassHierarchy.SlotDevices
{
    class SlotPlasmaCannon : SlotDevice
    {
        SlotPlasmaCannon(int level)
        {
            size = SlotSize.Small;
            numberOfDeviceComponents = 1;
            deviceComponents = new DeviceComponent[numberOfDeviceComponents];
            deviceComponents[0] = new DeviceComponentPlasmaCannon(level);
        }
    }
}
