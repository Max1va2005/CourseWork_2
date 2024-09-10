namespace WinFormsApp4.Ammunitions.ValueObjects
{
    public sealed class AmmunitionName
    {
        public AmmunitionName(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Ammunition name cannot be null or empty.");
            }

            Value = value;
        }

        public string Value { get; }
    }
}
