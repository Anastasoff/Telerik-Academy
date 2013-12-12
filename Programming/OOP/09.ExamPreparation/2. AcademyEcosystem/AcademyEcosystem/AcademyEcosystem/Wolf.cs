using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyEcosystem
{
    public class Wolf : Animal, ICarnivore
    {
        public Wolf(string name, Point position)
            : base(name, position, 4)
        {
        }

        public int TryEatAnimal(Animal animal)
        {
            if (animal != null && animal.GetType().Name == "Zombie")
            {
                return 10;
            }

            if (animal != null && animal.Size <= this.Size)
            {
                return animal.GetMeatFromKillQuantity();
            }

            if (animal != null && animal.State == AnimalState.Sleeping )
            {
                return animal.GetMeatFromKillQuantity();
            }

            return 0;
        }
    }
}
