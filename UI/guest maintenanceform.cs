using BusinessLogic.Controller;
using Microsoft.Data.SqlClient;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace UI
{
    public partial class guest_maintenanceform : UserControl
    {
        public guest_maintenanceform()
        {
            InitializeComponent();
        }

        private void guest_maintenanceform_Load(object sender, EventArgs e)
        {
            SetupComboBoxes();
            LoadGuestData();
        }
        private void SetupComboBoxes()
        {
            cmbRoomType.Items.Clear();
            cmbRoomType.Items.AddRange(new string[] { "Single", "Double", "Deluxe", "Suite", "Executive Suite" });
            cmbRoomType.SelectedIndex = 0;

            cmbStatus.Items.Clear();
            cmbStatus.Items.AddRange(new string[] { "Active", "Inactive", "Checked In", "Checked Out", "Reserved" });
            cmbStatus.SelectedIndex = 0;
        }
        private void LoadGuestData()
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void ClearFields()
        {
            txtGuestID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            if (cmbRoomType.Items.Count > 0) cmbRoomType.SelectedIndex = 0;
            if (cmbStatus.Items.Count > 0) cmbStatus.SelectedIndex = 0;
            dgvGuests.ClearSelection();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PerformSearch();
        }
        private void PerformSearch()
        {
        }

        private void dgvGuests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

    }
}
