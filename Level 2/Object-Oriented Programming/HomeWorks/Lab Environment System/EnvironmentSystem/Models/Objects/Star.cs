using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvironmentSystem.Models.Objects
{
    public class Star : EnvironmentObject
    {
        private static readonly char[] starCharImageProfile = new char[]{'O','@','0'};
        private int updateCount = 0;
        private static Random randomizer= new Random();

        public Star(int x, int y)
            : base(x, y, 1, 1)
        {
            this.ImageProfile = new char[,] { { starCharImageProfile[0] } };
        }

        public override void Update()
        {
            if (updateCount == 10)
            {
                int index = randomizer.Next(0, starCharImageProfile.Length);
                this.ImageProfile=new char[,] { { starCharImageProfile[index] } };
                this.updateCount = 0;
            }
            updateCount++;
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
