namespace InventoryMngmtSys
{
    partial class ManageCustomers
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            QuitBttn = new Label();
            MainTitleLabel = new Label();
            subTitleLabel = new Label();
            label1 = new Label();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            CustomerDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            HomeBttn = new MaterialSkin.Controls.MaterialButton();
            DeleteBttn = new MaterialSkin.Controls.MaterialButton();
            EditBttn = new MaterialSkin.Controls.MaterialButton();
            AddBttn = new MaterialSkin.Controls.MaterialButton();
            CustomerNameTb = new MaterialSkin.Controls.MaterialMaskedTextBox();
            CustomerId = new MaterialSkin.Controls.MaterialMaskedTextBox();
            CustomerPhoneTb = new MaterialSkin.Controls.MaterialMaskedTextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomerDGV).BeginInit();
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
            panel1.TabIndex = 11;
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
            // 
            // MainTitleLabel
            // 
            MainTitleLabel.AutoSize = true;
            MainTitleLabel.Font = new Font("Franklin Gothic Medium", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MainTitleLabel.ForeColor = Color.White;
            MainTitleLabel.Location = new Point(181, 9);
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
            subTitleLabel.Location = new Point(281, 60);
            subTitleLabel.Name = "subTitleLabel";
            subTitleLabel.Size = new Size(242, 34);
            subTitleLabel.TabIndex = 0;
            subTitleLabel.Text = "Manage Customers";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(444, 117);
            label1.Name = "label1";
            label1.Size = new Size(176, 34);
            label1.TabIndex = 14;
            label1.Text = "Customer List";
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
            guna2Panel1.TabIndex = 22;
            // 
            // CustomerDGV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            CustomerDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            CustomerDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            CustomerDGV.ColumnHeadersHeight = 4;
            CustomerDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            CustomerDGV.DefaultCellStyle = dataGridViewCellStyle3;
            CustomerDGV.GridColor = Color.FromArgb(231, 229, 255);
            CustomerDGV.Location = new Point(294, 171);
            CustomerDGV.Name = "CustomerDGV";
            CustomerDGV.RowHeadersVisible = false;
            CustomerDGV.RowTemplate.Height = 30;
            CustomerDGV.Size = new Size(522, 237);
            CustomerDGV.TabIndex = 21;
            CustomerDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            CustomerDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            CustomerDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            CustomerDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            CustomerDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            CustomerDGV.ThemeStyle.BackColor = Color.White;
            CustomerDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            CustomerDGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            CustomerDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            CustomerDGV.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            CustomerDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            CustomerDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            CustomerDGV.ThemeStyle.HeaderStyle.Height = 4;
            CustomerDGV.ThemeStyle.ReadOnly = false;
            CustomerDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            CustomerDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            CustomerDGV.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            CustomerDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            CustomerDGV.ThemeStyle.RowsStyle.Height = 30;
            CustomerDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            CustomerDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
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
            HomeBttn.TabIndex = 20;
            HomeBttn.Text = "Home";
            HomeBttn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            HomeBttn.UseAccentColor = false;
            HomeBttn.UseVisualStyleBackColor = true;
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
            DeleteBttn.TabIndex = 19;
            DeleteBttn.Text = "Delete";
            DeleteBttn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            DeleteBttn.UseAccentColor = true;
            DeleteBttn.UseVisualStyleBackColor = false;
            DeleteBttn.Click += DeleteBttn_Click;
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
            EditBttn.TabIndex = 18;
            EditBttn.Text = "Edit";
            EditBttn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            EditBttn.UseAccentColor = false;
            EditBttn.UseVisualStyleBackColor = false;
            EditBttn.Click += EditBttn_Click;
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
            AddBttn.TabIndex = 17;
            AddBttn.Text = "Add";
            AddBttn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            AddBttn.UseAccentColor = false;
            AddBttn.UseVisualStyleBackColor = true;
            AddBttn.Click += AddBttn_Click;
            // 
            // CustomerNameTb
            // 
            CustomerNameTb.AllowPromptAsInput = true;
            CustomerNameTb.AnimateReadOnly = false;
            CustomerNameTb.AsciiOnly = false;
            CustomerNameTb.BackgroundImageLayout = ImageLayout.None;
            CustomerNameTb.BeepOnError = false;
            CustomerNameTb.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            CustomerNameTb.Depth = 0;
            CustomerNameTb.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CustomerNameTb.HidePromptOnLeave = false;
            CustomerNameTb.HideSelection = true;
            CustomerNameTb.Hint = "Customer Name";
            CustomerNameTb.InsertKeyMode = InsertKeyMode.Default;
            CustomerNameTb.LeadingIcon = null;
            CustomerNameTb.Location = new Point(37, 199);
            CustomerNameTb.Mask = "";
            CustomerNameTb.MaxLength = 32767;
            CustomerNameTb.MouseState = MaterialSkin.MouseState.OUT;
            CustomerNameTb.Name = "CustomerNameTb";
            CustomerNameTb.PasswordChar = '\0';
            CustomerNameTb.PrefixSuffixText = null;
            CustomerNameTb.PromptChar = '_';
            CustomerNameTb.ReadOnly = false;
            CustomerNameTb.RejectInputOnFirstFailure = false;
            CustomerNameTb.ResetOnPrompt = true;
            CustomerNameTb.ResetOnSpace = true;
            CustomerNameTb.RightToLeft = RightToLeft.No;
            CustomerNameTb.SelectedText = "";
            CustomerNameTb.SelectionLength = 0;
            CustomerNameTb.SelectionStart = 0;
            CustomerNameTb.ShortcutsEnabled = true;
            CustomerNameTb.Size = new Size(218, 48);
            CustomerNameTb.SkipLiterals = true;
            CustomerNameTb.TabIndex = 13;
            CustomerNameTb.TabStop = false;
            CustomerNameTb.TextAlign = HorizontalAlignment.Left;
            CustomerNameTb.TextMaskFormat = MaskFormat.IncludeLiterals;
            CustomerNameTb.TrailingIcon = null;
            CustomerNameTb.UseSystemPasswordChar = false;
            CustomerNameTb.ValidatingType = null;
            // 
            // CustomerId
            // 
            CustomerId.AllowPromptAsInput = true;
            CustomerId.AnimateReadOnly = false;
            CustomerId.AsciiOnly = false;
            CustomerId.BackgroundImageLayout = ImageLayout.None;
            CustomerId.BeepOnError = false;
            CustomerId.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            CustomerId.Depth = 0;
            CustomerId.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CustomerId.HidePromptOnLeave = false;
            CustomerId.HideSelection = true;
            CustomerId.Hint = "Customer ID";
            CustomerId.InsertKeyMode = InsertKeyMode.Default;
            CustomerId.LeadingIcon = null;
            CustomerId.Location = new Point(37, 145);
            CustomerId.Mask = "";
            CustomerId.MaxLength = 32767;
            CustomerId.MouseState = MaterialSkin.MouseState.OUT;
            CustomerId.Name = "CustomerId";
            CustomerId.PasswordChar = '\0';
            CustomerId.PrefixSuffixText = null;
            CustomerId.PromptChar = '_';
            CustomerId.ReadOnly = false;
            CustomerId.RejectInputOnFirstFailure = false;
            CustomerId.ResetOnPrompt = true;
            CustomerId.ResetOnSpace = true;
            CustomerId.RightToLeft = RightToLeft.No;
            CustomerId.SelectedText = "";
            CustomerId.SelectionLength = 0;
            CustomerId.SelectionStart = 0;
            CustomerId.ShortcutsEnabled = true;
            CustomerId.Size = new Size(218, 48);
            CustomerId.SkipLiterals = true;
            CustomerId.TabIndex = 12;
            CustomerId.TabStop = false;
            CustomerId.TextAlign = HorizontalAlignment.Left;
            CustomerId.TextMaskFormat = MaskFormat.IncludeLiterals;
            CustomerId.TrailingIcon = null;
            CustomerId.UseSystemPasswordChar = false;
            CustomerId.ValidatingType = null;
            // 
            // CustomerPhoneTb
            // 
            CustomerPhoneTb.AllowPromptAsInput = true;
            CustomerPhoneTb.AnimateReadOnly = false;
            CustomerPhoneTb.AsciiOnly = false;
            CustomerPhoneTb.BackgroundImageLayout = ImageLayout.None;
            CustomerPhoneTb.BeepOnError = false;
            CustomerPhoneTb.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            CustomerPhoneTb.Depth = 0;
            CustomerPhoneTb.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CustomerPhoneTb.HidePromptOnLeave = false;
            CustomerPhoneTb.HideSelection = true;
            CustomerPhoneTb.Hint = "Customer Phone";
            CustomerPhoneTb.InsertKeyMode = InsertKeyMode.Default;
            CustomerPhoneTb.LeadingIcon = null;
            CustomerPhoneTb.Location = new Point(37, 253);
            CustomerPhoneTb.Mask = "";
            CustomerPhoneTb.MaxLength = 32767;
            CustomerPhoneTb.MouseState = MaterialSkin.MouseState.OUT;
            CustomerPhoneTb.Name = "CustomerPhoneTb";
            CustomerPhoneTb.PasswordChar = '\0';
            CustomerPhoneTb.PrefixSuffixText = null;
            CustomerPhoneTb.PromptChar = '_';
            CustomerPhoneTb.ReadOnly = false;
            CustomerPhoneTb.RejectInputOnFirstFailure = false;
            CustomerPhoneTb.ResetOnPrompt = true;
            CustomerPhoneTb.ResetOnSpace = true;
            CustomerPhoneTb.RightToLeft = RightToLeft.No;
            CustomerPhoneTb.SelectedText = "";
            CustomerPhoneTb.SelectionLength = 0;
            CustomerPhoneTb.SelectionStart = 0;
            CustomerPhoneTb.ShortcutsEnabled = true;
            CustomerPhoneTb.Size = new Size(218, 48);
            CustomerPhoneTb.SkipLiterals = true;
            CustomerPhoneTb.TabIndex = 15;
            CustomerPhoneTb.TabStop = false;
            CustomerPhoneTb.TextAlign = HorizontalAlignment.Left;
            CustomerPhoneTb.TextMaskFormat = MaskFormat.IncludeLiterals;
            CustomerPhoneTb.TrailingIcon = null;
            CustomerPhoneTb.UseSystemPasswordChar = false;
            CustomerPhoneTb.ValidatingType = null;
            // 
            // ManageCustomers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 490);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(guna2Panel1);
            Controls.Add(CustomerDGV);
            Controls.Add(HomeBttn);
            Controls.Add(DeleteBttn);
            Controls.Add(EditBttn);
            Controls.Add(AddBttn);
            Controls.Add(CustomerPhoneTb);
            Controls.Add(CustomerNameTb);
            Controls.Add(CustomerId);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageCustomers";
            Text = "ManageCustomers";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CustomerDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label QuitBttn;
        private Label MainTitleLabel;
        private Label subTitleLabel;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView CustomerDGV;
        private MaterialSkin.Controls.MaterialButton HomeBttn;
        private MaterialSkin.Controls.MaterialButton DeleteBttn;
        private MaterialSkin.Controls.MaterialButton EditBttn;
        private MaterialSkin.Controls.MaterialButton AddBttn;
        private MaterialSkin.Controls.MaterialMaskedTextBox Phone;
        private MaterialSkin.Controls.MaterialMaskedTextBox Password;
        private MaterialSkin.Controls.MaterialMaskedTextBox CustomerNameTb;
        private MaterialSkin.Controls.MaterialMaskedTextBox CustomerId;
        private MaterialSkin.Controls.MaterialMaskedTextBox CustomerPhoneTb;
    }
}