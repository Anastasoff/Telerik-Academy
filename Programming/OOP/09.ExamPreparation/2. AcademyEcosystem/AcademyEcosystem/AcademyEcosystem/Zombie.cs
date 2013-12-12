using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyEcosystem
{
    public class Zombie : Animal
    {
        public Zombie(string name, Point position)
            : base(name, position, 1)
        {
        }

        public override void Update(int timeElapsed)
        {
            this.Size = 10;
            base.Update(timeElapsed);
        }
    }
}
