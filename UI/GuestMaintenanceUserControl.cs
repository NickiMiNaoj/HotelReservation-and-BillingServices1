
using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace UI
{
    public partial class GuestMaintenanceUserControl : UserControl
    {
        private readonly string connectionString = @"Server=.\SQLEXPRESS09;Database=HotelReservationDB;Trusted_Connection=True;TrustServerCertificate=True;";

        private int selectedGuestID = 0;

        public GuestMaintenanceUserControl()
        {
            InitializeComponent();

            this.Load += GuestMaintenanceUserControl_Load;

            btnSave.Click += btnSave_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnClear.Click += btnClear_Click;

            dgvGuestList.CellClick += dgvGuestList_CellClick;
        }

        // LOAD FORM
        private void GuestMaintenanceUserControl_Load(object sender, EventArgs e)
        {
            LoadNationality();
            LoadIDTypes();
            LoadGuestList();
            ClearFields();
        }

        // NATIONALITY COMBOBOX
        private void LoadNationality()
        {
            cboNationality.Items.Clear();

            cboNationality.Items.AddRange(new string[]
            {
                "Filipino",
                "American",
                "British",
                "Chinese",
                "Japanese",
                "Korean",
                "Australian",
                "Canadian",
                "Other"
            });
        }

        // ID TYPE COMBOBOX
        private void LoadIDTypes()
        {
            cboIDType.Items.Clear();

            cboIDType.Items.AddRange(new string[]
            {
                "Passport",
                "Driver's License",
                "National ID",
                "SSS ID",
                "PhilHealth ID",
                "Postal ID",
                "Voter's ID",
                "Other"
            });
        }

        // LOAD GUEST LIST
        private void LoadGuestList()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM dbo.tblGuests";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvGuestList.DataSource = dt;
                }
            }
        }

        // SAVE
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
                return;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
            INSERT INTO dbo.tblGuests
            (FirstName, LastName, ContactNumber, EmailAddress,
             Nationality, IDType, IDNumber, Address, GuestPreferences)
            VALUES
            (@FirstName, @LastName, @ContactNumber, @EmailAddress,
             @Nationality, @IDType, @IDNumber, @Address, @GuestPreferences);

            SELECT CAST(SCOPE_IDENTITY() AS INT);";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                    cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
                    cmd.Parameters.AddWithValue("@ContactNumber", txtContactNumber.Text.Trim());
                    cmd.Parameters.AddWithValue("@EmailAddress",
                        string.IsNullOrWhiteSpace(txtEmailAddress.Text)
                            ? DBNull.Value : txtEmailAddress.Text.Trim());
                    cmd.Parameters.AddWithValue("@Nationality",
                        string.IsNullOrWhiteSpace(cboNationality.Text)
                            ? DBNull.Value : cboNationality.Text);
                    cmd.Parameters.AddWithValue("@IDType",
                        string.IsNullOrWhiteSpace(cboIDType.Text)
                            ? DBNull.Value : cboIDType.Text);
                    cmd.Parameters.AddWithValue("@IDNumber",
                        string.IsNullOrWhiteSpace(txtIDNumber.Text)
                            ? DBNull.Value : txtIDNumber.Text.Trim());
                    cmd.Parameters.AddWithValue("@Address",
                        string.IsNullOrWhiteSpace(txtAddress.Text)
                            ? DBNull.Value : txtAddress.Text.Trim());
                    cmd.Parameters.AddWithValue("@GuestPreferences",
                        string.IsNullOrWhiteSpace(rtbGuestPreferences.Text)
                            ? DBNull.Value : rtbGuestPreferences.Text.Trim());

                    con.Open();

                    int newGuestID = Convert.ToInt32(cmd.ExecuteScalar());

                    txtGuestID.Text = newGuestID.ToString();

                    MessageBox.Show(
                        "Guest added successfully!\nGuest ID: " + newGuestID,
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }

            LoadGuestList();
            ClearFields();
        }

        // UPDATE
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedGuestID == 0)
            {
                MessageBox.Show("Please select a guest to update.");
                return;
            }

            if (!ValidateFields()) return;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"UPDATE dbo.tblGuests SET
                                FirstName = @FirstName,
                                LastName = @LastName,
                                ContactNumber = @ContactNumber,
                                EmailAddress = @EmailAddress,
                                Nationality = @Nationality,
                                IDType = @IDType,
                                IDNumber = @IDNumber,
                                Address = @Address,
                                GuestPreferences = @GuestPreferences
                                WHERE GuestID = @GuestID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    AddParameters(cmd);
                    cmd.Parameters.AddWithValue("@GuestID", selectedGuestID);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Guest updated successfully!");

            LoadGuestList();
            ClearFields();
        }

        // DELETE
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedGuestID == 0)
            {
                MessageBox.Show("Please select a guest first.",
                    "No Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to set this guest as inactive?",
                "Confirm Deactivation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
            UPDATE dbo.tblGuests
            SET IsActive = 0
            WHERE GuestID = @GuestID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@GuestID", selectedGuestID);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Guest has been set to inactive successfully!",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            LoadGuestList();
            ClearFields();
        }

        // CLEAR
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            selectedGuestID = 0;

            txtGuestID.Text = "Auto-generated";
            txtFirstName.Clear();
            txtLastName.Clear();
            txtContactNumber.Clear();
            txtEmailAddress.Clear();
            txtIDNumber.Clear();
            txtAddress.Clear();
            rtbGuestPreferences.Clear();

            cboNationality.SelectedIndex = -1;
            cboIDType.SelectedIndex = -1;

            dgvGuestList.ClearSelection();
        }

        // SELECT GUEST FROM DATAGRIDVIEW
        private void dgvGuestList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvGuestList.Rows[e.RowIndex];

            selectedGuestID = Convert.ToInt32(row.Cells["GuestID"].Value);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM dbo.tblGuests WHERE GuestID = @GuestID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@GuestID", selectedGuestID);

                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtGuestID.Text = reader["GuestID"].ToString();
                            txtFirstName.Text = reader["FirstName"].ToString();
                            txtLastName.Text = reader["LastName"].ToString();
                            txtContactNumber.Text = reader["ContactNumber"].ToString();
                            txtEmailAddress.Text = reader["EmailAddress"].ToString();
                            cboNationality.Text = reader["Nationality"].ToString();
                            cboIDType.Text = reader["IDType"].ToString();
                            txtIDNumber.Text = reader["IDNumber"].ToString();
                            txtAddress.Text = reader["Address"].ToString();
                            rtbGuestPreferences.Text = reader["GuestPreferences"].ToString();
                        }
                    }
                }
            }
        }

        // VALIDATION
        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtContactNumber.Text) ||
                string.IsNullOrWhiteSpace(txtEmailAddress.Text) ||
                string.IsNullOrWhiteSpace(txtIDNumber.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text) ||
                cboNationality.SelectedIndex == -1 ||
                cboIDType.SelectedIndex == -1)
            {
                MessageBox.Show("Please complete all required fields.",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(
                txtEmailAddress.Text,
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Please enter a valid email address.");
                txtEmailAddress.Focus();
                return false;
            }

            return true;
        }

        // SQL PARAMETERS
        private void AddParameters(SqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
            cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
            cmd.Parameters.AddWithValue("@ContactNumber", txtContactNumber.Text.Trim());
            cmd.Parameters.AddWithValue("@EmailAddress", txtEmailAddress.Text.Trim());
            cmd.Parameters.AddWithValue("@Nationality", cboNationality.Text);
            cmd.Parameters.AddWithValue("@IDType", cboIDType.Text);
            cmd.Parameters.AddWithValue("@IDNumber", txtIDNumber.Text.Trim());
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
            cmd.Parameters.AddWithValue("@GuestPreferences", rtbGuestPreferences.Text.Trim());
        }
    }
}
