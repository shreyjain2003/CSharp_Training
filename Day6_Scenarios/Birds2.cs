using System;

namespace Capgemini_Training.Day5_Scenarios
{
    /// <summary>
    /// Represents a generic bird with basic flying behavior.
    /// </summary>
    public class Bird2
    {
        public virtual void Fly2()
        {
            Console.WriteLine("Bird is flying");
        }
    }

    /// <summary>
    /// Defines performance-related behaviors like singing and dancing.
    /// </summary>
    interface IPerform
    {
        void Sing();
        void Dance();
    }

    /// <summary>
    /// Defines movement-related behaviors like swimming and walking.
    /// </summary>
    interface IMove
    {
        void Swim();
        void Walk();
    }

    /// <summary>
    /// Represents a bird that can sing and dance.
    /// </summary>
    class SingingDancingBird2 : Bird2, IPerform
    {
        public void Sing()
        {
            Console.WriteLine("Bird is singing!");
        }

        public void Dance()
        {
            Console.WriteLine("Bird is dancing!");
        }

        public override void Fly2()
        {
            Console.WriteLine("Singing and Dancing Bird is flying gracefully!");
        }
    }

    /// <summary>
    /// Represents a bird that can swim and walk.
    /// </summary>
    class SwimmingWalkingBird2 : Bird2, IMove
    {
        public void Swim()
        {
            Console.WriteLine("Bird is swimming!");
        }

        public void Walk()
        {
            Console.WriteLine("Bird is walking!");
        }

        public override void Fly2()
        {
            Console.WriteLine("Swimming and Walking Bird flies short distances!");
        }
    }

    /// <summary>
    /// Application entry point demonstrating bird behaviors.
    /// </summary>
    public class Birds2
    {
        public static void Main(string[] args)
        {
            Bird2 bird1 = new SingingDancingBird2();
            bird1.Fly2();

            IPerform performer = (IPerform)bird1;
            performer.Sing();
            performer.Dance();

            Console.WriteLine();

            Bird2 bird2 = new SwimmingWalkingBird2();
            bird2.Fly2();

            IMove mover = (IMove)bird2;
            mover.Swim();
            mover.Walk();

            Console.ReadLine();
        }
    }
}
