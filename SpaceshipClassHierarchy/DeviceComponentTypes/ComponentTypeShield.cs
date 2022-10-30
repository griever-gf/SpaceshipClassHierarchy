using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceshipClassHierarchy
{
    abstract class ComponentTypeShield : DeviceComponent
    {
        protected float plasmaRayResistancePercent { get; set; }

        public abstract float GetResistance();
    }
}
