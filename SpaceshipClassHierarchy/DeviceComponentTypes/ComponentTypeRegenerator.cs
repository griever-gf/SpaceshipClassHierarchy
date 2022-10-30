using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceshipClassHierarchy
{
    abstract class ComponentTypeRegenerator : DeviceComponent
    {
        protected int healthRegenerationValue { get; set; }
        public abstract int GetRegenerationValue();
    }
}
