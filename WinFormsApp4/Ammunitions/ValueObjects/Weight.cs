namespace WinFormsApp4.Ammunitions.ValueObjects
{
    public sealed class Weight
    {
        public Weight(
            decimal amount,
            UnitOfWeight unit)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Weight cannot be negative.");
            }

            Amount = amount;
            Unit = unit;
        }

        public decimal Amount { get; }

        public UnitOfWeight Unit { get; }

        public override string ToString()
        {
            return $"{Amount} {Unit}";
        }
    }
}
