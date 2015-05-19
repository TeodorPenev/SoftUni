using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using EnvironmentSystem.Models.Data.Structures;

namespace EnvironmentSystem.Models.Objects
{
    public class Tail:EnvironmentObject
    {
        private int lifetime;
        private static readonly char[,] TailCharImage = {{'*'}};

        public Tail(int x, int y, int lifetime=1)
            : base(x, y, 1, 1)
        {
            this.lifetime = lifetime;
            this.ImageProfile = TailCharImage;
        }

        public override void Update()
        {
            this.lifetime--;
            if (lifetime <= 0)
            {
                this.Exists = false;
            }
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
