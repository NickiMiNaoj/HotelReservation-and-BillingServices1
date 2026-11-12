namespace UI
{
    partial class SearchGuestInfoUserControl
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
            pnlSearch = new Panel();
            lblTitle = new Label();
            lblSearchKeyword = new Label();
            txtSearchKeyword = new TextBox();
            lblSearchBy = new Label();
            cboSearchBy = new ComboBox();
            btnSearch = new Button();
            btnClear = new Button();
            lblGuestList = new Label();
            dgvGuestList = new DataGridView();
            colGuestID = new DataGridViewTextBoxColumn();
            colFirstName = new DataGridViewTextBoxColumn();
            colLastName = new DataGridViewTextBoxColumn();
            colContactNumber = new DataGridViewTextBoxColumn();
            colEmailAddress = new DataGridViewTextBoxColumn();
            colNationality = new DataGridViewTextBoxColumn();
            btnViewGuestProfile = new Button();
            btnViewStayHistory = new Button();
            btnViewReservations = new Button();
            pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGuestList).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(30, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(260, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Search Guest Info";
            // 
            // pnlSearch
            // 
            pnlSearch.BackColor = Color.White;
            pnlSearch.BorderStyle = BorderStyle.FixedSingle;
            pnlSearch.Controls.Add(btnClear);
            pnlSearch.Controls.Add(btnSearch);
            pnlSearch.Controls.Add(cboSearchBy);
            pnlSearch.Controls.Add(lblSearchBy);
            pnlSearch.Controls.Add(txtSearchKeyword);
            pnlSearch.Controls.Add(lblSearchKeyword);
            pnlSearch.Location = new Point(30, 70);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(1385, 100);
            pnlSearch.TabIndex = 1;
            // 
            // lblSearchKeyword
            // 
            lblSearchKeyword.AutoSize = true;
            lblSearchKeyword.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearchKeyword.Location = new Point(20, 15);
            lblSearchKeyword.Name = "lblSearchKeyword";
            lblSearchKeyword.Size = new Size(120, 20);
            lblSearchKeyword.TabIndex = 0;
            lblSearchKeyword.Text = "Search Keyword";
            // 
            // txtSearchKeyword
            // 
            txtSearchKeyword.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchKeyword.Location = new Point(20, 40);
            txtSearchKeyword.Name = "txtSearchKeyword";
            txtSearchKeyword.Size = new Size(500, 27);
            txtSearchKeyword.TabIndex = 1;
            // 
            // lblSearchBy
            // 
            lblSearchBy.AutoSize = true;
            lblSearchBy.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearchBy.Location = new Point(550, 15);
            lblSearchBy.Name = "lblSearchBy";
            lblSearchBy.Size = new Size(75, 20);
            lblSearchBy.TabIndex = 2;
            lblSearchBy.Text = "Search By";
            // 
            // cboSearchBy
            // 
            cboSearchBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSearchBy.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboSearchBy.FormattingEnabled = true;
            cboSearchBy.Items.AddRange(new object[] { "Guest Name", "Guest ID", "Contact Number", "Email" });
            cboSearchBy.Location = new Point(550, 40);
            cboSearchBy.Name = "cboSearchBy";
            cboSearchBy.Size = new Size(280, 28);
            cboSearchBy.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Calisto MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(860, 30);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(160, 50);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Calisto MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(1040, 30);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(160, 50);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // lblGuestList
            // 
            lblGuestList.AutoSize = true;
            lblGuestList.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGuestList.Location = new Point(30, 190);
            lblGuestList.Name = "lblGuestList";
            lblGuestList.Size = new Size(90, 26);
            lblGuestList.TabIndex = 2;
            lblGuestList.Text = "Guest List";
            // 
            // dgvGuestList
            // 
            dgvGuestList.AllowUserToAddRows = false;
            dgvGuestList.AllowUserToDeleteRows = false;
            dgvGuestList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvGuestList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGuestList.BackgroundColor = Color.White;
            dgvGuestList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGuestList.Columns.AddRange(new DataGridViewColumn[] { colGuestID, colFirstName, colLastName, colContactNumber, colEmailAddress, colNationality });
            dgvGuestList.Location = new Point(30, 225);
            dgvGuestList.Name = "dgvGuestList";
            dgvGuestList.ReadOnly = true;
            dgvGuestList.RowHeadersVisible = false;
            dgvGuestList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGuestList.Size = new Size(1385, 630);
            dgvGuestList.TabIndex = 3;
            // 
            // colGuestID
            // 
            colGuestID.HeaderText = "Guest ID";
            colGuestID.Name = "colGuestID";
            colGuestID.ReadOnly = true;
            // 
            // colFirstName
            // 
            colFirstName.HeaderText = "First Name";
            colFirstName.Name = "colFirstName";
            colFirstName.ReadOnly = true;
            // 
            // colLastName
            // 
            colLastName.HeaderText = "Last Name";
            colLastName.Name = "colLastName";
            colLastName.ReadOnly = true;
            // 
            // colContactNumber
            // 
            colContactNumber.HeaderText = "Contact Number";
            colContactNumber.Name = "colContactNumber";
            colContactNumber.ReadOnly = true;
            // 
            // colEmailAddress
            // 
            colEmailAddress.HeaderText = "Email Address";
            colEmailAddress.Name = "colEmailAddress";
            colEmailAddress.ReadOnly = true;
            // 
            // colNationality
            // 
            colNationality.HeaderText = "Nationality";
            colNationality.Name = "colNationality";
            colNationality.ReadOnly = true;
            // 
            // btnViewGuestProfile
            // 
            btnViewGuestProfile.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnViewGuestProfile.Font = new Font("Calisto MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewGuestProfile.Location = new Point(30, 880);
            btnViewGuestProfile.Name = "btnViewGuestProfile";
            btnViewGuestProfile.Size = new Size(250, 55);
            btnViewGuestProfile.TabIndex = 4;
            btnViewGuestProfile.Text = "View Guest Profile";
            btnViewGuestProfile.UseVisualStyleBackColor = true;
            // 
            // btnViewStayHistory
            // 
            btnViewStayHistory.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnViewStayHistory.Font = new Font("Calisto MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewStayHistory.Location = new Point(295, 880);
            btnViewStayHistory.Name = "btnViewStayHistory";
            btnViewStayHistory.Size = new Size(250, 55);
            btnViewStayHistory.TabIndex = 5;
            btnViewStayHistory.Text = "View Stay History";
            btnViewStayHistory.UseVisualStyleBackColor = true;
            // 
            // btnViewReservations
            // 
            btnViewReservations.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnViewReservations.Font = new Font("Calisto MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewReservations.Location = new Point(560, 880);
            btnViewReservations.Name = "btnViewReservations";
            btnViewReservations.Size = new Size(250, 55);
            btnViewReservations.TabIndex = 6;
            btnViewReservations.Text = "View Reservations";
            btnViewReservations.UseVisualStyleBackColor = true;
            // 
            // SearchGuestInfoUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(btnViewReservations);
            Controls.Add(btnViewStayHistory);
            Controls.Add(btnViewGuestProfile);
            Controls.Add(dgvGuestList);
            Controls.Add(lblGuestList);
            Controls.Add(pnlSearch);
            Controls.Add(lblTitle);
            Name = "SearchGuestInfoUserControl";
            Size = new Size(1445, 963);
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGuestList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSearch;
        private Label lblTitle;
        private Label lblSearchKeyword;
        private TextBox txtSearchKeyword;
        private Label lblSearchBy;
        private ComboBox cboSearchBy;
        private Button btnSearch;
        private Button btnClear;
        private Label lblGuestList;
        private DataGridView dgvGuestList;
        private DataGridViewTextBoxColumn colGuestID;
        private DataGridViewTextBoxColumn colFirstName;
        private DataGridViewTextBoxColumn colLastName;
        private DataGridViewTextBoxColumn colContactNumber;
        private DataGridViewTextBoxColumn colEmailAddress;
        private DataGridViewTextBoxColumn colNationality;
        private Button btnViewGuestProfile;
        private Button btnViewStayHistory;
        private Button btnViewReservations;
    }
}