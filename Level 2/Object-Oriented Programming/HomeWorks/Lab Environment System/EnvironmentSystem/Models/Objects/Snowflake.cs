using System.Collections.Generic;

namespace EnvironmentSystem.Models.Objects
{
    public class Snowflake : MovingObject
    {
        protected const char SnowflakeCharImage = '*';

        public Snowflake(int x, int y, int width, int height, Point direction)
            : base(x, y, width, height, direction)
        {
            this.ImageProfile = this.GenerateImageProfile();
            this.CollisionGroup = CollisionGroup.Snowflake;
        }

        protected virtual char[,] GenerateImageProfile()
        {
            return new char[,] {{SnowflakeCharImage}};
        }

        public override void RespondToCollision(CollisionInfo collisionInfo)
        {
            var hitObjectGroup = collisionInfo.HitObject;
            if (hitObjectGroup is Ground || hitObjectGroup is Snow )
            {
                this.Exists = false;
            }
        }

        public override IEnumerable<EnvironmentObject> ProduceObjects()
        {
            List<EnvironmentObject> producedObjects = new List<EnvironmentObject>();
            if (!this.Exists)
            {
                producedObjects.Add(new Snow(this.Bounds.TopLeft.X, this.Bounds.TopLeft.Y-1));
            }

            return producedObjects;
        }
    }
}


