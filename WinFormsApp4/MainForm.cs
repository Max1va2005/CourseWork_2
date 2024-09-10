using WinFormsApp4.Ammunitions.Abstractions;
using WinFormsApp4.Ammunitions.ValueObjects;
using WinFormsApp4.Repositories;

namespace WinFormsApp4
{
    public partial class MainForm : Form
    {
        private const int TableColumnCount = 9;

        private AmmunitionRepository _repository;

        public MainForm()
        {
            InitializeComponent();

            PopulateSearchByComboBox();
            InitializeTable();

            _repository = new();

            btnEdit.Enabled = false;
            btnDelete.Enabled = false;

            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void PopulateSearchByComboBox()
        {
            searchByComboBox.Items.AddRange(new object[] { "Name", "Purpose", "Origin Country" });
            searchByComboBox.SelectedItem = "Name";
        }

        private void InitializeTable()
        {
            dataGridView1.ColumnCount = TableColumnCount;
            dataGridView1.Columns[0].Name = "Id";
            dataGridView1.Columns[1].Name = "Name";
            dataGridView1.Columns[2].Name = "Type";
            dataGridView1.Columns[3].Name = "Purpose";
            dataGridView1.Columns[4].Name = "Caliber";
            dataGridView1.Columns[5].Name = "Shooting Range in meters";
            dataGridView1.Columns[6].Name = "Weight";
            dataGridView1.Columns[7].Name = "Origin Country";
            dataGridView1.Columns[8].Name = "Price";

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addAmmunitionForm = new AddAmmunitionForm();
            addAmmunitionForm.AmmunitionAdded += AddAmmunitionForm_AmmunitionAdded;
            addAmmunitionForm.Show();
        }

        private void AddAmmunitionForm_AmmunitionAdded(Ammunition ammunition)
        {
            _repository.Add(ammunition);

            UpdateTable();
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            btnEdit.Enabled = dataGridView1.SelectedRows.Count == 1;
            btnDelete.Enabled = dataGridView1.SelectedRows.Count == 1;
        }

        private void UpdateTable()
        {
            var ammunitions = _repository.GetAll();
            UpdateTable(ammunitions);
        }

        private void UpdateTable(List<Ammunition> ammunitions)
        {
            dataGridView1.Rows.Clear();

            foreach (var ammunition in ammunitions)
            {
                dataGridView1.Rows.Add(
                    ammunition.Id.ToString(),
                    ammunition.Name.Value.ToString(),
                    ammunition.Type,
                    ammunition.Purpose.ToString(),
                    ammunition.Caliber.ToString(),
                    ammunition.ShootingRange.ValueInMeters,
                    ammunition.Weight.ToString(),
                    ammunition.OriginCountry.Name.ToString(),
                    ammunition.Price.ToString()
                );
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete the selected item?",
                                     "Confirm Deletion",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Warning);

            // If the user clicks "Yes", proceed with deletion
            if (result == DialogResult.Yes)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var id = Guid.Parse(selectedRow.Cells["Id"].Value.ToString());

                // Delete the item from the repository
                _repository.Delete(id);

                // Update the table after deletion
                UpdateTable();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridView1.SelectedRows[0];

            var id = Guid.Parse(selectedRow.Cells["Id"].Value.ToString());

            var ammunition = _repository.GetById(id);

            var editAmmunitionForm = new EditAmmunitionForm(ammunition);

            editAmmunitionForm.AmmunitionUpdated += EditAmmunitionForm_AmmunitionUpdated;
            editAmmunitionForm.Show();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchTextBox.Text))
            {
                MessageBox.Show("Search value cannot be empty.",
                                     "Error",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);

                return;
            }


            var searchQuery = searchTextBox.Text.Trim();
            var selectedCategory = searchByComboBox.SelectedItem.ToString();

            List<Ammunition> searchResults = new List<Ammunition>();

            switch (selectedCategory)
            {
                case "Name":
                    searchResults = _repository.SearchByName(searchQuery);
                    break;

                case "Purpose":
                    if (Enum.TryParse<AmmunitionPurpose>(searchQuery, out var purpose))
                    {
                        searchResults = _repository.SearchByPurpose(purpose);
                    }
                    else
                    {
                        MessageBox.Show("No such purpose exists.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }

                    break;

                case "Origin Country":
                    searchResults = _repository.SearchByOriginCountry(searchQuery);
                    break;
            }

            UpdateTable(searchResults);
        }

        private void clearSearchResultsButton_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            _repository.Clear();

            UpdateTable();
        }

        private void EditAmmunitionForm_AmmunitionUpdated(Guid id, Ammunition ammunition)
        {
            _repository.Update(
                ammunitionId: id,
                ammunition);
            
            UpdateTable();
        }
    }
}