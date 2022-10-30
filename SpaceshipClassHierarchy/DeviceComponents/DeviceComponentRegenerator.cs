using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceshipClassHierarchy
{
    class DeviceComponentRegenerator: ComponentTypeRegenerator
    {
        public DeviceComponentRegenerator(int level)
        {
            healthRegenerationValue = 200;
            componentLevel = level;
        }

        public override int GetRegenerationValue()
        {
            return (int)(healthRegenerationValue * (1 + (float)(componentLevel / 5)));
        }
    }
}
