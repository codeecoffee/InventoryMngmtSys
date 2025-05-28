namespace InventoryMngmtSys;

public partial class LoginScreen : Form
{
    public LoginScreen()
    {
        InitializeComponent();
        passwordInput.UseSystemPasswordChar = true; 
    }

    private void showPassCheckbox_CheckedChanged(object sender, EventArgs e)
    {
        if(showPassCheckbox.Checked == true )
        {
            passwordInput.UseSystemPasswordChar = false;
        }
        else
        {
            passwordInput.UseSystemPasswordChar = true;
        }
    }
}