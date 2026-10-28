namespace UI
{
    partial class AvailabilityViewUserControl
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panelFilterBar = new Panel();
            lblCheckIn = new Label();
            dtpCheckIn = new DateTimePicker();
            lblCheckOut = new Label();
            dtpCheckOut = new DateTimePicker();
            lblRoomType = new Label();
            cmbRoomType = new ComboBox();
            lblMinPrice = new Label();
            numMinPrice = new NumericUpDown();
            lblMaxPrice = new Label();
            numMaxPrice = new NumericUpDown();
            btnSearch = new Button();
            lblStatus = new Label();
            dgvAvailableRooms = new DataGridView();
            btnViewDetails = new Button();
            btnBookSelected = new Button();
            panelFilterBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMinPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMaxPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAvailableRooms).BeginInit();
            SuspendLayout();
            // 
            // panelFilterBar
            // 
            panelFilterBar.BackColor = Color.SteelBlue;
            panelFilterBar.Controls.Add(lblCheckIn);
            panelFilterBar.Controls.Add(dtpCheckIn);
            panelFilterBar.Controls.Add(lblCheckOut);
            panelFilterBar.Controls.Add(dtpCheckOut);
            panelFilterBar.Controls.Add(lblRoomType);
            panelFilterBar.Controls.Add(cmbRoomType);
            panelFilterBar.Controls.Add(lblMinPrice);
            panelFilterBar.Controls.Add(numMinPrice);
            panelFilterBar.Controls.Add(lblMaxPrice);
            panelFilterBar.Controls.Add(numMaxPrice);
            panelFilterBar.Controls.Add(btnSearch);
            panelFilterBar.Location = new Point(18, 19);
            panelFilterBar.Name = "panelFilterBar";
            panelFilterBar.Size = new Size(1410, 107);
            panelFilterBar.TabIndex = 0;
            // 
            // lblCheckIn
            // 
            lblCheckIn.AutoSize = true;
            lblCheckIn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblCheckIn.ForeColor = Color.White;
            lblCheckIn.Location = new Point(33, 19);
            lblCheckIn.Name = "lblCheckIn";
            lblCheckIn.Size = new Size(88, 25);
            lblCheckIn.TabIndex = 0;
            lblCheckIn.Text = "Check-In";
            // 
            // dtpCheckIn
            // 
            dtpCheckIn.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpCheckIn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            dtpCheckIn.Format = DateTimePickerFormat.Custom;
            dtpCheckIn.Location = new Point(33, 52);
            dtpCheckIn.Name = "dtpCheckIn";
            dtpCheckIn.Size = new Size(221, 33);
            dtpCheckIn.TabIndex = 1;
            // 
            // lblCheckOut
            // 
            lblCheckOut.AutoSize = true;
            lblCheckOut.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblCheckOut.ForeColor = Color.White;
            lblCheckOut.Location = new Point(320, 19);
            lblCheckOut.Name = "lblCheckOut";
            lblCheckOut.Size = new Size(103, 25);
            lblCheckOut.TabIndex = 2;
            lblCheckOut.Text = "Check-Out";
            // 
            // dtpCheckOut
            // 
            dtpCheckOut.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpCheckOut.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            dtpCheckOut.Format = DateTimePickerFormat.Custom;
            dtpCheckOut.Location = new Point(320, 52);
            dtpCheckOut.Name = "dtpCheckOut";
            dtpCheckOut.Size = new Size(220, 33);
            dtpCheckOut.TabIndex = 3;
            // 
            // lblRoomType
            // 
            lblRoomType.AutoSize = true;
            lblRoomType.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblRoomType.ForeColor = Color.White;
            lblRoomType.Location = new Point(632, 19);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(107, 25);
            lblRoomType.TabIndex = 4;
            lblRoomType.Text = "Room Type";
            // 
            // cmbRoomType
            // 
            cmbRoomType.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            cmbRoomType.FormattingEnabled = true;
            cmbRoomType.Items.AddRange(new object[] { "All Types", "Standard", "Deluxe", "Junior Suite", "Executive Suite", "Presidential Suite" });
            cmbRoomType.Location = new Point(632, 52);
            cmbRoomType.Name = "cmbRoomType";
            cmbRoomType.Size = new Size(242, 33);
            cmbRoomType.TabIndex = 5;
            cmbRoomType.Text = "All Types";
            // 
            // lblMinPrice
            // 
            lblMinPrice.AutoSize = true;
            lblMinPrice.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblMinPrice.ForeColor = Color.White;
            lblMinPrice.Location = new Point(940, 19);
            lblMinPrice.Name = "lblMinPrice";
            lblMinPrice.Size = new Size(93, 25);
            lblMinPrice.TabIndex = 6;
            lblMinPrice.Text = "Min Price";
            // 
            // numMinPrice
            // 
            numMinPrice.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            numMinPrice.Location = new Point(940, 47);
            numMinPrice.Name = "numMinPrice";
            numMinPrice.Size = new Size(98, 33);
            numMinPrice.TabIndex = 7;
            numMinPrice.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // lblMaxPrice
            // 
            lblMaxPrice.AutoSize = true;
            lblMaxPrice.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblMaxPrice.ForeColor = Color.White;
            lblMaxPrice.Location = new Point(1073, 19);
            lblMaxPrice.Name = "lblMaxPrice";
            lblMaxPrice.Size = new Size(97, 25);
            lblMaxPrice.TabIndex = 8;
            lblMaxPrice.Text = "Max Price";
            // 
            // numMaxPrice
            // 
            numMaxPrice.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            numMaxPrice.Location = new Point(1073, 47);
            numMaxPrice.Name = "numMaxPrice";
            numMaxPrice.Size = new Size(109, 33);
            numMaxPrice.TabIndex = 9;
            numMaxPrice.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(197, 160, 89);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            btnSearch.ForeColor = Color.Black;
            btnSearch.Location = new Point(1273, 27);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(114, 50);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(18, 146);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(273, 25);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Availability View Status: Ready";
            // 
            // dgvAvailableRooms
            // 
            dgvAvailableRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAvailableRooms.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvAvailableRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAvailableRooms.Location = new Point(18, 183);
            dgvAvailableRooms.Name = "dgvAvailableRooms";
            dgvAvailableRooms.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvAvailableRooms.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvAvailableRooms.RowTemplate.Height = 24;
            dgvAvailableRooms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAvailableRooms.Size = new Size(1410, 684);
            dgvAvailableRooms.TabIndex = 2;
            // 
            // btnViewDetails
            // 
            btnViewDetails.BackColor = Color.FromArgb(197, 160, 89);
            btnViewDetails.FlatStyle = FlatStyle.Flat;
            btnViewDetails.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            btnViewDetails.Location = new Point(924, 883);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.Size = new Size(246, 54);
            btnViewDetails.TabIndex = 1;
            btnViewDetails.Text = "View Room Details";
            btnViewDetails.UseVisualStyleBackColor = false;
            // 
            // btnBookSelected
            // 
            btnBookSelected.BackColor = Color.FromArgb(46, 139, 87);
            btnBookSelected.FlatStyle = FlatStyle.Flat;
            btnBookSelected.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            btnBookSelected.ForeColor = Color.White;
            btnBookSelected.Location = new Point(1186, 883);
            btnBookSelected.Name = "btnBookSelected";
            btnBookSelected.Size = new Size(241, 54);
            btnBookSelected.TabIndex = 0;
            btnBookSelected.Text = "Book Selected Room";
            btnBookSelected.UseVisualStyleBackColor = false;
            // 
            // AvailabilityViewUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            Controls.Add(btnBookSelected);
            Controls.Add(btnViewDetails);
            Controls.Add(dgvAvailableRooms);
            Controls.Add(lblStatus);
            Controls.Add(panelFilterBar);
            Name = "AvailabilityViewUserControl";
            Size = new Size(1447, 965);
            panelFilterBar.ResumeLayout(false);
            panelFilterBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMinPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMaxPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAvailableRooms).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Panel panelFilterBar;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.ComboBox cmbRoomType;
        private System.Windows.Forms.Label lblMinPrice;
        private System.Windows.Forms.NumericUpDown numMinPrice;
        private System.Windows.Forms.Label lblMaxPrice;
        private System.Windows.Forms.NumericUpDown numMaxPrice;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DataGridView dgvAvailableRooms;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.Button btnBookSelected;
    }
}