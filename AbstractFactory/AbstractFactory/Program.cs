using System;

namespace AbstractFactory
{

    class MainApp

    {
        /// Entry point into console application.
        public static void Main()
        {
            // Create and run the African animal world

            ContinentFactory africa = new AfricaFactory();
            AnimalWorld world = new AnimalWorld(africa);
            world.RunFoodChain();

            // Create and run the American animal world

            ContinentFactory america = new AmericaFactory();
            world = new AnimalWorld(america);
            world.RunFoodChain();

            // Wait for user input

            Console.ReadKey();
        }
    }

    /// The 'AbstractFactory' abstract class

    abstract class ContinentFactory

    {
       public abstract Herbivore CreateHerbivore();
       public abstract Carnivore CreateCarnivore();

        
    }

    /// The 'ConcreteFactory1' class

    class AfricaFactory : ContinentFactory

    {
        public override Herbivore CreateHerbivore()
        {
            return new Wildebeest();
        }
        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }
    }

    /// The 'ConcreteFactory2' class

    class AmericaFactory : ContinentFactory

    {
        public override Herbivore CreateHerbivore()
        {
            return new Bison();
        }
        public override Carnivore CreateCarnivore()
        {
            return new Wolf();
        }
    }

    /// The 'AbstractProductA' abstract class

    abstract class Herbivore

    {
    }

    /// The 'AbstractProductB' abstract class

    abstract class Carnivore

    {
        public abstract void Eat(Herbivore h);
    }

    /// The 'ProductA1' class

    class Wildebeest : Herbivore

    {
    }

    /// The 'ProductB1' class
  class Lion : Carnivore

    {
        public override void Eat(Herbivore h)
        {
            // Eat Wildebeest

            Console.WriteLine(this.GetType().Name +
              " eats " + h.GetType().Name);
        }
    }

    /// The 'ProductA2' class

    class Bison : Herbivore

    {
    }

    /// The 'ProductB2' class

    class Wolf : Carnivore

    {
        public override void Eat(Herbivore h)
        {
            // Eat Bison

            Console.WriteLine(this.GetType().Name +
              " eats " + h.GetType().Name);
        }
    }

    /// The 'Client' class 

    class AnimalWorld

    {
        private Herbivore _herbivore;
        private Carnivore _carnivore;

        // Constructor

        public AnimalWorld(ContinentFactory factory)
        {
            _carnivore = factory.CreateCarnivore();
            //Console.WriteLine(_carnivore);
            _herbivore = factory.CreateHerbivore();
            //Console.WriteLine(_herbivore);
        }

        public void RunFoodChain()
        {
            _carnivore.Eat(_herbivore);
        }
    }

 
        
 
 
          
    





}
