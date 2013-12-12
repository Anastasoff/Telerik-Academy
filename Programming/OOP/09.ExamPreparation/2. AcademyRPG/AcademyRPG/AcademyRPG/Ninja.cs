using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    public class Ninja : Character, IFighter, IGatherer
    {
        public Ninja(string name, Point position, int owner)
            : base(name, position, owner)
        {
            this.HitPoints = 1;
            this.AttackPoints = 0;
        }

        public int AttackPoints { get; private set; }

        public int DefensePoints
        {
            get { return int.MaxValue; }
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            int highestHitPoints = int.MinValue;
            int index = 0;
            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[i].HitPoints > highestHitPoints)
                {
                    highestHitPoints = availableTargets[i].HitPoints;
                    index = i;
                }
            }

            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[i].Owner != this.Owner && availableTargets[i].Owner != 0)
                {
                    if (i == index)
                    {
                        return i;
                    }
                }
            }

            return -1;
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Stone)
            {
                this.AttackPoints += (resource.Quantity * 2);

                return true;
            }

            if (resource.Type == ResourceType.Lumber)
            {
                this.AttackPoints += resource.Quantity;

                return true;
            }

            return false;
        }
    }
}
