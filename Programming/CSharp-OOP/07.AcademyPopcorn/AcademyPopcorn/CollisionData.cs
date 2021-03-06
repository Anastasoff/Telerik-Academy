﻿namespace AcademyPopcorn
{
    using System.Collections.Generic;

    public class CollisionData
    {
        public readonly MatrixCoords CollisionForceDirection;
        public readonly List<string> HitObjectsCollisionGroupStrings;

        public CollisionData(MatrixCoords collisionForceDirection, string objectCollisionGroupString)
        {
            this.CollisionForceDirection = collisionForceDirection;
            this.HitObjectsCollisionGroupStrings = new List<string>();
            this.HitObjectsCollisionGroupStrings.Add(objectCollisionGroupString);
        }

        public CollisionData(MatrixCoords collisionForceDirection, List<string> hitObjectsCollisionGroupStrings)
        {
            this.CollisionForceDirection = collisionForceDirection;

            this.HitObjectsCollisionGroupStrings = new List<string>();

            foreach (var str in hitObjectsCollisionGroupStrings)
            {
                this.HitObjectsCollisionGroupStrings.Add(str);
            }
        }
    }
}
