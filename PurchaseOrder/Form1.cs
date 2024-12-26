using Core.Database;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PurchaseOrder
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        private SqlDatabaseManager _dbManager;
        private PO_Manager _poManager;
        public Form1()
        {
            InitializeComponent();
            string serverName = "DESKTOP-GQ4DC0S";
            string databaseName = "Order";
            string userName = "sa";
            string password = "6825";
            _dbManager = new SqlDatabaseManager(serverName, databaseName, userName, password);
            _poManager = new PO_Manager(_dbManager, "AdminUser");
        }

        private void btnLoadExelFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel Files|*.xls;*.xlsx";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtfilePath.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnShowData_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = txtfilePath.Text;
                if (string.IsNullOrEmpty(filePath))
                {
                    MessageBox.Show("Please select an Excel file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int month = Convert.ToInt32(txtMonth.Text);
                int year = Convert.ToInt32(txtYear.Text);
                int poType = Convert.ToInt32(txtPOType.Text);

                // Load data using PO_Manager
                var poDetails = _poManager.GetDetails(filePath, month, year, poType);

                // Bind data to the DataGridView
                gridControl.DataSource = poDetails;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            if (gridControl.DataSource is List<PO_Details> poDetailsList)
            {
                int savedRecords = _poManager.SavePOData(poDetailsList);
                MessageBox.Show($"{savedRecords} records have been saved successfully.", "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
