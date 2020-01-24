using System;
using System.Collections.Generic;
using System.Text;

namespace PoisonedApples
{
    public class AppleTree
    {
        private AppleColour GetColour(int colourIndex)
        {
            if (colourIndex % 13 == 0 || colourIndex % 29 == 0)
            {
                return AppleColour.Green;
            }

            if (colourIndex % 11 == 0 || colourIndex % 19 == 0)
            {
                return AppleColour.Yellow;
            }

            return AppleColour.Red;
        }

        public IEnumerable<Apple> PickApples()
        {
            int colourIndex = 1;
            int poisonIndex = 7;

            while (true)
            {
                yield return new Apple(
                    GetColour(colourIndex),
                    poisonIndex % 41 == 0
                );

                colourIndex += 5;
                poisonIndex += 37;
            }
        }
    }
}
