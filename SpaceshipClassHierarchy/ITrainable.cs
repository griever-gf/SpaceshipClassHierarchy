using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceshipClassHierarchy
{
    interface ITrainable
    {
        int currentExp { get; set; }

        int currentLevel { get; set; }

        void AddExp(int value);

        void CheckForLevelUp();

        int CalculateLevelFromExp();
    }
}
