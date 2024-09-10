using WinFormsApp4.Ammunitions.ValueObjects;

namespace WinFormsApp4
{
    partial class AddAmmunitionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            addAmmoLabel = new Label();
            ammoNameLabel = new Label();
            ammoTypeLabel = new Label();
            caliberSizeLabel = new Label();
            caliberUnitLabel = new Label();
            shootingRangeLabel = new Label();
            weightLabel = new Label();
            unitOfWeightLabel = new Label();
            originCountryLabel = new Label();
            priceLabel = new Label();
            currencyLabel = new Label();
            ammoNameTextBox = new TextBox();
            caliberSizeTextBox = new TextBox();
            shootingRangeTextBox = new TextBox();
            weightTextBox = new TextBox();
            originCountryTextBox = new TextBox();
            priceTextBox = new TextBox();
            currencyComboBox = new ComboBox();
            unitOfWeightComboBox = new ComboBox();
            ammoTypeComboBox = new ComboBox();
            caliberUnitTextBox = new TextBox();
            createButton = new Button();
            SuspendLayout();
            // 
            // addAmmoLabel
            // 
            addAmmoLabel.AutoSize = true;
            addAmmoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addAmmoLabel.Location = new Point(51, 32);
            addAmmoLabel.Name = "addAmmoLabel";
            addAmmoLabel.Size = new Size(163, 28);
            addAmmoLabel.TabIndex = 0;
            addAmmoLabel.Text = "Add Ammunition";
            // 
            // ammoNameLabel
            // 
            ammoNameLabel.AutoSize = true;
            ammoNameLabel.Location = new Point(51, 90);
            ammoNameLabel.Name = "ammoNameLabel";
            ammoNameLabel.Size = new Size(135, 20);
            ammoNameLabel.TabIndex = 1;
            ammoNameLabel.Text = "Ammunition Name";
            // 
            // ammoTypeLabel
            // 
            ammoTypeLabel.AutoSize = true;
            ammoTypeLabel.Location = new Point(51, 136);
            ammoTypeLabel.Name = "ammoTypeLabel";
            ammoTypeLabel.Size = new Size(126, 20);
            ammoTypeLabel.TabIndex = 2;
            ammoTypeLabel.Text = "Ammunition Type";
            // 
            // caliberSizeLabel
            // 
            caliberSizeLabel.AutoSize = true;
            caliberSizeLabel.Location = new Point(51, 181);
            caliberSizeLabel.Name = "caliberSizeLabel";
            caliberSizeLabel.Size = new Size(87, 20);
            caliberSizeLabel.TabIndex = 3;
            caliberSizeLabel.Text = "Caliber Size";
            // 
            // caliberUnitLabel
            // 
            caliberUnitLabel.AutoSize = true;
            caliberUnitLabel.Location = new Point(51, 223);
            caliberUnitLabel.Name = "caliberUnitLabel";
            caliberUnitLabel.Size = new Size(87, 20);
            caliberUnitLabel.TabIndex = 4;
            caliberUnitLabel.Text = "Caliber Unit";
            // 
            // shootingRangeLabel
            // 
            shootingRangeLabel.AutoSize = true;
            shootingRangeLabel.Location = new Point(51, 266);
            shootingRangeLabel.Name = "shootingRangeLabel";
            shootingRangeLabel.Size = new Size(142, 20);
            shootingRangeLabel.TabIndex = 4;
            shootingRangeLabel.Text = "Shooting Range (m)";
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Location = new Point(51, 309);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new Size(56, 20);
            weightLabel.TabIndex = 5;
            weightLabel.Text = "Weight";
            // 
            // unitOfWeightLabel
            // 
            unitOfWeightLabel.AutoSize = true;
            unitOfWeightLabel.Location = new Point(51, 355);
            unitOfWeightLabel.Name = "unitOfWeightLabel";
            unitOfWeightLabel.Size = new Size(105, 20);
            unitOfWeightLabel.TabIndex = 6;
            unitOfWeightLabel.Text = "Unit of Weight";
            // 
            // originCountryLabel
            // 
            originCountryLabel.AutoSize = true;
            originCountryLabel.Location = new Point(51, 396);
            originCountryLabel.Name = "originCountryLabel";
            originCountryLabel.Size = new Size(105, 20);
            originCountryLabel.TabIndex = 7;
            originCountryLabel.Text = "Origin Country";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(51, 439);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(41, 20);
            priceLabel.TabIndex = 8;
            priceLabel.Text = "Price";
            // 
            // currencyLabel
            // 
            currencyLabel.AutoSize = true;
            currencyLabel.Location = new Point(51, 485);
            currencyLabel.Name = "currencyLabel";
            currencyLabel.Size = new Size(102, 20);
            currencyLabel.TabIndex = 9;
            currencyLabel.Text = "Price Currency";
            // 
            // ammoNameTextBox
            // 
            ammoNameTextBox.Location = new Point(259, 87);
            ammoNameTextBox.Name = "ammoNameTextBox";
            ammoNameTextBox.PlaceholderText = "Enter ammunition name..";
            ammoNameTextBox.Size = new Size(221, 27);
            ammoNameTextBox.TabIndex = 10;
            // 
            // caliberSizeTextBox
            // 
            caliberSizeTextBox.Location = new Point(259, 178);
            caliberSizeTextBox.Name = "caliberSizeTextBox";
            caliberSizeTextBox.PlaceholderText = "Enter caliber size..";
            caliberSizeTextBox.Size = new Size(221, 27);
            caliberSizeTextBox.TabIndex = 11;
            // 
            // shootingRangeTextBox
            // 
            shootingRangeTextBox.Location = new Point(259, 263);
            shootingRangeTextBox.Name = "shootingRangeTextBox";
            shootingRangeTextBox.PlaceholderText = "Enter shooting range in meters..";
            shootingRangeTextBox.Size = new Size(221, 27);
            shootingRangeTextBox.TabIndex = 12;
            // 
            // weightTextBox
            // 
            weightTextBox.Location = new Point(259, 306);
            weightTextBox.Name = "weightTextBox";
            weightTextBox.PlaceholderText = "Enter weight..";
            weightTextBox.Size = new Size(221, 27);
            weightTextBox.TabIndex = 13;
            // 
            // originCountryTextBox
            // 
            originCountryTextBox.Location = new Point(259, 393);
            originCountryTextBox.Name = "originCountryTextBox";
            originCountryTextBox.PlaceholderText = "Enter origin country..";
            originCountryTextBox.Size = new Size(221, 27);
            originCountryTextBox.TabIndex = 14;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(259, 436);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.PlaceholderText = "Enter price..";
            priceTextBox.Size = new Size(221, 27);
            priceTextBox.TabIndex = 15;
            // 
            // currencyComboBox
            // 
            currencyComboBox.FormattingEnabled = true;
            currencyComboBox.Location = new Point(259, 486);
            currencyComboBox.Name = "currencyComboBox";
            currencyComboBox.Size = new Size(221, 28);
            currencyComboBox.TabIndex = 16;
            // 
            // unitOfWeightComboBox
            // 
            unitOfWeightComboBox.FormattingEnabled = true;
            unitOfWeightComboBox.Location = new Point(259, 352);
            unitOfWeightComboBox.Name = "unitOfWeightComboBox";
            unitOfWeightComboBox.Size = new Size(221, 28);
            unitOfWeightComboBox.TabIndex = 17;
            // 
            // ammoTypeComboBox
            // 
            ammoTypeComboBox.FormattingEnabled = true;
            ammoTypeComboBox.Location = new Point(259, 133);
            ammoTypeComboBox.Name = "ammoTypeComboBox";
            ammoTypeComboBox.Size = new Size(221, 28);
            ammoTypeComboBox.TabIndex = 18;
            // 
            // caliberUnitTextBox
            // 
            caliberUnitTextBox.Location = new Point(259, 220);
            caliberUnitTextBox.Name = "caliberUnitTextBox";
            caliberUnitTextBox.PlaceholderText = "Enter caliber unit..";
            caliberUnitTextBox.Size = new Size(221, 27);
            caliberUnitTextBox.TabIndex = 19;
            // 
            // createButton
            // 
            createButton.Location = new Point(209, 537);
            createButton.Name = "createButton";
            createButton.Size = new Size(94, 29);
            createButton.TabIndex = 20;
            createButton.Text = "Create";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // AddAmmunitionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 591);
            Controls.Add(createButton);
            Controls.Add(caliberUnitTextBox);
            Controls.Add(ammoTypeComboBox);
            Controls.Add(unitOfWeightComboBox);
            Controls.Add(currencyComboBox);
            Controls.Add(priceTextBox);
            Controls.Add(originCountryTextBox);
            Controls.Add(weightTextBox);
            Controls.Add(shootingRangeTextBox);
            Controls.Add(caliberSizeTextBox);
            Controls.Add(ammoNameTextBox);
            Controls.Add(currencyLabel);
            Controls.Add(priceLabel);
            Controls.Add(originCountryLabel);
            Controls.Add(unitOfWeightLabel);
            Controls.Add(weightLabel);
            Controls.Add(shootingRangeLabel);
            Controls.Add(caliberUnitLabel);
            Controls.Add(caliberSizeLabel);
            Controls.Add(ammoTypeLabel);
            Controls.Add(ammoNameLabel);
            Controls.Add(addAmmoLabel);
            Name = "AddAmmunitionForm";
            Text = "AddAmmunitionForm";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label addAmmoLabel;
        private Label ammoNameLabel;
        private Label ammoTypeLabel;
        private Label caliberSizeLabel;
        private Label caliberUnitLabel;
        private Label shootingRangeLabel;
        private Label weightLabel;
        private Label unitOfWeightLabel;
        private Label originCountryLabel;
        private Label priceLabel;
        private Label currencyLabel;
        private TextBox ammoNameTextBox;
        private TextBox caliberSizeTextBox;
        private TextBox shootingRangeTextBox;
        private TextBox weightTextBox;
        private TextBox originCountryTextBox;
        private TextBox priceTextBox;
        private ComboBox currencyComboBox;
        private ComboBox unitOfWeightComboBox;
        private ComboBox ammoTypeComboBox;
        private TextBox caliberUnitTextBox;
        private Button createButton;
    }
}