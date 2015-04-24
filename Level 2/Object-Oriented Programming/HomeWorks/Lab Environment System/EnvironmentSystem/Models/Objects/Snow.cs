﻿namespace EnvironmentSystem.Models.Objects
{
    using System.Collections.Generic;
    using EnvironmentSystem.Models.Data.Structures;

    public class Snow : EnvironmentObject
    {
        public Snow(int x, int y, int width, int height)
            : this(new Rectangle(x, y, width, height))
        {
        }

        public Snow(Rectangle rect)
            : base(rect)
        {
            this.ImageProfile = new char[,] { { '.' } };
            this.CollisionGroup = CollisionGroup.Snow;
        }

        public override void Update()
        {
        }

        public override void RespondToCollision(CollisionInfo collisionInfo)
        {
        }

        public override IEnumerable<EnvironmentObject> ProduceObjects()
        {
            return new List<EnvironmentObject>();
        }
    }
}
