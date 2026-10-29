using System;
using System.Data;
using System.Windows.Forms;

namespace UI
{
    public partial class BillingPaymentUserControl : UserControl
    {
        public BillingPaymentUserControl()
        {
            InitializeComponent();
            SetupSampleData();
        }

        private void SetupSampleData()
        {
            // Plain DataTable binding for layout display purposes only (Itemized Charges List)
            DataTable dtCharges = new DataTable();
            dtCharges.Columns.Add("Description", typeof(string));
            dtCharges.Columns.Add("Category", typeof(string));
            dtCharges.Columns.Add("Amount", typeof(decimal));
            dtCharges.Columns.Add("Payment Status", typeof(string));

            dtCharges.Rows.Add("Deluxe Suite Stay (4 Nights)", "Accommodation", 600.00m, "Paid");
            dtCharges.Rows.Add("Room Service - Dinner", "F&B", 85.00m, "Paid");
            dtCharges.Rows.Add("Spa & Wellness Package", "Amenities", 150.00m, "Pending");
            dtCharges.Rows.Add("Airport Transfer (VIP)", "Transport", 75.00m, "Pending");

            dgvItemizedCharges.DataSource = dtCharges;
            dgvItemizedCharges.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}