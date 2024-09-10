namespace WinFormsApp4.Ammunitions.ValueObjects
{
    public sealed class OriginCountry
    {
        public OriginCountry(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Origin country name cannot be null or empty.");
            }

            Name = name;
        }

        public string Name { get; }
    }
}
