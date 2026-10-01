namespace UI
{
    partial class guest_maintenanceform
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            listViewGuestID = new ListView();
            listViewFirstName = new ListView();
            listViewLastName = new ListView();
            listViewContactNumber = new ListView();
            listViewEmail = new ListView();
            lblGuestMaintenance = new Label();
            lblGuestID = new Label();
            lblLastName = new Label();
            lblFirstName = new Label();
            lblEmail = new Label();
            lblContactNumber = new Label();
            bindingSource1 = new BindingSource(components);
            btnSearch = new Button();
            btnAddNewGuest = new Button();
            txbSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // listViewGuestID
            // 
            listViewGuestID.Location = new Point(194, 96);
            listViewGuestID.Name = "listViewGuestID";
            listViewGuestID.Size = new Size(182, 353);
            listViewGuestID.TabIndex = 3;
            listViewGuestID.UseCompatibleStateImageBehavior = false;
            // 
            // listViewFirstName
            // 
            listViewFirstName.Location = new Point(449, 96);
            listViewFirstName.Name = "listViewFirstName";
            listViewFirstName.Size = new Size(182, 353);
            listViewFirstName.TabIndex = 4;
            listViewFirstName.UseCompatibleStateImageBehavior = false;
            // 
            // listViewLastName
            // 
            listViewLastName.Location = new Point(700, 96);
            listViewLastName.Name = "listViewLastName";
            listViewLastName.Size = new Size(182, 353);
            listViewLastName.TabIndex = 6;
            listViewLastName.UseCompatibleStateImageBehavior = false;
            // 
            // listViewContactNumber
            // 
            listViewContactNumber.Location = new Point(946, 96);
            listViewContactNumber.Name = "listViewContactNumber";
            listViewContactNumber.Size = new Size(182, 353);
            listViewContactNumber.TabIndex = 7;
            listViewContactNumber.UseCompatibleStateImageBehavior = false;
            // 
            // listViewEmail
            // 
            listViewEmail.Location = new Point(1192, 96);
            listViewEmail.Name = "listViewEmail";
            listViewEmail.Size = new Size(182, 353);
            listViewEmail.TabIndex = 9;
            listViewEmail.UseCompatibleStateImageBehavior = false;
            // 
            // lblGuestMaintenance
            // 
            lblGuestMaintenance.AutoSize = true;
            lblGuestMaintenance.Location = new Point(24, 12);
            lblGuestMaintenance.Name = "lblGuestMaintenance";
            lblGuestMaintenance.Size = new Size(162, 25);
            lblGuestMaintenance.TabIndex = 16;
            lblGuestMaintenance.Text = "Guest Maintenance";
            // 
            // lblGuestID
            // 
            lblGuestID.AutoSize = true;
            lblGuestID.Location = new Point(236, 55);
            lblGuestID.Name = "lblGuestID";
            lblGuestID.Size = new Size(82, 25);
            lblGuestID.TabIndex = 17;
            lblGuestID.Text = "Guest_ID";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(743, 55);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(95, 25);
            lblLastName.TabIndex = 18;
            lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(496, 55);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(97, 25);
            lblFirstName.TabIndex = 19;
            lblFirstName.Text = "First Name";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(1250, 55);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 25);
            lblEmail.TabIndex = 20;
            lblEmail.Text = "Email";
            // 
            // lblContactNumber
            // 
            lblContactNumber.AutoSize = true;
            lblContactNumber.Location = new Point(964, 55);
            lblContactNumber.Name = "lblContactNumber";
            lblContactNumber.Size = new Size(143, 25);
            lblContactNumber.TabIndex = 21;
            lblContactNumber.Text = "Contact Number";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(1262, 5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(143, 34);
            btnSearch.TabIndex = 23;
            btnSearch.Text = "Search button";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnAddNewGuest
            // 
            btnAddNewGuest.Location = new Point(894, 7);
            btnAddNewGuest.Name = "btnAddNewGuest";
            btnAddNewGuest.Size = new Size(153, 34);
            btnAddNewGuest.TabIndex = 24;
            btnAddNewGuest.Text = "Add New Guest";
            btnAddNewGuest.UseVisualStyleBackColor = true;
            // 
            // txbSearch
            // 
            txbSearch.Location = new Point(1084, 12);
            txbSearch.Name = "txbSearch";
            txbSearch.Size = new Size(150, 31);
            txbSearch.TabIndex = 25;
            // 
            // guest_maintenanceform
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1545, 450);
            Controls.Add(txbSearch);
            Controls.Add(btnAddNewGuest);
            Controls.Add(btnSearch);
            Controls.Add(lblContactNumber);
            Controls.Add(lblEmail);
            Controls.Add(lblFirstName);
            Controls.Add(lblLastName);
            Controls.Add(lblGuestID);
            Controls.Add(lblGuestMaintenance);
            Controls.Add(listViewEmail);
            Controls.Add(listViewContactNumber);
            Controls.Add(listViewLastName);
            Controls.Add(listViewFirstName);
            Controls.Add(listViewGuestID);
            Name = "guest_maintenanceform";
            Text = "guest_maintenanceform";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListView listViewGuestID;
        private ListView listViewFirstName;
        private ListView listView5;
        private ListView listViewLastName;
        private ListView listViewContactNumber;
        private ListView listView8;
        private ListView listViewEmail;
        private ListView listView10;
        private Label lblGuestMaintenance;
        private Label lblGuestID;
        private Label lblLastName;
        private Label lblFirstName;
        private Label lblEmail;
        private Label lblContactNumber;
        private BindingSource bindingSource1;
        private TextBox textBox1;
        private Button btnSearch;
        private Button btnAddNewGuest;
        private TextBox txbSearch;
    }
}