using WinFormsApp4.Ammunitions.ValueObjects;
using ShootingRange = WinFormsApp4.Ammunitions.ValueObjects.ShootingRange;

namespace WinFormsApp4.Ammunitions.Abstractions
{
    public abstract class Ammunition
    {
        protected Ammunition(
            Guid id,
            AmmunitionName name,
            Caliber caliber,
            ShootingRange range,
            Weight weight,
            OriginCountry countryOfOrigin,
            Price price)
        {
            EnsureAllAreNotNull(
                name,
                caliber,
                range,
                weight,
                countryOfOrigin,
                price);

            Name = name!;
            Caliber = caliber!;
            ShootingRange = range!;
            Weight = weight!;
            OriginCountry = countryOfOrigin!;
            Price = price!;
            Id = id;
        }

        public Guid Id { get; }
        public AmmunitionName Name { get; }
        public Caliber Caliber { get; }
        public ShootingRange ShootingRange { get; }
        public Weight Weight { get; }
        public OriginCountry OriginCountry { get; }
        public Price Price { get; }

        public abstract AmmunitionPurpose Purpose { get; }
        public abstract string Type { get; }

        private static void EnsureAllAreNotNull(params object?[] objects)
        {
            if (objects.Any(obj => obj is null))
            {
                throw new ArgumentNullException();
            }
        }
    }
}
