using WinFormsApp4.Ammunitions.Abstractions;
using WinFormsApp4.Ammunitions.ValueObjects;
using ShootingRange = WinFormsApp4.Ammunitions.ValueObjects.ShootingRange;

namespace WinFormsApp4.Ammunitions
{
    public sealed class MineAmmunition : Ammunition
    {
        public MineAmmunition(
            Guid id,
            AmmunitionName name,
            Caliber caliber, 
            ShootingRange range,
            Weight weight,
            OriginCountry countryOfOrigin,
            Price price)
            : base(id,
                  name,
                  caliber,
                  range,
                  weight,
                  countryOfOrigin,
                  price)
        { }

        public override AmmunitionPurpose Purpose => AmmunitionPurpose.Military; 

        public override string Type => "Mine";
    }
}
