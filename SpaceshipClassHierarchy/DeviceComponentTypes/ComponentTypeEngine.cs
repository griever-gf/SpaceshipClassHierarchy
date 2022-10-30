using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceshipClassHierarchy
{
    abstract class ComponentTypeEngine : DeviceComponent
    {
        public int thrust { get; set; }
    }
}
