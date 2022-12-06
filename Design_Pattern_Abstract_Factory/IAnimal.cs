using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Abstract_Factory
{
    // interface
    public interface IAnimal 
    {
        string speak();
    }

    //class
    public class Cat : IAnimal // Concrete  class
    {
        public string speak()
        {
            return "Meow Meow Meow";
        }
    }

    public class Lion : IAnimal // Concrete  class
    {
        public string speak()
        {
            return "Roar";
        }
    }

    public class Dog : IAnimal // Concrete  class
    {
        public string speak()
        {
            return "Bark bark";
        }
    }

    public class Octopus : IAnimal // Concrete  class
    {
        public string speak()
        {
            return "SQUAWCK";
        }
    }

    public class Shark : IAnimal // Concrete  class
    {
        public string speak()
        {
            return "Cannot Speak";
        }
    }

    // abstract factory

    public abstract class AnimalFactory // abstract factory class
    {
        public abstract IAnimal GetAnimal(string AnimalType);
        public static AnimalFactory CreateAnimalFactory(string FactoryType)
        {
            if (FactoryType.Equals("Sea"))
                return new SeaAnimalFactory();
            else
                return new LandAnimalFactory();
        }
    }

    public class LandAnimalFactory : AnimalFactory // Concrete  class
    {
        public override IAnimal GetAnimal(string AnimalType)
        {
            if (AnimalType.Equals("Dog"))
            {
                return new Dog();
            }
            else if (AnimalType.Equals("Cat"))
            {
                return new Cat();
            }
            else if (AnimalType.Equals("Lion"))
            {
                return new Lion();
            }
            else
                return null;
        }
    }

    public class SeaAnimalFactory : AnimalFactory // Concrete  class
    {
        public override IAnimal GetAnimal(string AnimalType)
        {
            if (AnimalType.Equals("Shark"))
            {
                return new Shark();
            }
            else if (AnimalType.Equals("Octopus"))
            {
                return new Octopus();
            }
            else
                return null;
        }
    }
}
