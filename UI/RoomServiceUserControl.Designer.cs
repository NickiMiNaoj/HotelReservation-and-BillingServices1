namespace UI
{
    partial class RoomServiceUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlForm = new Panel();
            lblTitle = new Label();
            lblRoomNumber = new Label();
            cboRoomNumber = new ComboBox();
            lblGuestName = new Label();
            txtGuestName = new TextBox();
            lblOrderType = new Label();
            cboOrderType = new ComboBox();
            lblOrderStatus = new Label();
            cboOrderStatus = new ComboBox();
            lblOrderDetails = new Label();
            rtbOrderDetails = new RichTextBox();
            lblTotalAmountText = new Label();
            lblTotalAmount = new Label();
            btnPlaceOrder = new Button();
            lblOrderHistory = new Label();
            dgvOrderHistory = new DataGridView();
            colOrderID = new DataGridViewTextBoxColumn();
            colRoomNumber = new DataGridViewTextBoxColumn();
            colGuestName = new DataGridViewTextBoxColumn();
            colOrderType = new DataGridViewTextBoxColumn();
            colTotalAmount = new DataGridViewTextBoxColumn();
            colOrderStatus = new DataGridViewTextBoxColumn();
            pnlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderHistory).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(30, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(220, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Room Service";
            // 
            // pnlForm
            // 
            pnlForm.BackColor = Color.White;
            pnlForm.BorderStyle = BorderStyle.FixedSingle;
            pnlForm.Controls.Add(btnPlaceOrder);
            pnlForm.Controls.Add(lblTotalAmount);
            pnlForm.Controls.Add(lblTotalAmountText);
            pnlForm.Controls.Add(rtbOrderDetails);
            pnlForm.Controls.Add(lblOrderDetails);
            pnlForm.Controls.Add(cboOrderStatus);
            pnlForm.Controls.Add(lblOrderStatus);
            pnlForm.Controls.Add(cboOrderType);
            pnlForm.Controls.Add(lblOrderType);
            pnlForm.Controls.Add(txtGuestName);
            pnlForm.Controls.Add(lblGuestName);
            pnlForm.Controls.Add(cboRoomNumber);
            pnlForm.Controls.Add(lblRoomNumber);
            pnlForm.Location = new Point(30, 70);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(620, 485);
            pnlForm.TabIndex = 1;
            // 
            // lblRoomNumber
            // 
            lblRoomNumber.AutoSize = true;
            lblRoomNumber.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoomNumber.Location = new Point(20, 20);
            lblRoomNumber.Name = "lblRoomNumber";
            lblRoomNumber.Size = new Size(105, 20);
            lblRoomNumber.TabIndex = 0;
            lblRoomNumber.Text = "Room Number";
            // 
            // cboRoomNumber
            // 
            cboRoomNumber.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRoomNumber.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboRoomNumber.FormattingEnabled = true;
            cboRoomNumber.Location = new Point(20, 45);
            cboRoomNumber.Name = "cboRoomNumber";
            cboRoomNumber.Size = new Size(270, 28);
            cboRoomNumber.TabIndex = 1;
            // 
            // lblGuestName
            // 
            lblGuestName.AutoSize = true;
            lblGuestName.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGuestName.Location = new Point(320, 20);
            lblGuestName.Name = "lblGuestName";
            lblGuestName.Size = new Size(90, 20);
            lblGuestName.TabIndex = 2;
            lblGuestName.Text = "Guest Name";
            // 
            // txtGuestName
            // 
            txtGuestName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGuestName.Location = new Point(320, 45);
            txtGuestName.Name = "txtGuestName";
            txtGuestName.Size = new Size(280, 27);
            txtGuestName.TabIndex = 3;
            // 
            // lblOrderType
            // 
            lblOrderType.AutoSize = true;
            lblOrderType.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderType.Location = new Point(20, 100);
            lblOrderType.Name = "lblOrderType";
            lblOrderType.Size = new Size(90, 20);
            lblOrderType.TabIndex = 4;
            lblOrderType.Text = "Order Type";
            // 
            // cboOrderType
            // 
            cboOrderType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboOrderType.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboOrderType.FormattingEnabled = true;
            cboOrderType.Items.AddRange(new object[] { "Food", "Beverage", "Amenities", "Laundry" });
            cboOrderType.Location = new Point(20, 125);
            cboOrderType.Name = "cboOrderType";
            cboOrderType.Size = new Size(270, 28);
            cboOrderType.TabIndex = 5;
            // 
            // lblOrderStatus
            // 
            lblOrderStatus.AutoSize = true;
            lblOrderStatus.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderStatus.Location = new Point(320, 100);
            lblOrderStatus.Name = "lblOrderStatus";
            lblOrderStatus.Size = new Size(100, 20);
            lblOrderStatus.TabIndex = 6;
            lblOrderStatus.Text = "Order Status";
            // 
            // cboOrderStatus
            // 
            cboOrderStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboOrderStatus.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboOrderStatus.FormattingEnabled = true;
            cboOrderStatus.Items.AddRange(new object[] { "Pending", "Preparing", "Delivered", "Cancelled" });
            cboOrderStatus.Location = new Point(320, 125);
            cboOrderStatus.Name = "cboOrderStatus";
            cboOrderStatus.Size = new Size(280, 28);
            cboOrderStatus.TabIndex = 7;
            // 
            // lblOrderDetails
            // 
            lblOrderDetails.AutoSize = true;
            lblOrderDetails.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderDetails.Location = new Point(20, 180);
            lblOrderDetails.Name = "lblOrderDetails";
            lblOrderDetails.Size = new Size(110, 20);
            lblOrderDetails.TabIndex = 8;
            lblOrderDetails.Text = "Order Details";
            // 
            // rtbOrderDetails
            // 
            rtbOrderDetails.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbOrderDetails.Location = new Point(20, 205);
            rtbOrderDetails.Name = "rtbOrderDetails";
            rtbOrderDetails.Size = new Size(580, 130);
            rtbOrderDetails.TabIndex = 9;
            rtbOrderDetails.Text = "";
            // 
            // lblTotalAmountText
            // 
            lblTotalAmountText.AutoSize = true;
            lblTotalAmountText.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalAmountText.Location = new Point(20, 358);
            lblTotalAmountText.Name = "lblTotalAmountText";
            lblTotalAmountText.Size = new Size(110, 20);
            lblTotalAmountText.TabIndex = 10;
            lblTotalAmountText.Text = "Total Amount:";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalAmount.Location = new Point(150, 350);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(90, 32);
            lblTotalAmount.TabIndex = 11;
            lblTotalAmount.Text = "₱0.00";
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.Font = new Font("Calisto MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlaceOrder.Location = new Point(20, 405);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(580, 55);
            btnPlaceOrder.TabIndex = 12;
            btnPlaceOrder.Text = "Place Order";
            btnPlaceOrder.UseVisualStyleBackColor = true;
            // 
            // lblOrderHistory
            // 
            lblOrderHistory.AutoSize = true;
            lblOrderHistory.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderHistory.Location = new Point(680, 75);
            lblOrderHistory.Name = "lblOrderHistory";
            lblOrderHistory.Size = new Size(120, 26);
            lblOrderHistory.TabIndex = 2;
            lblOrderHistory.Text = "Order History";
            // 
            // dgvOrderHistory
            // 
            dgvOrderHistory.AllowUserToAddRows = false;
            dgvOrderHistory.AllowUserToDeleteRows = false;
            dgvOrderHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvOrderHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderHistory.BackgroundColor = Color.White;
            dgvOrderHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderHistory.Columns.AddRange(new DataGridViewColumn[] { colOrderID, colRoomNumber, colGuestName, colOrderType, colTotalAmount, colOrderStatus });
            dgvOrderHistory.Location = new Point(680, 110);
            dgvOrderHistory.Name = "dgvOrderHistory";
            dgvOrderHistory.ReadOnly = true;
            dgvOrderHistory.RowHeadersVisible = false;
            dgvOrderHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrderHistory.Size = new Size(735, 820);
            dgvOrderHistory.TabIndex = 3;
            // 
            // colOrderID
            // 
            colOrderID.HeaderText = "Order ID";
            colOrderID.Name = "colOrderID";
            colOrderID.ReadOnly = true;
            // 
            // colRoomNumber
            // 
            colRoomNumber.HeaderText = "Room Number";
            colRoomNumber.Name = "colRoomNumber";
            colRoomNumber.ReadOnly = true;
            // 
            // colGuestName
            // 
            colGuestName.HeaderText = "Guest Name";
            colGuestName.Name = "colGuestName";
            colGuestName.ReadOnly = true;
            // 
            // colOrderType
            // 
            colOrderType.HeaderText = "Order Type";
            colOrderType.Name = "colOrderType";
            colOrderType.ReadOnly = true;
            // 
            // colTotalAmount
            // 
            colTotalAmount.HeaderText = "Total Amount";
            colTotalAmount.Name = "colTotalAmount";
            colTotalAmount.ReadOnly = true;
            // 
            // colOrderStatus
            // 
            colOrderStatus.HeaderText = "Order Status";
            colOrderStatus.Name = "colOrderStatus";
            colOrderStatus.ReadOnly = true;
            // 
            // RoomServiceUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(dgvOrderHistory);
            Controls.Add(lblOrderHistory);
            Controls.Add(pnlForm);
            Controls.Add(lblTitle);
            Name = "RoomServiceUserControl";
            Size = new Size(1445, 963);
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlForm;
        private Label lblTitle;
        private Label lblRoomNumber;
        private ComboBox cboRoomNumber;
        private Label lblGuestName;
        private TextBox txtGuestName;
        private Label lblOrderType;
        private ComboBox cboOrderType;
        private Label lblOrderStatus;
        private ComboBox cboOrderStatus;
        private Label lblOrderDetails;
        private RichTextBox rtbOrderDetails;
        private Label lblTotalAmountText;
        private Label lblTotalAmount;
        private Button btnPlaceOrder;
        private Label lblOrderHistory;
        private DataGridView dgvOrderHistory;
        private DataGridViewTextBoxColumn colOrderID;
        private DataGridViewTextBoxColumn colRoomNumber;
        private DataGridViewTextBoxColumn colGuestName;
        private DataGridViewTextBoxColumn colOrderType;
        private DataGridViewTextBoxColumn colTotalAmount;
        private DataGridViewTextBoxColumn colOrderStatus;
    }
}