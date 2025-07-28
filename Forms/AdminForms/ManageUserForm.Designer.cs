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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUserForm));
            dtgvUsers = new DataGridView();
            ManageUserPanel = new Panel();
            UserPhotoBox = new FontAwesome.Sharp.IconPictureBox();
            lbUploadImage = new LinkLabel();
            label7 = new Label();
            cbStatus = new ComboBox();
            btnClear = new Button();
            btnDeleteUser = new Button();
            btnEditUser = new Button();
            btnAddUser = new Button();
            label6 = new Label();
            label5 = new Label();
            cbUserRole = new ComboBox();
            label4 = new Label();
            tbPassword = new RichTextBox();
            label3 = new Label();
            tbUsername = new RichTextBox();
            label2 = new Label();
            tbLastName = new RichTextBox();
            label1 = new Label();
            tbFirstName = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)dtgvUsers).BeginInit();
            ManageUserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserPhotoBox).BeginInit();
            SuspendLayout();
            // 
            // dtgvUsers
            // 
            dtgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvUsers.GridColor = Color.Black;
            dtgvUsers.Location = new Point(12, 294);
            dtgvUsers.Name = "dtgvUsers";
            dtgvUsers.Size = new Size(565, 314);
            dtgvUsers.TabIndex = 0;
            dtgvUsers.CellContentClick += dtgvUsers_CellContentClick;
            // 
            // ManageUserPanel
            // 
            ManageUserPanel.BackgroundImage = (Image)resources.GetObject("ManageUserPanel.BackgroundImage");
            ManageUserPanel.Controls.Add(UserPhotoBox);
            ManageUserPanel.Controls.Add(lbUploadImage);
            ManageUserPanel.Controls.Add(label7);
            ManageUserPanel.Controls.Add(cbStatus);
            ManageUserPanel.Controls.Add(btnClear);
            ManageUserPanel.Controls.Add(btnDeleteUser);
            ManageUserPanel.Controls.Add(btnEditUser);
            ManageUserPanel.Controls.Add(btnAddUser);
            ManageUserPanel.Controls.Add(label6);
            ManageUserPanel.Controls.Add(label5);
            ManageUserPanel.Controls.Add(cbUserRole);
            ManageUserPanel.Controls.Add(label4);
            ManageUserPanel.Controls.Add(tbPassword);
            ManageUserPanel.Controls.Add(label3);
            ManageUserPanel.Controls.Add(tbUsername);
            ManageUserPanel.Controls.Add(label2);
            ManageUserPanel.Controls.Add(tbLastName);
            ManageUserPanel.Controls.Add(label1);
            ManageUserPanel.Controls.Add(tbFirstName);
            ManageUserPanel.Location = new Point(22, 19);
            ManageUserPanel.Name = "ManageUserPanel";
            ManageUserPanel.Size = new Size(547, 269);
            ManageUserPanel.TabIndex = 1;
            // 
            // UserPhotoBox
            // 
            UserPhotoBox.BackColor = SystemColors.Control;
            UserPhotoBox.ForeColor = SystemColors.ControlText;
            UserPhotoBox.IconChar = FontAwesome.Sharp.IconChar.None;
            UserPhotoBox.IconColor = SystemColors.ControlText;
            UserPhotoBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            UserPhotoBox.IconSize = 66;
            UserPhotoBox.Location = new Point(451, 3);
            UserPhotoBox.Name = "UserPhotoBox";
            UserPhotoBox.Size = new Size(83, 66);
            UserPhotoBox.SizeMode = PictureBoxSizeMode.StretchImage;
            UserPhotoBox.TabIndex = 22;
            UserPhotoBox.TabStop = false;
            // 
            // lbUploadImage
            // 
            lbUploadImage.ActiveLinkColor = Color.Red;
            lbUploadImage.AutoSize = true;
            lbUploadImage.BackColor = Color.Transparent;
            lbUploadImage.LinkColor = Color.FromArgb(0, 192, 192);
            lbUploadImage.Location = new Point(453, 72);
            lbUploadImage.Name = "lbUploadImage";
            lbUploadImage.Size = new Size(81, 15);
            lbUploadImage.TabIndex = 21;
            lbUploadImage.TabStop = true;
            lbUploadImage.Text = "Upload Image";
            lbUploadImage.LinkClicked += lbUploadImage_LinkClicked;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(10, 231);
            label7.Name = "label7";
            label7.Size = new Size(61, 21);
            label7.TabIndex = 20;
            label7.Text = "Status:";
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(112, 231);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(90, 23);
            cbStatus.TabIndex = 19;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Transparent;
            btnClear.BackgroundImage = (Image)resources.GetObject("btnClear.BackgroundImage");
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(325, 169);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 18;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.BackColor = Color.Transparent;
            btnDeleteUser.BackgroundImage = (Image)resources.GetObject("btnDeleteUser.BackgroundImage");
            btnDeleteUser.FlatAppearance.BorderSize = 0;
            btnDeleteUser.FlatStyle = FlatStyle.Flat;
            btnDeleteUser.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnDeleteUser.ForeColor = Color.White;
            btnDeleteUser.Location = new Point(325, 130);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(94, 29);
            btnDeleteUser.TabIndex = 17;
            btnDeleteUser.Text = "Delete User";
            btnDeleteUser.UseVisualStyleBackColor = false;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // btnEditUser
            // 
            btnEditUser.BackColor = Color.Transparent;
            btnEditUser.BackgroundImage = (Image)resources.GetObject("btnEditUser.BackgroundImage");
            btnEditUser.FlatAppearance.BorderSize = 0;
            btnEditUser.FlatStyle = FlatStyle.Flat;
            btnEditUser.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnEditUser.ForeColor = Color.White;
            btnEditUser.Location = new Point(325, 90);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(94, 29);
            btnEditUser.TabIndex = 15;
            btnEditUser.Text = "Edit User";
            btnEditUser.UseVisualStyleBackColor = false;
            btnEditUser.Click += btnEditUser_Click;
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.Transparent;
            btnAddUser.BackgroundImage = (Image)resources.GetObject("btnAddUser.BackgroundImage");
            btnAddUser.FlatAppearance.BorderSize = 0;
            btnAddUser.FlatStyle = FlatStyle.Flat;
            btnAddUser.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnAddUser.ForeColor = Color.White;
            btnAddUser.Location = new Point(325, 55);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(94, 29);
            btnAddUser.TabIndex = 14;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(208, 0);
            label6.Name = "label6";
            label6.Size = new Size(150, 30);
            label6.TabIndex = 13;
            label6.Text = "Manage Users";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(10, 204);
            label5.Name = "label5";
            label5.Size = new Size(48, 21);
            label5.TabIndex = 12;
            label5.Text = "Role:";
            // 
            // cbUserRole
            // 
            cbUserRole.FormattingEnabled = true;
            cbUserRole.Location = new Point(112, 202);
            cbUserRole.Name = "cbUserRole";
            cbUserRole.Size = new Size(90, 23);
            cbUserRole.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(10, 171);
            label4.Name = "label4";
            label4.Size = new Size(86, 21);
            label4.TabIndex = 10;
            label4.Text = "Password:";
            // 
            // tbPassword
            // 
            tbPassword.BackColor = SystemColors.ControlLightLight;
            tbPassword.BorderStyle = BorderStyle.None;
            tbPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbPassword.Location = new Point(110, 163);
            tbPassword.Multiline = false;
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(209, 29);
            tbPassword.TabIndex = 9;
            tbPassword.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(10, 136);
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
            tbUsername.Location = new Point(110, 128);
            tbUsername.Multiline = false;
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(209, 29);
            tbUsername.TabIndex = 7;
            tbUsername.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(10, 101);
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
            tbLastName.Location = new Point(110, 93);
            tbLastName.Multiline = false;
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(209, 29);
            tbLastName.TabIndex = 5;
            tbLastName.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 66);
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
            tbFirstName.Location = new Point(110, 58);
            tbFirstName.Multiline = false;
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(209, 29);
            tbFirstName.TabIndex = 0;
            tbFirstName.Text = "";
            // 
            // ManageUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 620);
            Controls.Add(ManageUserPanel);
            Controls.Add(dtgvUsers);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageUserForm";
            Text = "UserForm";
            Load += ManageUserForm_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvUsers).EndInit();
            ManageUserPanel.ResumeLayout(false);
            ManageUserPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UserPhotoBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgvUsers;
        private Panel ManageUserPanel;
        private RichTextBox tbFirstName;
        private Label label1;
        private RichTextBox tbPassword;
        private Label label3;
        private RichTextBox tbUsername;
        private Label label2;
        private RichTextBox tbLastName;
        private Button btnEditUser;
        private Button btnAddUser;
        private Label label6;
        private Label label5;
        private ComboBox cbUserRole;
        private Label label4;
        private Label label7;
        private ComboBox cbStatus;
        private Button btnClear;
        private Button btnDeleteUser;
        private FontAwesome.Sharp.IconPictureBox UserPhotoBox;
        private LinkLabel lbUploadImage;
    }
}