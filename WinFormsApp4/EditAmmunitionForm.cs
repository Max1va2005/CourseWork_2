using WinFormsApp4.Ammunitions;
using WinFormsApp4.Ammunitions.Abstractions;
using WinFormsApp4.Ammunitions.ValueObjects;

namespace WinFormsApp4
{
    public partial class EditAmmunitionForm : Form
    {
        public event Action<Guid, Ammunition> AmmunitionUpdated;
        private readonly Ammunition _ammunition;

        public EditAmmunitionForm(Ammunition ammunition)
        {
            InitializeComponent();
            InitializeComboBoxes();

            _ammunition = ammunition;

            PopulateTextBoxesWithExistingAmmunition(ammunition);
        }

        private void PopulateTextBoxesWithExistingAmmunition(Ammunition ammunition)
        {
            ammoNameTextBox.Text = ammunition.Name.Value;
            ammoTypeComboBox.SelectedItem = ammunition.Type;
            caliberSizeTextBox.Text = ammunition.Caliber.Size.ToString();
            caliberUnitTextBox.Text = ammunition.Caliber.Unit.ToString();
            shootingRangeTextBox.Text = ammunition.ShootingRange.ValueInMeters.ToString();
            weightTextBox.Text = ammunition.Weight.Amount.ToString();
            unitOfWeightComboBox.SelectedItem = ammunition.Weight.Unit.ToString();
            originCountryTextBox.Text = ammunition.OriginCountry.Name.ToString();
            priceTextBox.Text = ammunition.Price.Amount.ToString();
            currencyComboBox.SelectedItem = ammunition.Price.Currency.ToString();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (ammoTypeComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select an ammunition type.");
                return;
            }

            try
            {
                string selectedType = ammoTypeComboBox.SelectedItem.ToString()!;

                Ammunition ammunition = EditAmmunition(selectedType);

                AmmunitionUpdated?.Invoke(_ammunition.Id, ammunition);
                Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Ammunition EditAmmunition(string type)
        {
            var name = new AmmunitionName(ammoNameTextBox.Text);

            var caliber = new Caliber(
                size: int.Parse(caliberSizeTextBox.Text),
                unit: caliberUnitTextBox.Text);

            var range = new ShootingRange(int.Parse(shootingRangeTextBox.Text));

            var weight = new Weight(
                amount: decimal.Parse(weightTextBox.Text),
                unit: Enum.Parse<UnitOfWeight>(unitOfWeightComboBox.Text));

            var originCountry = new OriginCountry(originCountryTextBox.Text);

            var price = new Price(
                amount: decimal.Parse(priceTextBox.Text),
                currency: Enum.Parse<Currency>(currencyComboBox.Text));

            var id = _ammunition.Id;

            return type switch
            {
                "Handgun" => new HandgunAmmunition(id, name, caliber, range, weight, originCountry, price),
                "Rifle" => new RifleAmmunition(id, name, caliber, range, weight, originCountry, price),
                "Shotgun" => new ShotgunAmmunition(id, name, caliber, range, weight, originCountry, price),
                "Grenade" => new GrenadeAmmunition(id, name, caliber, range, weight, originCountry, price),
                "Mine" => new MineAmmunition(id, name, caliber, range, weight, originCountry, price),
                _ => throw new ArgumentException("Unknown ammunition type")
            };
        }

        private void InitializeComboBoxes()
        {
            InitializeCurrencyComboBox();
            InitializeUnitOfWeightComboBox();
            InitializeAmmoTypeComboBox();
        }

        private void InitializeAmmoTypeComboBox()
        {
            ammoTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            PopulateAmmoTypeComboBox();
        }

        private void PopulateAmmoTypeComboBox()
        {
            List<string> ammunitionTypes = new() {
                "Handgun",
                "Rifle",
                "Shotgun",
                "Grenade",
                "Mine"
            };

            foreach (var type in ammunitionTypes)
            {
                ammoTypeComboBox.Items.Add(type.ToString());
            }
        }

        private void InitializeCurrencyComboBox()
        {
            currencyComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            PopulateCurrencyComboBox();
        }

        private void PopulateCurrencyComboBox()
        {
            var currencies = Enum.GetValues(typeof(Currency));

            foreach (var currency in currencies)
            {
                currencyComboBox.Items.Add(currency.ToString());
            }
        }

        private void InitializeUnitOfWeightComboBox()
        {
            unitOfWeightComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            PopulateUnitOfWeightComboBox();
        }

        private void PopulateUnitOfWeightComboBox()
        {
            var currencies = Enum.GetValues(typeof(UnitOfWeight));

            foreach (var currency in currencies)
            {
                unitOfWeightComboBox.Items.Add(currency.ToString());
            }
        }
    }
}
