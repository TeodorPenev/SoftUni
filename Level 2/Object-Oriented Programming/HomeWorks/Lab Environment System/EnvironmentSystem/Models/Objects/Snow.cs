﻿namespace EnvironmentSystem.Models.Objects
{
    using System.Collections.Generic;
    using EnvironmentSystem.Models.Data.Structures;

    public class Snow : EnvironmentObject
    {
        public Snow(int x, int y):base(x,y,1,1)
            
        {
            this.ImageProfile = new char[,] { { '.' } };
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
