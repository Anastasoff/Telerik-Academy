﻿namespace AcademyPopcorn
{
    public class IndestructibleBlock : Block
    {
        public const char Symbol = '|';
        public new const string CollisionGroupString = "indestructibleBlock";

        public IndestructibleBlock(MatrixCoords upperLeft)
            : base(upperLeft)
        {
            this.body[0, 0] = IndestructibleBlock.Symbol;
        }

        public override string GetCollisionGroupString()
        {
            return IndestructibleBlock.CollisionGroupString;
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            // base.RespondToCollision(collisionData);
        }
    }
}
