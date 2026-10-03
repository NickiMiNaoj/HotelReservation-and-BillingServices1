using BusinessLogic.Controller;
using Microsoft.Data.SqlClient;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace UI
{
    public partial class guest_maintenanceform : Form
    {
        private readonly GuestController _guestController;
        public guest_maintenanceform()
        {
            InitializeComponent();
            _guestController = new GuestController();
            this.Load += guest_maintenanceform_Load;
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
            List<GuestModel> guests = _guestController.GetGuests();

            dgvGuests.AutoGenerateColumns = true;
            dgvGuests.DataSource = null;
            dgvGuests.DataSource = guests;
            dgvGuests.Refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            GuestModel newGuest = new GuestModel
            {
                FirstName = txtFirstName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                RoomType = cmbRoomType.SelectedItem?.ToString(),
                Status = cmbStatus.SelectedItem?.ToString()
            };

            if (_guestController.CreateGuest(newGuest))
            {
                MessageBox.Show("Guest added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGuestData();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Failed to add guest. Check input details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGuestID.Text))
            {
                MessageBox.Show("Please select a guest from the grid to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs()) return;

            GuestModel updatedGuest = new GuestModel
            {
                GuestID = Convert.ToInt32(txtGuestID.Text),
                FirstName = txtFirstName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                RoomType = cmbRoomType.SelectedItem?.ToString(),
                Status = cmbStatus.SelectedItem?.ToString()
            };

            if (_guestController.UpdateGuest(updatedGuest))
            {
                MessageBox.Show("Guest updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGuestData();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Failed to update guest.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGuestID.Text))
            {
                MessageBox.Show("Please select a guest from the grid to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int guestId = Convert.ToInt32(txtGuestID.Text);

            DialogResult result = MessageBox.Show($"Are you sure you want to delete Guest ID {guestId}?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (_guestController.RemoveGuest(guestId))
                {
                    MessageBox.Show("Guest deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadGuestData();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Failed to delete guest.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("First Name and Last Name are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
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
            string keyword = txtSearch.Text;

            List<GuestModel> searchResults = _guestController.SearchGuests(keyword);

            dgvGuests.DataSource = null;
            dgvGuests.DataSource = searchResults;

            if (dgvGuests.Columns["GuestID"] != null)
                dgvGuests.Columns["GuestID"].HeaderText = "Guest ID";
        }

        private void dgvGuests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvGuests.Rows[e.RowIndex].DataBoundItem is GuestModel guest)
            {
                txtGuestID.Text = guest.GuestID.ToString();
                txtFirstName.Text = guest.FirstName;
                txtLastName.Text = guest.LastName;
                txtEmail.Text = guest.Email;
                txtPhone.Text = guest.Phone;
                cmbRoomType.SelectedItem = guest.RoomType;
                cmbStatus.SelectedItem = guest.Status;
            }
        }
    }
}
