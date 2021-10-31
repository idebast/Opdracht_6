namespace UseAdventureWorks
{
    partial class FormCountryCurrency
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nameLabel;
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.countryRegionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryRegionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adventureWorks2016CTP3DataSet = new UseAdventureWorks.AdventureWorks2016CTP3DataSet();
            this.currencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countryRegionCurrencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countryRegionCurrencyTableAdapter = new UseAdventureWorks.AdventureWorks2016CTP3DataSetTableAdapters.CountryRegionCurrencyTableAdapter();
            this.tableAdapterManager = new UseAdventureWorks.AdventureWorks2016CTP3DataSetTableAdapters.TableAdapterManager();
            this.countryRegionTableAdapter = new UseAdventureWorks.AdventureWorks2016CTP3DataSetTableAdapters.CountryRegionTableAdapter();
            this.currencyTableAdapter = new UseAdventureWorks.AdventureWorks2016CTP3DataSetTableAdapters.CurrencyTableAdapter();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.countryRegionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryRegionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorks2016CTP3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryRegionCurrencyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(539, 85);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.currencyBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(583, 82);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // countryRegionDataGridView
            // 
            this.countryRegionDataGridView.AutoGenerateColumns = false;
            this.countryRegionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.countryRegionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.countryRegionDataGridView.DataSource = this.countryRegionBindingSource;
            this.countryRegionDataGridView.Location = new System.Drawing.Point(38, 37);
            this.countryRegionDataGridView.Name = "countryRegionDataGridView";
            this.countryRegionDataGridView.Size = new System.Drawing.Size(453, 409);
            this.countryRegionDataGridView.TabIndex = 2;
            this.countryRegionDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.countryRegionDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CountryRegionCode";
            this.dataGridViewTextBoxColumn1.HeaderText = "CountryRegionCode";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 127;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 60;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ModifiedDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "ModifiedDate";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // countryRegionBindingSource
            // 
            this.countryRegionBindingSource.DataMember = "CountryRegion";
            this.countryRegionBindingSource.DataSource = this.adventureWorks2016CTP3DataSet;
            // 
            // adventureWorks2016CTP3DataSet
            // 
            this.adventureWorks2016CTP3DataSet.DataSetName = "AdventureWorks2016CTP3DataSet";
            this.adventureWorks2016CTP3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // currencyBindingSource
            // 
            this.currencyBindingSource.DataMember = "Currency";
            this.currencyBindingSource.DataSource = this.adventureWorks2016CTP3DataSet;
            // 
            // countryRegionCurrencyBindingSource
            // 
            this.countryRegionCurrencyBindingSource.DataMember = "CountryRegionCurrency";
            this.countryRegionCurrencyBindingSource.DataSource = this.adventureWorks2016CTP3DataSet;
            // 
            // countryRegionCurrencyTableAdapter
            // 
            this.countryRegionCurrencyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CountryRegionCurrencyTableAdapter = this.countryRegionCurrencyTableAdapter;
            this.tableAdapterManager.CountryRegionTableAdapter = this.countryRegionTableAdapter;
            this.tableAdapterManager.CurrencyTableAdapter = this.currencyTableAdapter;
            this.tableAdapterManager.UpdateOrder = UseAdventureWorks.AdventureWorks2016CTP3DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // countryRegionTableAdapter
            // 
            this.countryRegionTableAdapter.ClearBeforeFill = true;
            // 
            // currencyTableAdapter
            // 
            this.currencyTableAdapter.ClearBeforeFill = true;
            // 
            // FormCountryCurrency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.countryRegionDataGridView);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Name = "FormCountryCurrency";
            this.Text = "CountryCurrency";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countryRegionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryRegionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorks2016CTP3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryRegionCurrencyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AdventureWorks2016CTP3DataSet adventureWorks2016CTP3DataSet;
        private System.Windows.Forms.BindingSource countryRegionCurrencyBindingSource;
        private AdventureWorks2016CTP3DataSetTableAdapters.CountryRegionCurrencyTableAdapter countryRegionCurrencyTableAdapter;
        private AdventureWorks2016CTP3DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private AdventureWorks2016CTP3DataSetTableAdapters.CountryRegionTableAdapter countryRegionTableAdapter;
        private System.Windows.Forms.BindingSource countryRegionBindingSource;
        private AdventureWorks2016CTP3DataSetTableAdapters.CurrencyTableAdapter currencyTableAdapter;
        private System.Windows.Forms.BindingSource currencyBindingSource;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.DataGridView countryRegionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}

