namespace ThoughtfulAutomationSort.Domain
{
    using System;
    public class Package
    {
        public const string INVALID_VALUE_MESSAGE = "Not valid value, must be positive non-zero integer";
        public Package(int width, int height, int length, int mass)
        {
            if (width <= 0)
            {
                throw new ArgumentException(INVALID_VALUE_MESSAGE, nameof(width));
            }
            if (height <= 0)
            {
                throw new ArgumentException(INVALID_VALUE_MESSAGE, nameof(height));
            }
            if (length <= 0)
            {
                throw new ArgumentException(INVALID_VALUE_MESSAGE, nameof(length));
            }
            if (mass <= 0)
            {
                throw new ArgumentException(INVALID_VALUE_MESSAGE, nameof(mass));
            }

            this.Width = width;
            this.Height = height;
            this.Length = length;
            this.Mass = mass;
        }

        public int Width { get; private set; }
        public int Height { get; private set; }
        public int Length { get; private set; }
        public int Mass { get; private set; }

        public int Volume { get => this.Width * this.Height * this.Length; }
    }
}
