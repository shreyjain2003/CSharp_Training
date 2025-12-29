using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Training.Day5_Scenarios
{
    /// <summary>
    /// Represents a generic bird with basic behaviors such as flying.
    /// </summary>
    /// <remarks>This class serves as a base type for specific bird implementations. Derived classes can
    /// override methods to provide specialized behavior.</remarks>
    public class Bird
    {
        public virtual void Fly()
        {
            Console.WriteLine("Bird is Flying");
        }
    }
    /// <summary>
    /// Represents a bird that is capable of both singing and dancing, in addition to flying.
    /// </summary>
    /// <remarks>Use this class when you need a bird with enhanced abilities beyond the standard bird
    /// behaviors. Inherits from the Bird class and adds methods for singing and dancing.</remarks>
    class SingingDancingBird : Bird
    {
        public void Sing()
        {
            Console.WriteLine("Bird is singing!");
        }
        public void Dance()
        {
            Console.WriteLine("Bird is dancing!");
        }
        public override void Fly()
        {
            Console.WriteLine("Singing and Dancing Bird is flying gracefully!");
        }
    }
    /// <summary>
    /// Represents a bird that is capable of both swimming and walking, in addition to flying short distances.
    /// </summary>
    /// <remarks>This class extends the Bird type to provide additional movement behaviors. Use this type when
    /// modeling birds that can swim and walk, as well as fly for limited distances.</remarks>
    class SwimmingWalkingBird: Bird
    {
        public void Swim()
        {
            Console.WriteLine("Bird is Swimming!");
        }
        public void Walk()
        {
            Console.WriteLine("Bird is Walking!");
        }
        public override void Fly()
        {
            Console.WriteLine("Swimming and Walking Bird flies short distance!");
        }
    }
    /// <summary>
    /// Provides the entry point for the application and demonstrates usage of bird-related classes.
    /// </summary>
    /// <remarks>The Birds class contains the Main method, which creates instances of bird types and invokes
    /// their behaviors to illustrate their capabilities. This class is intended for demonstration or testing
    /// purposes.</remarks>
    public class Birds
    {
        public static void Main(string[] args)
        {
            SingingDancingBird bird1 = new SingingDancingBird();
            bird1.Fly();
            bird1.Sing();
            bird1.Dance();

            Console.WriteLine();

            SwimmingWalkingBird bird2 = new SwimmingWalkingBird();
            bird2.Fly();
            bird2.Swim();
            bird2.Walk();

            Console.ReadLine();

        }
    }

}
