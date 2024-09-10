namespace WinFormsApp4.Ammunitions.ValueObjects
{
    public sealed class Price
    {
        public Price(
            decimal amount,
            Currency currency)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Price cannot be less than zero.");
            }

            Amount = amount;
            Currency = currency;
        }

        public decimal Amount { get; }

        public Currency Currency { get; }

        public override string ToString()
        {
            return $"{Amount} {Currency}";
        }
    }
}
