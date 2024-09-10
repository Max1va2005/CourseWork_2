namespace WinFormsApp4.Ammunitions.ValueObjects
{
    public sealed class ShootingRange
    {
        private const int MaxPossibleValue = 100000;

        public ShootingRange(int valueInMeters)
        {
            if (valueInMeters < 0)
            {
                throw new ArgumentException("Range cannot be less than zero.");
            }

            if (valueInMeters > MaxPossibleValue)
            {
                throw new ArgumentException(
                    $"Range cannot be more than {MaxPossibleValue}. You provided: {valueInMeters}.");
            }

            ValueInMeters = valueInMeters;
        }

        public int ValueInMeters { get; }
    }
}
