// Static Class Sequence

namespace Ch11Q7.CreatingAndUsingObjects
{
    public static class Sequence
    {
        private static int currentValue = 1;

        public static int NextValue()
        {
            return currentValue++;
        }

    }
}