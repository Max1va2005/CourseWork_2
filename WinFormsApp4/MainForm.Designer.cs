
namespace WinFormsApp4
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            searchButton = new Button();
            searchTextBox = new TextBox();
            searchByComboBox = new ComboBox();
            clearAllButton = new Button();
            clearSearchResultsButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(73, 75);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.Size = new Size(1268, 836);
            dataGridView1.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1384, 309);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(353, 49);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1384, 383);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(353, 47);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(1384, 462);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(353, 46);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(1475, 162);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(163, 37);
            searchButton.TabIndex = 4;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(1384, 118);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PlaceholderText = "Search..";
            searchTextBox.Size = new Size(163, 27);
            searchTextBox.TabIndex = 5;
            // 
            // searchByComboBox
            // 
            searchByComboBox.FormattingEnabled = true;
            searchByComboBox.Location = new Point(1570, 118);
            searchByComboBox.Name = "searchByComboBox";
            searchByComboBox.Size = new Size(167, 28);
            searchByComboBox.TabIndex = 6;
            // 
            // clearAllButton
            // 
            clearAllButton.Location = new Point(1384, 542);
            clearAllButton.Name = "clearAllButton";
            clearAllButton.Size = new Size(353, 48);
            clearAllButton.TabIndex = 7;
            clearAllButton.Text = "Clear All";
            clearAllButton.UseVisualStyleBackColor = true;
            clearAllButton.Click += clearAllButton_Click;
            // 
            // clearSearchResultsButton
            // 
            clearSearchResultsButton.Location = new Point(1475, 210);
            clearSearchResultsButton.Name = "clearSearchResultsButton";
            clearSearchResultsButton.Size = new Size(167, 37);
            clearSearchResultsButton.TabIndex = 8;
            clearSearchResultsButton.Text = "Clear Search Results";
            clearSearchResultsButton.UseVisualStyleBackColor = true;
            clearSearchResultsButton.Click += clearSearchResultsButton_Click;
            // 
            // MainForm
            // 
            ClientSize = new Size(1769, 1055);
            Controls.Add(clearSearchResultsButton);
            Controls.Add(clearAllButton);
            Controls.Add(searchByComboBox);
            Controls.Add(searchTextBox);
            Controls.Add(searchButton);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Name = "MainForm";
            Text = "Ammunition Accounting";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private Button searchButton;
        private Button clearAllButton;
        private TextBox searchTextBox;
        private ComboBox searchByComboBox;
        private Button clearSearchResultsButton;
    }
}
