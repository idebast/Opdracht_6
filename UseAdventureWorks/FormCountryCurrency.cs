using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

using System.Data.SqlClient;
using System.Globalization;

namespace UseAdventureWorks
{
    public partial class FormCountryCurrency : Form
    {
        public FormCountryCurrency()
        {
            InitializeComponent();
        }

        private void countryRegionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.countryRegionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.adventureWorks2016CTP3DataSet);

        }

        private void countryRegionCurrencyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.countryRegionCurrencyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.adventureWorks2016CTP3DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'adventureWorks2016CTP3DataSet.Currency' table. You can move, or remove it, as needed.
            this.currencyTableAdapter.Fill(this.adventureWorks2016CTP3DataSet.Currency);
            // TODO: This line of code loads data into the 'adventureWorks2016CTP3DataSet.CountryRegion' table. You can move, or remove it, as needed.
            this.countryRegionTableAdapter.Fill(this.adventureWorks2016CTP3DataSet.CountryRegion);
            // TODO: This line of code loads data into the 'adventureWorks2016CTP3DataSet.CountryRegion' table. You can move, or remove it, as needed.
            this.countryRegionTableAdapter.Fill(this.adventureWorks2016CTP3DataSet.CountryRegion);
            // TODO: This line of code loads data into the 'adventureWorks2016CTP3DataSet.CountryRegionCurrency' table. You can move, or remove it, as needed.
            this.countryRegionCurrencyTableAdapter.Fill(this.adventureWorks2016CTP3DataSet.CountryRegionCurrency);

        }



        private void countryRegionDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var regionCode = countryRegionDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            Console.WriteLine(regionCode);

           // Lees veld uit de database
             SetConnectionString(@"Data Source=172.20.1.20;Initial Catalog=AdventureWorks2016CTP3;User ID=Student;Password=Student+2020");
             Read(regionCode);

        }
        private string connectionString;  // waarde in App.config

        public string GetConnectionString()
        {
            return connectionString;
        }

        public void SetConnectionString(string value)
        {
            connectionString = value;
        }

        private SqlConnection GetDbConnectie()
        {

            // Console.WriteLine(connectionString);

            return new SqlConnection(connectionString);
        }

        private void Read(string Id)
        {
            string readSqlText = "SELECT Naam FROM Aandelen WHERE AandeelId =\'"+@Id+"\'";
             //Console.WriteLine("SQL QUERY =" + readSqlText);

             SqlCommand readSql = new SqlCommand(readSqlText);
            readSql.Connection = GetDbConnectie();

            try
            {
                readSql.Connection.Open();

                // Volgende lijn faalt met 'Conversion failed when converting the varchar value ... to data type int'
                 // string value = readSql.ExecuteScalar().ToString();
                 // Console.WriteLine(value);


                // -> De string waarde van value zou nu moeten in het tekstveld komen.

             }
            catch (SqlException ex)
            {
                Console.WriteLine("Read mislukt" + ex.Message);
            }
            finally
            {
                if (readSql.Connection.State == ConnectionState.Open)
                {
                    readSql.Connection.Close();
                }
            }
        }

    }
}
