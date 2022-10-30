using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceshipClassHierarchy
{
    class DeviceComponentLargeEngine : ComponentTypeEngine
    {
        public DeviceComponentLargeEngine(int level)
        {
            thrust = 2000;
            componentLevel = level;
        }
    }
}
