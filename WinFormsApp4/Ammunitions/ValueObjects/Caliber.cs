namespace WinFormsApp4.Ammunitions.ValueObjects
{
    public sealed class Caliber
    {
        public Caliber(
            double size,
            string unit)
        {
            if (size <= 0)
            {
                throw new ArgumentException("Size must be positive.");
            }

            if (string.IsNullOrWhiteSpace(unit))
            {
                throw new ArgumentException("Unit cannot be null or empty.");
            }

            Size = size;
            Unit = unit;
        }

        public double Size { get; }

        public string Unit { get; }

        public override string ToString()
        {
            return $"{Size}{Unit}";
        }
    }
}
