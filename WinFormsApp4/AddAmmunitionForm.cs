using WinFormsApp4.Ammunitions;
using WinFormsApp4.Ammunitions.Abstractions;
using WinFormsApp4.Ammunitions.ValueObjects;

namespace WinFormsApp4
{
    public partial class AddAmmunitionForm : Form
    {
        public event Action<Ammunition> AmmunitionAdded;

        public AddAmmunitionForm()
        {
            InitializeComponent();
            InitializeComboBoxes();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (ammoTypeComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select an ammunition type.");
                return;
            }

            try
            {
                string selectedType = ammoTypeComboBox.SelectedItem.ToString();

                Ammunition ammunition = CreateAmmunition(selectedType);

                AmmunitionAdded?.Invoke(ammunition);
                Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Ammunition CreateAmmunition(string type)
        {
            var name = new AmmunitionName(ammoNameTextBox.Text);

            var caliber = new Caliber(
                size: double.Parse(caliberSizeTextBox.Text),
                unit: caliberUnitTextBox.Text);

            var range = new ShootingRange(int.Parse(shootingRangeTextBox.Text));

            var weight = new Weight(
                amount: decimal.Parse(weightTextBox.Text),
                unit: Enum.Parse<UnitOfWeight>(unitOfWeightComboBox.Text));

            var originCountry = new OriginCountry(originCountryTextBox.Text);

            var price = new Price(
                amount: decimal.Parse(priceTextBox.Text),
                currency: Enum.Parse<Currency>(currencyComboBox.Text));

            var id = Guid.NewGuid();

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
            ammoTypeComboBox.SelectedItem = "Handgun";
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
            currencyComboBox.SelectedItem = Currency.USD.ToString();
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
            unitOfWeightComboBox.SelectedItem = UnitOfWeight.Kilogram.ToString();
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
