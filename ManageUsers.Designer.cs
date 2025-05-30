namespace InventoryMngmtSys
{
    partial class ManageUsers
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            QuitBttn = new Label();
            MainTitleLabel = new Label();
            subTitleLabel = new Label();
            Username = new MaterialSkin.Controls.MaterialMaskedTextBox();
            FullName = new MaterialSkin.Controls.MaterialMaskedTextBox();
            Password = new MaterialSkin.Controls.MaterialMaskedTextBox();
            Phone = new MaterialSkin.Controls.MaterialMaskedTextBox();
            AddBttn = new MaterialSkin.Controls.MaterialButton();
            EditBttn = new MaterialSkin.Controls.MaterialButton();
            DeleteBttn = new MaterialSkin.Controls.MaterialButton();
            HomeBttn = new MaterialSkin.Controls.MaterialButton();
            UserDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserDGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Crimson;
            panel1.Controls.Add(QuitBttn);
            panel1.Controls.Add(MainTitleLabel);
            panel1.Controls.Add(subTitleLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(850, 94);
            panel1.TabIndex = 0;
            // 
            // QuitBttn
            // 
            QuitBttn.AutoSize = true;
            QuitBttn.Font = new Font("Franklin Gothic Medium", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            QuitBttn.ForeColor = Color.White;
            QuitBttn.Location = new Point(820, 0);
            QuitBttn.Name = "QuitBttn";
            QuitBttn.Size = new Size(30, 34);
            QuitBttn.TabIndex = 2;
            QuitBttn.Text = "X";
            QuitBttn.Click += QuitBttn_Click;
            // 
            // MainTitleLabel
            // 
            MainTitleLabel.AutoSize = true;
            MainTitleLabel.Font = new Font("Franklin Gothic Medium", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MainTitleLabel.ForeColor = Color.White;
            MainTitleLabel.Location = new Point(102, 11);
            MainTitleLabel.Name = "MainTitleLabel";
            MainTitleLabel.Size = new Size(471, 37);
            MainTitleLabel.TabIndex = 1;
            MainTitleLabel.Text = "Inventory Management System";
            // 
            // subTitleLabel
            // 
            subTitleLabel.AutoSize = true;
            subTitleLabel.Font = new Font("Franklin Gothic Medium", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            subTitleLabel.ForeColor = Color.White;
            subTitleLabel.Location = new Point(242, 46);
            subTitleLabel.Name = "subTitleLabel";
            subTitleLabel.Size = new Size(180, 34);
            subTitleLabel.TabIndex = 0;
            subTitleLabel.Text = "Manage Users";
            // 
            // Username
            // 
            Username.AllowPromptAsInput = true;
            Username.AnimateReadOnly = false;
            Username.AsciiOnly = false;
            Username.BackgroundImageLayout = ImageLayout.None;
            Username.BeepOnError = false;
            Username.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            Username.Depth = 0;
            Username.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Username.HidePromptOnLeave = false;
            Username.HideSelection = true;
            Username.Hint = "Username";
            Username.InsertKeyMode = InsertKeyMode.Default;
            Username.LeadingIcon = null;
            Username.Location = new Point(37, 145);
            Username.Mask = "";
            Username.MaxLength = 32767;
            Username.MouseState = MaterialSkin.MouseState.OUT;
            Username.Name = "Username";
            Username.PasswordChar = '\0';
            Username.PrefixSuffixText = null;
            Username.PromptChar = '_';
            Username.ReadOnly = false;
            Username.RejectInputOnFirstFailure = false;
            Username.ResetOnPrompt = true;
            Username.ResetOnSpace = true;
            Username.RightToLeft = RightToLeft.No;
            Username.SelectedText = "";
            Username.SelectionLength = 0;
            Username.SelectionStart = 0;
            Username.ShortcutsEnabled = true;
            Username.Size = new Size(218, 48);
            Username.SkipLiterals = true;
            Username.TabIndex = 1;
            Username.TabStop = false;
            Username.TextAlign = HorizontalAlignment.Left;
            Username.TextMaskFormat = MaskFormat.IncludeLiterals;
            Username.TrailingIcon = null;
            Username.UseSystemPasswordChar = false;
            Username.ValidatingType = null;
            // 
            // FullName
            // 
            FullName.AllowPromptAsInput = true;
            FullName.AnimateReadOnly = false;
            FullName.AsciiOnly = false;
            FullName.BackgroundImageLayout = ImageLayout.None;
            FullName.BeepOnError = false;
            FullName.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            FullName.Depth = 0;
            FullName.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FullName.HidePromptOnLeave = false;
            FullName.HideSelection = true;
            FullName.Hint = "Full name";
            FullName.InsertKeyMode = InsertKeyMode.Default;
            FullName.LeadingIcon = null;
            FullName.Location = new Point(37, 199);
            FullName.Mask = "";
            FullName.MaxLength = 32767;
            FullName.MouseState = MaterialSkin.MouseState.OUT;
            FullName.Name = "FullName";
            FullName.PasswordChar = '\0';
            FullName.PrefixSuffixText = null;
            FullName.PromptChar = '_';
            FullName.ReadOnly = false;
            FullName.RejectInputOnFirstFailure = false;
            FullName.ResetOnPrompt = true;
            FullName.ResetOnSpace = true;
            FullName.RightToLeft = RightToLeft.No;
            FullName.SelectedText = "";
            FullName.SelectionLength = 0;
            FullName.SelectionStart = 0;
            FullName.ShortcutsEnabled = true;
            FullName.Size = new Size(218, 48);
            FullName.SkipLiterals = true;
            FullName.TabIndex = 2;
            FullName.TabStop = false;
            FullName.TextAlign = HorizontalAlignment.Left;
            FullName.TextMaskFormat = MaskFormat.IncludeLiterals;
            FullName.TrailingIcon = null;
            FullName.UseSystemPasswordChar = false;
            FullName.ValidatingType = null;
            // 
            // Password
            // 
            Password.AllowPromptAsInput = true;
            Password.AnimateReadOnly = false;
            Password.AsciiOnly = false;
            Password.BackgroundImageLayout = ImageLayout.None;
            Password.BeepOnError = false;
            Password.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            Password.Depth = 0;
            Password.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Password.HidePromptOnLeave = false;
            Password.HideSelection = true;
            Password.Hint = "Password";
            Password.InsertKeyMode = InsertKeyMode.Default;
            Password.LeadingIcon = null;
            Password.Location = new Point(37, 253);
            Password.Mask = "";
            Password.MaxLength = 32767;
            Password.MouseState = MaterialSkin.MouseState.OUT;
            Password.Name = "Password";
            Password.PasswordChar = '*';
            Password.PrefixSuffixText = null;
            Password.PromptChar = '_';
            Password.ReadOnly = false;
            Password.RejectInputOnFirstFailure = false;
            Password.ResetOnPrompt = true;
            Password.ResetOnSpace = true;
            Password.RightToLeft = RightToLeft.No;
            Password.SelectedText = "";
            Password.SelectionLength = 0;
            Password.SelectionStart = 0;
            Password.ShortcutsEnabled = true;
            Password.Size = new Size(218, 48);
            Password.SkipLiterals = true;
            Password.TabIndex = 3;
            Password.TabStop = false;
            Password.TextAlign = HorizontalAlignment.Left;
            Password.TextMaskFormat = MaskFormat.IncludeLiterals;
            Password.TrailingIcon = null;
            Password.UseSystemPasswordChar = false;
            Password.ValidatingType = null;
            // 
            // Phone
            // 
            Phone.AllowPromptAsInput = true;
            Phone.AnimateReadOnly = false;
            Phone.AsciiOnly = false;
            Phone.BackgroundImageLayout = ImageLayout.None;
            Phone.BeepOnError = false;
            Phone.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            Phone.Depth = 0;
            Phone.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Phone.HidePromptOnLeave = false;
            Phone.HideSelection = true;
            Phone.Hint = "Phone";
            Phone.InsertKeyMode = InsertKeyMode.Default;
            Phone.LeadingIcon = null;
            Phone.Location = new Point(37, 307);
            Phone.Mask = "";
            Phone.MaxLength = 32767;
            Phone.MouseState = MaterialSkin.MouseState.OUT;
            Phone.Name = "Phone";
            Phone.PasswordChar = '\0';
            Phone.PrefixSuffixText = null;
            Phone.PromptChar = '_';
            Phone.ReadOnly = false;
            Phone.RejectInputOnFirstFailure = false;
            Phone.ResetOnPrompt = true;
            Phone.ResetOnSpace = true;
            Phone.RightToLeft = RightToLeft.No;
            Phone.SelectedText = "";
            Phone.SelectionLength = 0;
            Phone.SelectionStart = 0;
            Phone.ShortcutsEnabled = true;
            Phone.Size = new Size(218, 48);
            Phone.SkipLiterals = true;
            Phone.TabIndex = 4;
            Phone.TabStop = false;
            Phone.TextAlign = HorizontalAlignment.Left;
            Phone.TextMaskFormat = MaskFormat.IncludeLiterals;
            Phone.TrailingIcon = null;
            Phone.UseSystemPasswordChar = false;
            Phone.ValidatingType = null;
            // 
            // AddBttn
            // 
            AddBttn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AddBttn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            AddBttn.Depth = 0;
            AddBttn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddBttn.HighEmphasis = true;
            AddBttn.Icon = null;
            AddBttn.Location = new Point(37, 376);
            AddBttn.Margin = new Padding(4, 6, 4, 6);
            AddBttn.MouseState = MaterialSkin.MouseState.HOVER;
            AddBttn.Name = "AddBttn";
            AddBttn.NoAccentTextColor = Color.Empty;
            AddBttn.Size = new Size(64, 36);
            AddBttn.TabIndex = 5;
            AddBttn.Text = "Add";
            AddBttn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            AddBttn.UseAccentColor = false;
            AddBttn.UseVisualStyleBackColor = true;
            AddBttn.Click += AddBttn_Click;
            // 
            // EditBttn
            // 
            EditBttn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            EditBttn.BackColor = Color.FromArgb(255, 128, 0);
            EditBttn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            EditBttn.Depth = 0;
            EditBttn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditBttn.HighEmphasis = true;
            EditBttn.Icon = null;
            EditBttn.Location = new Point(109, 376);
            EditBttn.Margin = new Padding(4, 6, 4, 6);
            EditBttn.MouseState = MaterialSkin.MouseState.HOVER;
            EditBttn.Name = "EditBttn";
            EditBttn.NoAccentTextColor = Color.Empty;
            EditBttn.Size = new Size(64, 36);
            EditBttn.TabIndex = 6;
            EditBttn.Text = "Edit";
            EditBttn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            EditBttn.UseAccentColor = false;
            EditBttn.UseVisualStyleBackColor = false;
            EditBttn.Click += EditBttn_Click;
            // 
            // DeleteBttn
            // 
            DeleteBttn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            DeleteBttn.BackColor = Color.FromArgb(255, 128, 0);
            DeleteBttn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            DeleteBttn.Depth = 0;
            DeleteBttn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteBttn.HighEmphasis = true;
            DeleteBttn.Icon = null;
            DeleteBttn.Location = new Point(181, 376);
            DeleteBttn.Margin = new Padding(4, 6, 4, 6);
            DeleteBttn.MouseState = MaterialSkin.MouseState.HOVER;
            DeleteBttn.Name = "DeleteBttn";
            DeleteBttn.NoAccentTextColor = Color.Empty;
            DeleteBttn.Size = new Size(73, 36);
            DeleteBttn.TabIndex = 7;
            DeleteBttn.Text = "Delete";
            DeleteBttn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            DeleteBttn.UseAccentColor = true;
            DeleteBttn.UseVisualStyleBackColor = false;
            DeleteBttn.Click += DeleteBttn_Click;
            // 
            // HomeBttn
            // 
            HomeBttn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            HomeBttn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            HomeBttn.Depth = 0;
            HomeBttn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HomeBttn.HighEmphasis = true;
            HomeBttn.Icon = null;
            HomeBttn.Location = new Point(752, 417);
            HomeBttn.Margin = new Padding(4, 6, 4, 6);
            HomeBttn.MouseState = MaterialSkin.MouseState.HOVER;
            HomeBttn.Name = "HomeBttn";
            HomeBttn.NoAccentTextColor = Color.Empty;
            HomeBttn.Size = new Size(64, 36);
            HomeBttn.TabIndex = 8;
            HomeBttn.Text = "Home";
            HomeBttn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            HomeBttn.UseAccentColor = false;
            HomeBttn.UseVisualStyleBackColor = true;
            HomeBttn.Click += HomeBttn_Click;
            // 
            // UserDGV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            UserDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            UserDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            UserDGV.ColumnHeadersHeight = 4;
            UserDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            UserDGV.DefaultCellStyle = dataGridViewCellStyle3;
            UserDGV.GridColor = Color.FromArgb(231, 229, 255);
            UserDGV.Location = new Point(294, 171);
            UserDGV.Name = "UserDGV";
            UserDGV.RowHeadersVisible = false;
            UserDGV.RowTemplate.Height = 30;
            UserDGV.Size = new Size(522, 213);
            UserDGV.TabIndex = 9;
            UserDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            UserDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            UserDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            UserDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            UserDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            UserDGV.ThemeStyle.BackColor = Color.White;
            UserDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            UserDGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            UserDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            UserDGV.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            UserDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            UserDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            UserDGV.ThemeStyle.HeaderStyle.Height = 4;
            UserDGV.ThemeStyle.ReadOnly = false;
            UserDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            UserDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            UserDGV.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            UserDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            UserDGV.ThemeStyle.RowsStyle.Height = 30;
            UserDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            UserDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            UserDGV.CellContentClick += UserDGV_CellContentClick;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.Crimson;
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Dock = DockStyle.Bottom;
            guna2Panel1.Location = new Point(0, 462);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(850, 28);
            guna2Panel1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(490, 131);
            label1.Name = "label1";
            label1.Size = new Size(114, 34);
            label1.TabIndex = 3;
            label1.Text = "User List";
            // 
            // ManageUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 490);
            Controls.Add(label1);
            Controls.Add(guna2Panel1);
            Controls.Add(UserDGV);
            Controls.Add(HomeBttn);
            Controls.Add(DeleteBttn);
            Controls.Add(EditBttn);
            Controls.Add(AddBttn);
            Controls.Add(Phone);
            Controls.Add(Password);
            Controls.Add(FullName);
            Controls.Add(Username);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ManageUsers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageUsers";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UserDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private System.Windows.Forms.Label MainTitleLabel;
        private Label subTitleLabel;
        private MaterialSkin.Controls.MaterialMaskedTextBox Username;
        private MaterialSkin.Controls.MaterialMaskedTextBox FullName;
        private MaterialSkin.Controls.MaterialMaskedTextBox Password;
        private MaterialSkin.Controls.MaterialMaskedTextBox Phone;
        private MaterialSkin.Controls.MaterialButton AddBttn;
        private MaterialSkin.Controls.MaterialButton EditBttn;
        private MaterialSkin.Controls.MaterialButton DeleteBttn;
        private MaterialSkin.Controls.MaterialButton HomeBttn;
        private Guna.UI2.WinForms.Guna2DataGridView UserDGV;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label QuitBttn;
        private Label label1;
    }
}