using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceshipClassHierarchy
{
    class DeviceComponentSmallEngine: ComponentTypeEngine
    {
        public DeviceComponentSmallEngine(int level)
        {
            thrust = 500;
            componentLevel = level;
        }
    }
}
