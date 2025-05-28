namespace InventoryMngmtSys;

partial class LoginScreen
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
        panel1 = new Panel();
        showPassCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
        loginButton = new MaterialSkin.Controls.MaterialButton();
        passwordInput = new MaterialSkin.Controls.MaterialMaskedTextBox();
        userName = new MaterialSkin.Controls.MaterialMaskedTextBox();
        loginLabel = new Label();
        label2 = new Label();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = SystemColors.ActiveCaption;
        panel1.Controls.Add(showPassCheckbox);
        panel1.Controls.Add(loginButton);
        panel1.Controls.Add(passwordInput);
        panel1.Controls.Add(userName);
        panel1.Controls.Add(loginLabel);
        panel1.Location = new Point(143, 74);
        panel1.Name = "panel1";
        panel1.Size = new Size(242, 332);
        panel1.TabIndex = 0;
        // 
        // showPassCheckbox
        // 
        showPassCheckbox.AutoSize = true;
        showPassCheckbox.Depth = 0;
        showPassCheckbox.Font = new Font("SimSun", 4.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        showPassCheckbox.Location = new Point(30, 221);
        showPassCheckbox.Margin = new Padding(0);
        showPassCheckbox.MouseLocation = new Point(-1, -1);
        showPassCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
        showPassCheckbox.Name = "showPassCheckbox";
        showPassCheckbox.ReadOnly = false;
        showPassCheckbox.Ripple = true;
        showPassCheckbox.Size = new Size(149, 37);
        showPassCheckbox.TabIndex = 4;
        showPassCheckbox.Text = "Show Password";
        showPassCheckbox.UseVisualStyleBackColor = true;
        showPassCheckbox.CheckedChanged += showPassCheckbox_CheckedChanged;
        // 
        // loginButton
        // 
        loginButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        loginButton.Cursor = Cursors.Hand;
        loginButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
        loginButton.Depth = 0;
        loginButton.HighEmphasis = true;
        loginButton.Icon = null;
        loginButton.Location = new Point(93, 276);
        loginButton.Margin = new Padding(4, 6, 4, 6);
        loginButton.MouseState = MaterialSkin.MouseState.HOVER;
        loginButton.Name = "loginButton";
        loginButton.NoAccentTextColor = Color.Empty;
        loginButton.Size = new Size(64, 36);
        loginButton.TabIndex = 3;
        loginButton.Text = "Login";
        loginButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
        loginButton.UseAccentColor = false;
        loginButton.UseVisualStyleBackColor = true;
        // 
        // passwordInput
        // 
        passwordInput.AllowPromptAsInput = true;
        passwordInput.AnimateReadOnly = false;
        passwordInput.AsciiOnly = false;
        passwordInput.BackgroundImageLayout = ImageLayout.None;
        passwordInput.BeepOnError = false;
        passwordInput.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
        passwordInput.Depth = 0;
        passwordInput.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
        passwordInput.HelperText = "Password";
        passwordInput.HidePromptOnLeave = false;
        passwordInput.HideSelection = true;
        passwordInput.Hint = "Password";
        passwordInput.InsertKeyMode = InsertKeyMode.Default;
        passwordInput.LeadingIcon = null;
        passwordInput.Location = new Point(30, 170);
        passwordInput.Mask = "";
        passwordInput.MaxLength = 32767;
        passwordInput.MouseState = MaterialSkin.MouseState.OUT;
        passwordInput.Name = "passwordInput";
        passwordInput.PasswordChar = '\0';
        passwordInput.PrefixSuffixText = null;
        passwordInput.PromptChar = '_';
        passwordInput.ReadOnly = false;
        passwordInput.RejectInputOnFirstFailure = false;
        passwordInput.ResetOnPrompt = true;
        passwordInput.ResetOnSpace = true;
        passwordInput.RightToLeft = RightToLeft.No;
        passwordInput.SelectedText = "";
        passwordInput.SelectionLength = 0;
        passwordInput.SelectionStart = 0;
        passwordInput.ShortcutsEnabled = true;
        passwordInput.Size = new Size(185, 48);
        passwordInput.SkipLiterals = true;
        passwordInput.TabIndex = 2;
        passwordInput.TabStop = false;
        passwordInput.TextAlign = HorizontalAlignment.Left;
        passwordInput.TextMaskFormat = MaskFormat.IncludeLiterals;
        passwordInput.TrailingIcon = null;
        passwordInput.UseSystemPasswordChar = false;
        passwordInput.ValidatingType = null;
        // 
        // userName
        // 
        userName.AllowPromptAsInput = false;
        userName.AnimateReadOnly = false;
        userName.AsciiOnly = false;
        userName.BackgroundImageLayout = ImageLayout.None;
        userName.BeepOnError = false;
        userName.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
        userName.Depth = 0;
        userName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
        userName.HelperText = "Username";
        userName.HidePromptOnLeave = false;
        userName.HideSelection = true;
        userName.Hint = "Username";
        userName.InsertKeyMode = InsertKeyMode.Default;
        userName.LeadingIcon = null;
        userName.Location = new Point(30, 104);
        userName.Mask = "";
        userName.MaxLength = 32767;
        userName.MouseState = MaterialSkin.MouseState.OUT;
        userName.Name = "userName";
        userName.PasswordChar = '\0';
        userName.PrefixSuffixText = null;
        userName.PromptChar = '_';
        userName.ReadOnly = false;
        userName.RejectInputOnFirstFailure = false;
        userName.ResetOnPrompt = true;
        userName.ResetOnSpace = true;
        userName.RightToLeft = RightToLeft.No;
        userName.SelectedText = "";
        userName.SelectionLength = 0;
        userName.SelectionStart = 0;
        userName.ShortcutsEnabled = true;
        userName.Size = new Size(185, 48);
        userName.SkipLiterals = true;
        userName.TabIndex = 1;
        userName.TabStop = false;
        userName.TextAlign = HorizontalAlignment.Left;
        userName.TextMaskFormat = MaskFormat.IncludeLiterals;
        userName.TrailingIcon = null;
        userName.UseSystemPasswordChar = false;
        userName.ValidatingType = null;
        // 
        // loginLabel
        // 
        loginLabel.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        loginLabel.ForeColor = Color.White;
        loginLabel.Location = new Point(70, 25);
        loginLabel.Name = "loginLabel";
        loginLabel.Size = new Size(100, 51);
        loginLabel.TabIndex = 0;
        loginLabel.Text = "Login";
        loginLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label2
        // 
        label2.BackColor = Color.Transparent;
        label2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label2.ForeColor = Color.White;
        label2.Location = new Point(51, 20);
        label2.Name = "label2";
        label2.Size = new Size(424, 51);
        label2.TabIndex = 2;
        label2.Text = "Inventory Management System";
        label2.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // LoginScreen
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
        BackgroundImageLayout = ImageLayout.Stretch;
        ClientSize = new Size(512, 463);
        Controls.Add(label2);
        Controls.Add(panel1);
        FormBorderStyle = FormBorderStyle.None;
        Name = "LoginScreen";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Form1";
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label loginLabel;

    private System.Windows.Forms.Panel panel1;

    #endregion

    private MaterialSkin.Controls.MaterialMaskedTextBox userName;
    private MaterialSkin.Controls.MaterialMaskedTextBox passwordInput;
    private MaterialSkin.Controls.MaterialButton loginButton;
    private MaterialSkin.Controls.MaterialCheckbox showPassCheckbox;
}