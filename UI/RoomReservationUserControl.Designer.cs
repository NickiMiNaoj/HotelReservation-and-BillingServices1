namespace UI
{
    partial class RoomReservationUserControl
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panelFormCard = new Panel();
            lblFormTitle = new Label();
            lblResId = new Label();
            txtResId = new TextBox();
            lblGuest = new Label();
            cmbGuest = new ComboBox();
            btnAddGuest = new Button();
            lblRoomNo = new Label();
            cmbRoomNo = new ComboBox();
            lblRoomTypeVal = new Label();
            lblArrival = new Label();
            dtpArrival = new DateTimePicker();
            lblDeparture = new Label();
            dtpDeparture = new DateTimePicker();
            lblAdults = new Label();
            numAdults = new NumericUpDown();
            lblChildren = new Label();
            numChildren = new NumericUpDown();
            lblSpecialReq = new Label();
            txtSpecialReq = new RichTextBox();
            lblRatePerNight = new Label();
            txtRatePerNight = new TextBox();
            lblTotalNights = new Label();
            txtTotalNights = new TextBox();
            lblAddCharges = new Label();
            numAddCharges = new NumericUpDown();
            lblDiscount = new Label();
            numDiscount = new NumericUpDown();
            lblTotalAmount = new Label();
            txtTotalAmount = new TextBox();
            btnSave = new Button();
            btnUpdate = new Button();
            btnCancel = new Button();
            btnPrint = new Button();
            btnClear = new Button();
            lblGridTitle = new Label();
            dgvReservations = new DataGridView();
            panelFormCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numAdults).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numChildren).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAddCharges).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDiscount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvReservations).BeginInit();
            SuspendLayout();
            // 
            // panelFormCard
            // 
            panelFormCard.BackColor = Color.SteelBlue;
            panelFormCard.Controls.Add(lblFormTitle);
            panelFormCard.Controls.Add(lblResId);
            panelFormCard.Controls.Add(txtResId);
            panelFormCard.Controls.Add(lblGuest);
            panelFormCard.Controls.Add(cmbGuest);
            panelFormCard.Controls.Add(btnAddGuest);
            panelFormCard.Controls.Add(lblRoomNo);
            panelFormCard.Controls.Add(cmbRoomNo);
            panelFormCard.Controls.Add(lblRoomTypeVal);
            panelFormCard.Controls.Add(lblArrival);
            panelFormCard.Controls.Add(dtpArrival);
            panelFormCard.Controls.Add(lblDeparture);
            panelFormCard.Controls.Add(dtpDeparture);
            panelFormCard.Controls.Add(lblAdults);
            panelFormCard.Controls.Add(numAdults);
            panelFormCard.Controls.Add(lblChildren);
            panelFormCard.Controls.Add(numChildren);
            panelFormCard.Controls.Add(lblSpecialReq);
            panelFormCard.Controls.Add(txtSpecialReq);
            panelFormCard.Controls.Add(lblRatePerNight);
            panelFormCard.Controls.Add(txtRatePerNight);
            panelFormCard.Controls.Add(lblTotalNights);
            panelFormCard.Controls.Add(txtTotalNights);
            panelFormCard.Controls.Add(lblAddCharges);
            panelFormCard.Controls.Add(numAddCharges);
            panelFormCard.Controls.Add(lblDiscount);
            panelFormCard.Controls.Add(numDiscount);
            panelFormCard.Controls.Add(lblTotalAmount);
            panelFormCard.Controls.Add(txtTotalAmount);
            panelFormCard.Location = new Point(18, 19);
            panelFormCard.Name = "panelFormCard";
            panelFormCard.Size = new Size(446, 834);
            panelFormCard.TabIndex = 0;
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            lblFormTitle.ForeColor = Color.FromArgb(30, 42, 56);
            lblFormTitle.Location = new Point(13, 14);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(168, 24);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "New Reservation";
            // 
            // lblResId
            // 
            lblResId.AutoSize = true;
            lblResId.Location = new Point(13, 52);
            lblResId.Name = "lblResId";
            lblResId.Size = new Size(82, 15);
            lblResId.TabIndex = 1;
            lblResId.Text = "Reservation ID";
            // 
            // txtResId
            // 
            txtResId.Enabled = false;
            txtResId.Location = new Point(13, 70);
            txtResId.Name = "txtResId";
            txtResId.Size = new Size(420, 23);
            txtResId.TabIndex = 2;
            txtResId.Text = "R-2026102801";
            // 
            // lblGuest
            // 
            lblGuest.AutoSize = true;
            lblGuest.Location = new Point(13, 98);
            lblGuest.Name = "lblGuest";
            lblGuest.Size = new Size(72, 15);
            lblGuest.TabIndex = 3;
            lblGuest.Text = "Guest Name";
            // 
            // cmbGuest
            // 
            cmbGuest.FormattingEnabled = true;
            cmbGuest.Items.AddRange(new object[] { "Alexander Pierce", "Sarah Jenkins", "Michael Lee" });
            cmbGuest.Location = new Point(13, 117);
            cmbGuest.Name = "cmbGuest";
            cmbGuest.Size = new Size(381, 23);
            cmbGuest.TabIndex = 4;
            cmbGuest.Text = "Alexander Pierce";
            // 
            // btnAddGuest
            // 
            btnAddGuest.BackColor = Color.FromArgb(197, 160, 89);
            btnAddGuest.FlatStyle = FlatStyle.Flat;
            btnAddGuest.Location = new Point(398, 116);
            btnAddGuest.Name = "btnAddGuest";
            btnAddGuest.Size = new Size(35, 24);
            btnAddGuest.TabIndex = 5;
            btnAddGuest.Text = "+";
            btnAddGuest.UseVisualStyleBackColor = false;
            // 
            // lblRoomNo
            // 
            lblRoomNo.AutoSize = true;
            lblRoomNo.Location = new Point(13, 145);
            lblRoomNo.Name = "lblRoomNo";
            lblRoomNo.Size = new Size(86, 15);
            lblRoomNo.TabIndex = 6;
            lblRoomNo.Text = "Room Number";
            // 
            // cmbRoomNo
            // 
            cmbRoomNo.FormattingEnabled = true;
            cmbRoomNo.Items.AddRange(new object[] { "110", "112", "108", "105" });
            cmbRoomNo.Location = new Point(13, 164);
            cmbRoomNo.Name = "cmbRoomNo";
            cmbRoomNo.Size = new Size(197, 23);
            cmbRoomNo.TabIndex = 7;
            cmbRoomNo.Text = "110";
            // 
            // lblRoomTypeVal
            // 
            lblRoomTypeVal.BackColor = Color.FromArgb(230, 220, 205);
            lblRoomTypeVal.BorderStyle = BorderStyle.FixedSingle;
            lblRoomTypeVal.Location = new Point(223, 164);
            lblRoomTypeVal.Name = "lblRoomTypeVal";
            lblRoomTypeVal.Size = new Size(210, 23);
            lblRoomTypeVal.TabIndex = 8;
            lblRoomTypeVal.Text = "Deluxe Suite";
            lblRoomTypeVal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblArrival
            // 
            lblArrival.AutoSize = true;
            lblArrival.Location = new Point(13, 192);
            lblArrival.Name = "lblArrival";
            lblArrival.Size = new Size(68, 15);
            lblArrival.TabIndex = 9;
            lblArrival.Text = "Arrival Date";
            // 
            // dtpArrival
            // 
            dtpArrival.Format = DateTimePickerFormat.Short;
            dtpArrival.Location = new Point(13, 211);
            dtpArrival.Name = "dtpArrival";
            dtpArrival.Size = new Size(197, 23);
            dtpArrival.TabIndex = 10;
            // 
            // lblDeparture
            // 
            lblDeparture.AutoSize = true;
            lblDeparture.Location = new Point(223, 192);
            lblDeparture.Name = "lblDeparture";
            lblDeparture.Size = new Size(86, 15);
            lblDeparture.TabIndex = 11;
            lblDeparture.Text = "Departure Date";
            // 
            // dtpDeparture
            // 
            dtpDeparture.Format = DateTimePickerFormat.Short;
            dtpDeparture.Location = new Point(223, 211);
            dtpDeparture.Name = "dtpDeparture";
            dtpDeparture.Size = new Size(210, 23);
            dtpDeparture.TabIndex = 12;
            // 
            // lblAdults
            // 
            lblAdults.AutoSize = true;
            lblAdults.Location = new Point(13, 239);
            lblAdults.Name = "lblAdults";
            lblAdults.Size = new Size(102, 15);
            lblAdults.TabIndex = 13;
            lblAdults.Text = "Number of Adults";
            // 
            // numAdults
            // 
            numAdults.Location = new Point(13, 258);
            numAdults.Name = "numAdults";
            numAdults.Size = new Size(197, 23);
            numAdults.TabIndex = 14;
            numAdults.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // lblChildren
            // 
            lblChildren.AutoSize = true;
            lblChildren.Location = new Point(223, 239);
            lblChildren.Name = "lblChildren";
            lblChildren.Size = new Size(113, 15);
            lblChildren.TabIndex = 15;
            lblChildren.Text = "Number of Children";
            // 
            // numChildren
            // 
            numChildren.Location = new Point(223, 258);
            numChildren.Name = "numChildren";
            numChildren.Size = new Size(210, 23);
            numChildren.TabIndex = 16;
            numChildren.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblSpecialReq
            // 
            lblSpecialReq.AutoSize = true;
            lblSpecialReq.Location = new Point(13, 286);
            lblSpecialReq.Name = "lblSpecialReq";
            lblSpecialReq.Size = new Size(94, 15);
            lblSpecialReq.TabIndex = 17;
            lblSpecialReq.Text = "Special Requests";
            // 
            // txtSpecialReq
            // 
            txtSpecialReq.Location = new Point(13, 305);
            txtSpecialReq.Name = "txtSpecialReq";
            txtSpecialReq.Size = new Size(420, 66);
            txtSpecialReq.TabIndex = 18;
            txtSpecialReq.Text = "Please arrange for a fruit basket upon arrival. Quiet room preferred.";
            // 
            // lblRatePerNight
            // 
            lblRatePerNight.AutoSize = true;
            lblRatePerNight.Location = new Point(13, 384);
            lblRatePerNight.Name = "lblRatePerNight";
            lblRatePerNight.Size = new Size(83, 15);
            lblRatePerNight.TabIndex = 19;
            lblRatePerNight.Text = "Rate per Night";
            // 
            // txtRatePerNight
            // 
            txtRatePerNight.Location = new Point(13, 403);
            txtRatePerNight.Name = "txtRatePerNight";
            txtRatePerNight.Size = new Size(420, 23);
            txtRatePerNight.TabIndex = 20;
            txtRatePerNight.Text = "150.00";
            // 
            // lblTotalNights
            // 
            lblTotalNights.AutoSize = true;
            lblTotalNights.Location = new Point(13, 431);
            lblTotalNights.Name = "lblTotalNights";
            lblTotalNights.Size = new Size(71, 15);
            lblTotalNights.TabIndex = 21;
            lblTotalNights.Text = "Total Nights";
            // 
            // txtTotalNights
            // 
            txtTotalNights.Location = new Point(13, 450);
            txtTotalNights.Name = "txtTotalNights";
            txtTotalNights.Size = new Size(420, 23);
            txtTotalNights.TabIndex = 22;
            txtTotalNights.Text = "4";
            // 
            // lblAddCharges
            // 
            lblAddCharges.AutoSize = true;
            lblAddCharges.Location = new Point(13, 478);
            lblAddCharges.Name = "lblAddCharges";
            lblAddCharges.Size = new Size(108, 15);
            lblAddCharges.TabIndex = 23;
            lblAddCharges.Text = "Additional Charges";
            // 
            // numAddCharges
            // 
            numAddCharges.DecimalPlaces = 2;
            numAddCharges.Location = new Point(13, 497);
            numAddCharges.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numAddCharges.Name = "numAddCharges";
            numAddCharges.Size = new Size(420, 23);
            numAddCharges.TabIndex = 24;
            numAddCharges.Value = new decimal(new int[] { 25, 0, 0, 0 });
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Location = new Point(13, 525);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(54, 15);
            lblDiscount.TabIndex = 25;
            lblDiscount.Text = "Discount";
            // 
            // numDiscount
            // 
            numDiscount.DecimalPlaces = 2;
            numDiscount.Location = new Point(13, 544);
            numDiscount.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numDiscount.Name = "numDiscount";
            numDiscount.Size = new Size(420, 23);
            numDiscount.TabIndex = 26;
            numDiscount.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            lblTotalAmount.Location = new Point(13, 577);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(104, 17);
            lblTotalAmount.TabIndex = 27;
            lblTotalAmount.Text = "Total Amount";
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            txtTotalAmount.Location = new Point(13, 598);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.Size = new Size(420, 23);
            txtTotalAmount.TabIndex = 28;
            txtTotalAmount.Text = "615.00";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(197, 160, 89);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnSave.Location = new Point(39, 886);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(178, 38);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save Reservation";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(197, 160, 89);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnUpdate.Location = new Point(250, 886);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(178, 38);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update Reservation";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(197, 160, 89);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnCancel.Location = new Point(460, 886);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(178, 38);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel Reservation";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.FromArgb(197, 160, 89);
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnPrint.Location = new Point(672, 886);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(178, 38);
            btnPrint.TabIndex = 1;
            btnPrint.Text = "Print Confirmation";
            btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(197, 160, 89);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnClear.Location = new Point(883, 886);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(122, 38);
            btnClear.TabIndex = 0;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // lblGridTitle
            // 
            lblGridTitle.AutoSize = true;
            lblGridTitle.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            lblGridTitle.ForeColor = Color.Black;
            lblGridTitle.Location = new Point(477, 19);
            lblGridTitle.Name = "lblGridTitle";
            lblGridTitle.Size = new Size(157, 24);
            lblGridTitle.TabIndex = 6;
            lblGridTitle.Text = "Reservation List";
            // 
            // dgvReservations
            // 
            dgvReservations.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservations.Location = new Point(477, 61);
            dgvReservations.Name = "dgvReservations";
            dgvReservations.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvReservations.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvReservations.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dgvReservations.RowTemplate.Height = 24;
            dgvReservations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReservations.Size = new Size(957, 792);
            dgvReservations.TabIndex = 5;
            // 
            // RoomReservationUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            Controls.Add(btnClear);
            Controls.Add(btnPrint);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(dgvReservations);
            Controls.Add(lblGridTitle);
            Controls.Add(panelFormCard);
            Name = "RoomReservationUserControl";
            Size = new Size(1447, 965);
            panelFormCard.ResumeLayout(false);
            panelFormCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numAdults).EndInit();
            ((System.ComponentModel.ISupportInitialize)numChildren).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAddCharges).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDiscount).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvReservations).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Panel panelFormCard;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblResId;
        private System.Windows.Forms.TextBox txtResId;
        private System.Windows.Forms.Label lblGuest;
        private System.Windows.Forms.ComboBox cmbGuest;
        private System.Windows.Forms.Button btnAddGuest;
        private System.Windows.Forms.Label lblRoomNo;
        private System.Windows.Forms.ComboBox cmbRoomNo;
        private System.Windows.Forms.Label lblRoomTypeVal;
        private System.Windows.Forms.Label lblArrival;
        private System.Windows.Forms.DateTimePicker dtpArrival;
        private System.Windows.Forms.Label lblDeparture;
        private System.Windows.Forms.DateTimePicker dtpDeparture;
        private System.Windows.Forms.Label lblAdults;
        private System.Windows.Forms.NumericUpDown numAdults;
        private System.Windows.Forms.Label lblChildren;
        private System.Windows.Forms.NumericUpDown numChildren;
        private System.Windows.Forms.Label lblSpecialReq;
        private System.Windows.Forms.RichTextBox txtSpecialReq;
        private System.Windows.Forms.Label lblRatePerNight;
        private System.Windows.Forms.TextBox txtRatePerNight;
        private System.Windows.Forms.Label lblTotalNights;
        private System.Windows.Forms.TextBox txtTotalNights;
        private System.Windows.Forms.Label lblAddCharges;
        private System.Windows.Forms.NumericUpDown numAddCharges;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.NumericUpDown numDiscount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label lblGridTitle;
        private System.Windows.Forms.DataGridView dgvReservations;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClear;
    }
}