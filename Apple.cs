using System;
using System.Collections.Generic;
using System.Text;

namespace PoisonedApples
{
    public enum AppleColour
    {
        Green,
        Yellow,
        Red
    }

    public class Apple
    {
        public AppleColour Colour { get; }
        public bool Poisoned { get; }

        public Apple(AppleColour colour, bool poisoned)
        {
            Colour = colour;
            Poisoned = poisoned;
        }

        public override string ToString()
        {
            return $"{Colour} apple{(Poisoned ? " (poisoned!)" : "")}";
        }

        public override int GetHashCode()
        {
            return (Colour.GetHashCode() << 1) | (Poisoned ? 1 : 0);
        }

        public override bool Equals(object obj)
        {
            if (obj is Apple other)
            {
                return (other.Colour == this.Colour)
                       && (other.Poisoned == this.Poisoned);
            }
            return false;
        }
    }
}
