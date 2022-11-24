using System;
using System.Collections.Generic;

namespace FactoryMethod
{
    /// <summary>
    /// Factory Method Design Pattern.
    /// </summary>

    class MainApp
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>

        static void Main()
        {
            // Note: constructors call Factory Method

            Card[] Cards = new Card[3];

            Cards[0] = new Credit();
            Cards[1] = new Debit();
            Cards[2] = new Service();

            // Display Card Types

            foreach (Card Card in Cards)
            {
                Console.WriteLine("\n" + Card.GetType().Name + "--");
                foreach (Type Type in Card.Types)
                {
                    Console.WriteLine(" " + Type.GetType().Name);
                }
            }

            // Wait for user

            Console.ReadKey();
        }
    }

    /// <summary>
    /// The 'Product' abstract class
    /// </summary>

    abstract class Type
    {
    }

    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>

    class SavingType : Type
    {
    }

    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>

    class InvertingType : Type
    {
    }

    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>

    class PointsType : Type
    {
    }

    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>

    class InternationalType : Type
    {
    }

    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>

    class DigitalType : Type
    {
    }

    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>

    class TravelType : Type
    {
    }

    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>

    class ExtensionsType : Type
    {
    }

    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>

    class InsurenceType : Type
    {
    }

    /// <summary>
    /// The 'Creator' abstract class
    /// </summary>

    abstract class Card
    {
        private List<Type> _Types = new List<Type>();

        // Constructor calls abstract Factory method

        public Card()
        {
            this.CreateTypes();
        }

        public List<Type> Types
        {
            get { return _Types; }
        }

        // Factory Method

        public abstract void CreateTypes();
    }

    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>

    class Credit : Card
    {
        // Factory Method implementation

        public override void CreateTypes()
        {
            Types.Add(new PointsType());
            Types.Add(new InternationalType());
            Types.Add(new DigitalType());
            Types.Add(new TravelType());
        }
    }

    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>

    class Debit : Card
    {
        // Factory Method implementation

        public override void CreateTypes()
        {
            Types.Add(new SavingType());
            Types.Add(new InvertingType());
            Types.Add(new DigitalType());
            Types.Add(new TravelType());
        }
    }

    class Service : Card
    {
        // Factory Method implementation

        public override void CreateTypes()
        {
            Types.Add(new PointsType());
            Types.Add(new InternationalType());
            Types.Add(new DigitalType());
            Types.Add(new TravelType());
            Types.Add(new ExtensionsType());
            Types.Add(new InsurenceType());
        }
    }
}
