using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceshipClassHierarchy
{
    interface IDamageable
    {
        int currentHealth { get; }

        void ApplyDamage(int damage);
    }
}
