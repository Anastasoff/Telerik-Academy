using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyEcosystem
{
    public class Lion : Animal, ICarnivore
    {
        public Lion(string name, Point position)
            : base(name, position, 6)
        {
        }

        public int TryEatAnimal(Animal animal)
        {
            if (animal != null && animal.GetType().Name == "Zombie")
            {
                return 10;
            }

            if (animal != null && animal.Size <= (this.Size * 2))
            {
                this.Size++;
                return animal.GetMeatFromKillQuantity();
            }

            return 0;
        }
    }
}
