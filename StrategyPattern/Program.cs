﻿using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallardDuck = new Ducks.MallardDuck();
            runDuck("Mallard", mallardDuck);

            Duck redheadDuck = new Ducks.ReadheadDuck();
            runDuck("Redhead", redheadDuck);

            Duck rubberDuck = new Ducks.RubberDuck();
            runDuck("Rubber", rubberDuck);

            Duck modelDuck = new Ducks.ModelDuck();
            modelDuck.SetFlyBehavior(new Behaviors.FlyRocketPowered());
            runDuck("Model", modelDuck);
        }

        private static void runDuck(string name, Duck duck){
            Console.WriteLine($"Simmulating duck -- {name}");
            duck.Display();
            duck.Quack();
            duck.Swim();
            duck.Fly();
            Console.WriteLine("Simmulation Complete\n\n\n");
        }
    }
}
