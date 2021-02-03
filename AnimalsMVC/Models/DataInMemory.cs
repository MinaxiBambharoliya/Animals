using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalsMVC.Models
{
    public class DataInMemory : IData
    {
        public List<Animal> AnimalList { get; set; }

        public List<Animal> AnimalsInitializeData()
        {
            AnimalList = new List<Animal>()
            {
                new Animal()
                {
                    Id=101,
                    Name="Elephant",
                    Category="Mammal",
                    Information = "Warm-Blooded, give birth to babies.",
                    ImageName = "elephant.jpg"
                },
                new Animal()
                {
                    Id=102,
                    Name="Snake",
                    Category="Reptile",
                    Information = "Cold-Blooded, lay eggs.",
                    ImageName = "snake.jpg"
                },
                new Animal()
                {
                    Id=103,
                    Name="Shark",
                    Category="Fish",
                    Information = "Cold-Blooded, have fins.",
                    ImageName = "shark.jpg"
                },
                new Animal()
                {
                    Id=104,
                    Name="Parrot",
                    Category="Bird",
                    Information = "Can fly, lay eggs.",
                    ImageName = "parrot.jpg"
                },
            };
            return AnimalList;
        }

        public Animal GetAnimalById(int? id)
        {
            if (id == null)
                return null;
            return AnimalList.SingleOrDefault(a => a.Id == id);
        }
    }
}
