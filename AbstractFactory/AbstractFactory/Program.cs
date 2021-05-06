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






                int unOps = 5;
                int preIncrement;
                int preDecrement;
                int postIncrement;
                int postDecrement;
                int positive;
                int negative;
                bool temp;

                preIncrement = ++unOps;
                Console.WriteLine("pre-Increment: {0}", preIncrement);

                preDecrement = --unOps;
                Console.WriteLine("pre-Decrement: {0}", preDecrement);

                postDecrement = unOps--;
                Console.WriteLine("Post-Decrement: {0}", postDecrement);

                postIncrement = unOps++;
                Console.WriteLine("Post-Increment: {0}", postIncrement);

                Console.WriteLine("Final Value of unOps is: {0}", unOps);

                positive = +postIncrement;
                Console.WriteLine("Positive: {0}", positive);

                negative = -postIncrement;
                Console.WriteLine("Negative: {0}", negative);

                temp = false;
                temp = !temp;
                Console.WriteLine("Logical Not: {0}", temp);
            
        }
    }


    /// <summary>

    /// The 'AbstractFactory' abstract class

    /// </summary>

    abstract class ContinentFactory

    {
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();
    }

    /// <summary>

    /// The 'ConcreteFactory1' class

    /// </summary>

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

    /// <summary>

    /// The 'ConcreteFactory2' class

    /// </summary>

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

    /// <summary>

    /// The 'AbstractProductA' abstract class

    /// </summary>

    abstract class Herbivore

    {
    }

    /// <summary>

    /// The 'AbstractProductB' abstract class

    /// </summary>

    abstract class Carnivore

    {
        public abstract void Eat(Herbivore h);
    }

    /// <summary>

    /// The 'ProductA1' class

    /// </summary>

    class Wildebeest : Herbivore

    {
    }

    /// <summary>

    /// The 'ProductB1' class

    /// </summary>

    class Lion : Carnivore

    {
        public override void Eat(Herbivore h)
        {
            // Eat Wildebeest

            Console.WriteLine(this.GetType().Name +
              " eats " + h.GetType().Name);
        }
    }

    /// <summary>

    /// The 'ProductA2' class

    /// </summary>

    class Bison : Herbivore

    {
    }

    /// <summary>

    /// The 'ProductB2' class

    /// </summary>

    class Wolf : Carnivore

    {
        public override void Eat(Herbivore h)
        {
            // Eat Bison

            Console.WriteLine(this.GetType().Name +
              " eats " + h.GetType().Name);
        }
    }

    /// <summary>

    /// The 'Client' class 

    /// </summary>

    class AnimalWorld

    {
        private Herbivore _herbivore;
        private Carnivore _carnivore;

        // Constructor

        public AnimalWorld(ContinentFactory factory)
        {
            _carnivore = factory.CreateCarnivore();
            _herbivore = factory.CreateHerbivore();
        }

        public void RunFoodChain()
        {
            _carnivore.Eat(_herbivore);
        }
    }









}
