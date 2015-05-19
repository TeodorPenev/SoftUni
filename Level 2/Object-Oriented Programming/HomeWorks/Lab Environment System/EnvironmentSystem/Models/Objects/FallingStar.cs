using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvironmentSystem.Models.Objects
{
    class FallingStar:MovingObject
    {
        protected const char FallingStarCharImage = '#';

        public FallingStar(int x, int y, Point direction) : base(x, y, 1, 1, direction)
        {
            this.ImageProfile = new char[,] {{FallingStarCharImage}};
        }

        public override void RespondToCollision(CollisionInfo collisionInfo)
        {
            var hitObjectGroup = collisionInfo.HitObject;
            if (hitObjectGroup is Ground)
            {
                this.Exists = false;
            }
        }

        public override IEnumerable<EnvironmentObject> ProduceObjects()
        {
           List<EnvironmentObject> produceObjects = new List<EnvironmentObject>();
            produceObjects.Add(new Tail(this.Bounds.TopLeft.X-this.Direction.X,this.Bounds.TopLeft.Y-this.Direction.Y));
            produceObjects.Add(new Tail(this.Bounds.TopLeft.X - 2*this.Direction.X, this.Bounds.TopLeft.Y - 2* this.Direction.Y));
            produceObjects.Add(new Tail(this.Bounds.TopLeft.X -3* this.Direction.X, this.Bounds.TopLeft.Y - 3*this.Direction.Y));
            return produceObjects;
        }
    }
}
