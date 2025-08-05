namespace POSpresso.Forms.AdminForms
{
    partial class ManageUserForm
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUserForm));
            dtgvUsers = new DataGridView();
            label6 = new Label();
            btnAddUser = new Button();
            btnDeleteUser = new Button();
            btnClear = new Button();
            lbUploadImage = new LinkLabel();
            UserPhotoBox = new FontAwesome.Sharp.IconPictureBox();
            ManageUserPanel = new Panel();
            btnChangePassword = new Button();
            label7 = new Label();
            cbStatus = new ComboBox();
            label5 = new Label();
            cbUserRole = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            tbUsername = new RichTextBox();
            label2 = new Label();
            tbLastName = new RichTextBox();
            label1 = new Label();
            tbFirstName = new RichTextBox();
            label8 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            btnShowAdd = new Button();
            tbUserSearch = new RichTextBox();
            btnUserSearch = new FontAwesome.Sharp.IconButton();
            tbPassword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtgvUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UserPhotoBox).BeginInit();
            ManageUserPanel.SuspendLayout();
            SuspendLayout();
            // 
            // dtgvUsers
            // 
            dtgvUsers.AllowUserToAddRows = false;
            dtgvUsers.AllowUserToDeleteRows = false;
            dtgvUsers.AllowUserToResizeRows = false;
            dtgvUsers.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dtgvUsers.DefaultCellStyle = dataGridViewCellStyle4;
            dtgvUsers.GridColor = Color.Black;
            dtgvUsers.Location = new Point(1, 71);
            dtgvUsers.Name = "dtgvUsers";
            dtgvUsers.ReadOnly = true;
            dtgvUsers.RowHeadersVisible = false;
            dtgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvUsers.Size = new Size(487, 534);
            dtgvUsers.TabIndex = 0;
            dtgvUsers.CellContentClick += dtgvUsers_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(150, 30);
            label6.TabIndex = 13;
            label6.Text = "Manage Users";
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.Transparent;
            btnAddUser.BackgroundImage = (Image)resources.GetObject("btnAddUser.BackgroundImage");
            btnAddUser.FlatAppearance.BorderSize = 0;
            btnAddUser.FlatStyle = FlatStyle.Flat;
            btnAddUser.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnAddUser.ForeColor = Color.White;
            btnAddUser.Location = new Point(105, 357);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(72, 29);
            btnAddUser.TabIndex = 14;
            btnAddUser.Text = "Save";
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.BackColor = Color.Transparent;
            btnDeleteUser.BackgroundImage = (Image)resources.GetObject("btnDeleteUser.BackgroundImage");
            btnDeleteUser.FlatAppearance.BorderSize = 0;
            btnDeleteUser.FlatStyle = FlatStyle.Flat;
            btnDeleteUser.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnDeleteUser.ForeColor = Color.White;
            btnDeleteUser.Location = new Point(196, 392);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(66, 29);
            btnDeleteUser.TabIndex = 17;
            btnDeleteUser.Text = "Delete User";
            btnDeleteUser.UseVisualStyleBackColor = false;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Transparent;
            btnClear.BackgroundImage = (Image)resources.GetObject("btnClear.BackgroundImage");
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(196, 357);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(69, 29);
            btnClear.TabIndex = 18;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // lbUploadImage
            // 
            lbUploadImage.ActiveLinkColor = Color.Red;
            lbUploadImage.AutoSize = true;
            lbUploadImage.BackColor = Color.Transparent;
            lbUploadImage.LinkColor = Color.FromArgb(0, 192, 192);
            lbUploadImage.Location = new Point(116, 112);
            lbUploadImage.Name = "lbUploadImage";
            lbUploadImage.Size = new Size(81, 15);
            lbUploadImage.TabIndex = 21;
            lbUploadImage.TabStop = true;
            lbUploadImage.Text = "Upload Image";
            lbUploadImage.LinkClicked += lbUploadImage_LinkClicked;
            // 
            // UserPhotoBox
            // 
            UserPhotoBox.BackColor = SystemColors.Control;
            UserPhotoBox.ForeColor = SystemColors.ControlText;
            UserPhotoBox.IconChar = FontAwesome.Sharp.IconChar.None;
            UserPhotoBox.IconColor = SystemColors.ControlText;
            UserPhotoBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            UserPhotoBox.IconSize = 66;
            UserPhotoBox.Location = new Point(114, 43);
            UserPhotoBox.Name = "UserPhotoBox";
            UserPhotoBox.Size = new Size(83, 66);
            UserPhotoBox.SizeMode = PictureBoxSizeMode.StretchImage;
            UserPhotoBox.TabIndex = 22;
            UserPhotoBox.TabStop = false;
            // 
            // ManageUserPanel
            // 
            ManageUserPanel.BackgroundImage = (Image)resources.GetObject("ManageUserPanel.BackgroundImage");
            ManageUserPanel.Controls.Add(tbPassword);
            ManageUserPanel.Controls.Add(btnChangePassword);
            ManageUserPanel.Controls.Add(UserPhotoBox);
            ManageUserPanel.Controls.Add(lbUploadImage);
            ManageUserPanel.Controls.Add(label7);
            ManageUserPanel.Controls.Add(cbStatus);
            ManageUserPanel.Controls.Add(btnClear);
            ManageUserPanel.Controls.Add(btnDeleteUser);
            ManageUserPanel.Controls.Add(btnAddUser);
            ManageUserPanel.Controls.Add(label6);
            ManageUserPanel.Controls.Add(label5);
            ManageUserPanel.Controls.Add(cbUserRole);
            ManageUserPanel.Controls.Add(label4);
            ManageUserPanel.Controls.Add(label3);
            ManageUserPanel.Controls.Add(tbUsername);
            ManageUserPanel.Controls.Add(label2);
            ManageUserPanel.Controls.Add(tbLastName);
            ManageUserPanel.Controls.Add(label1);
            ManageUserPanel.Controls.Add(tbFirstName);
            ManageUserPanel.Location = new Point(491, 0);
            ManageUserPanel.Name = "ManageUserPanel";
            ManageUserPanel.Size = new Size(276, 605);
            ManageUserPanel.TabIndex = 1;
            ManageUserPanel.Visible = false;
            // 
            // btnChangePassword
            // 
            btnChangePassword.BackColor = Color.Transparent;
            btnChangePassword.BackgroundImage = (Image)resources.GetObject("btnChangePassword.BackgroundImage");
            btnChangePassword.FlatAppearance.BorderSize = 0;
            btnChangePassword.FlatStyle = FlatStyle.Flat;
            btnChangePassword.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnChangePassword.ForeColor = Color.White;
            btnChangePassword.Location = new Point(105, 260);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(160, 29);
            btnChangePassword.TabIndex = 23;
            btnChangePassword.Text = "Change Password";
            btnChangePassword.UseVisualStyleBackColor = false;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(3, 328);
            label7.Name = "label7";
            label7.Size = new Size(61, 21);
            label7.TabIndex = 20;
            label7.Text = "Status:";
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(105, 326);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(72, 23);
            cbStatus.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 301);
            label5.Name = "label5";
            label5.Size = new Size(48, 21);
            label5.TabIndex = 12;
            label5.Text = "Role:";
            // 
            // cbUserRole
            // 
            cbUserRole.FormattingEnabled = true;
            cbUserRole.Location = new Point(105, 299);
            cbUserRole.Name = "cbUserRole";
            cbUserRole.Size = new Size(72, 23);
            cbUserRole.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(3, 268);
            label4.Name = "label4";
            label4.Size = new Size(86, 21);
            label4.TabIndex = 10;
            label4.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 233);
            label3.Name = "label3";
            label3.Size = new Size(91, 21);
            label3.TabIndex = 8;
            label3.Text = "Username:";
            // 
            // tbUsername
            // 
            tbUsername.BackColor = SystemColors.ControlLightLight;
            tbUsername.BorderStyle = BorderStyle.None;
            tbUsername.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbUsername.Location = new Point(105, 225);
            tbUsername.Multiline = false;
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(160, 29);
            tbUsername.TabIndex = 7;
            tbUsername.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 198);
            label2.Name = "label2";
            label2.Size = new Size(94, 21);
            label2.TabIndex = 6;
            label2.Text = "Last Name:";
            // 
            // tbLastName
            // 
            tbLastName.BackColor = SystemColors.ControlLightLight;
            tbLastName.BorderStyle = BorderStyle.None;
            tbLastName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbLastName.Location = new Point(105, 190);
            tbLastName.Multiline = false;
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(160, 29);
            tbLastName.TabIndex = 5;
            tbLastName.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 163);
            label1.Name = "label1";
            label1.Size = new Size(96, 21);
            label1.TabIndex = 4;
            label1.Text = "First Name:";
            // 
            // tbFirstName
            // 
            tbFirstName.BackColor = SystemColors.ControlLightLight;
            tbFirstName.BorderStyle = BorderStyle.None;
            tbFirstName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbFirstName.Location = new Point(105, 155);
            tbFirstName.Multiline = false;
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(160, 29);
            tbFirstName.TabIndex = 0;
            tbFirstName.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(1, 3);
            label8.Name = "label8";
            label8.Size = new Size(96, 30);
            label8.TabIndex = 23;
            label8.Text = "User List";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // btnShowAdd
            // 
            btnShowAdd.BackColor = Color.Transparent;
            btnShowAdd.BackgroundImage = (Image)resources.GetObject("btnShowAdd.BackgroundImage");
            btnShowAdd.FlatAppearance.BorderSize = 0;
            btnShowAdd.FlatStyle = FlatStyle.Flat;
            btnShowAdd.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnShowAdd.ForeColor = Color.White;
            btnShowAdd.Location = new Point(390, 36);
            btnShowAdd.Name = "btnShowAdd";
            btnShowAdd.Size = new Size(95, 29);
            btnShowAdd.TabIndex = 23;
            btnShowAdd.Text = "Add New ";
            btnShowAdd.UseVisualStyleBackColor = false;
            btnShowAdd.Click += btnShowAdd_Click;
            // 
            // tbUserSearch
            // 
            tbUserSearch.BackColor = SystemColors.ControlLightLight;
            tbUserSearch.BorderStyle = BorderStyle.None;
            tbUserSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbUserSearch.Location = new Point(85, 36);
            tbUserSearch.Multiline = false;
            tbUserSearch.Name = "tbUserSearch";
            tbUserSearch.Size = new Size(257, 29);
            tbUserSearch.TabIndex = 23;
            tbUserSearch.Text = "";
            // 
            // btnUserSearch
            // 
            btnUserSearch.ForeColor = Color.SaddleBrown;
            btnUserSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnUserSearch.IconColor = Color.Black;
            btnUserSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnUserSearch.IconSize = 30;
            btnUserSearch.Location = new Point(348, 33);
            btnUserSearch.Name = "btnUserSearch";
            btnUserSearch.Size = new Size(36, 32);
            btnUserSearch.TabIndex = 24;
            btnUserSearch.UseVisualStyleBackColor = true;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbPassword.Location = new Point(105, 260);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(160, 29);
            tbPassword.TabIndex = 24;
            // 
            // ManageUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 620);
            Controls.Add(btnUserSearch);
            Controls.Add(tbUserSearch);
            Controls.Add(btnShowAdd);
            Controls.Add(label8);
            Controls.Add(ManageUserPanel);
            Controls.Add(dtgvUsers);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageUserForm";
            Text = "UserForm";
            Load += ManageUserForm_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)UserPhotoBox).EndInit();
            ManageUserPanel.ResumeLayout(false);
            ManageUserPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvUsers;
        private Label label6;
        private Button btnAddUser;
        private Button btnDeleteUser;
        private Button btnClear;
        private LinkLabel lbUploadImage;
        private FontAwesome.Sharp.IconPictureBox UserPhotoBox;
        private Panel ManageUserPanel;
        private Label label7;
        private ComboBox cbStatus;
        private Label label5;
        private ComboBox cbUserRole;
        private Label label4;
        private Label label3;
        private RichTextBox tbUsername;
        private Label label2;
        private RichTextBox tbLastName;
        private Label label1;
        private RichTextBox tbFirstName;
        private Label label8;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button btnShowAdd;
        private RichTextBox tbUserSearch;
        private FontAwesome.Sharp.IconButton btnUserSearch;
        private Button btnChangePassword;
        private TextBox tbPassword;
    }
}