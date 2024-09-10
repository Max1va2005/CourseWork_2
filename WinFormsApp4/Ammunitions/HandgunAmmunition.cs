﻿using WinFormsApp4.Ammunitions.Abstractions;
using WinFormsApp4.Ammunitions.ValueObjects;
using ShootingRange = WinFormsApp4.Ammunitions.ValueObjects.ShootingRange;

namespace WinFormsApp4.Ammunitions
{
    public sealed class HandgunAmmunition : Ammunition
    {
        public HandgunAmmunition(
            Guid id,
            AmmunitionName name,
            Caliber caliber,
            ShootingRange range,
            Weight weight,
            OriginCountry originCountry,
            Price price)
            : base(id,
                  name,
                  caliber,
                  range,
                  weight,
                  originCountry,
                  price)
        { }

        public override AmmunitionPurpose Purpose => AmmunitionPurpose.SelfDefense;

        public override string Type => "Handgun";
    }
}
