using System;
using System.Windows.Forms;
using nManager.Helpful;

using System.Threading.Tasks;
using Firebase.Auth;

public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
    }

    private void LoginForm_Load(object sender, EventArgs e)
    {
        Logging.WritePluginDebug("Login form loaded", "[Remote Control]");
        GoToMainFormIfAuthed();
    }

    private async void LoginButton_Click(object sender, EventArgs e)
    {
        if (EmailBox.Text == "" || PasswordBox.Text == "")
        {
            MessageBox.Show("Please provide valid e-mail and password.");
            Logging.WritePluginDebug("Please provide valid e-mail and password.", "[Remote Control]");
            return;
        }

        try
        {
            // consider moving username and password to SetDetailsFromAuth
            Settings.Username = EmailBox.Text;
            Settings.Password = PasswordBox.Text;

            AuthService.Auth = await Task.Run(
                () => AuthService.AuthProvider.SignInWithEmailAndPasswordAsync(EmailBox.Text, PasswordBox.Text).Result);

            AuthService.SetDetailsFromAuth();

            if (Settings.Authed)
            {
                MessageBox.Show("Login successful!");
                Hide();
                MainForm MainForm = new MainForm();
                MainForm.Show();
                Logging.WritePluginDebug("User authenticated with success, showing main form.", "[Remote Control]");
            }
            else
            {
                MessageBox.Show("Login failed.");
                Logging.WritePluginError("Login failed.", "[Remote Control]");
            }
        }
        catch (Exception ex)
        {
            var fbEx = (FirebaseAuthException)ex.InnerException;

            if (fbEx != null && fbEx.Reason == AuthErrorReason.InvalidEmailAddress)
            {
                MessageBox.Show("Invalid e-mail address.");
                Logging.WritePluginError("Invalid e-mail address.", "[Remote Control]");
            }
            if (fbEx != null && fbEx.Reason == AuthErrorReason.UnknownEmailAddress)
            {
                MessageBox.Show("Account doesn't exist.");
                Logging.WritePluginError("Account doesn't exist.", "[Remote Control]");
            }
            if (fbEx != null && fbEx.Reason == AuthErrorReason.UserDisabled)
            {
                MessageBox.Show("Account is disabled. Renew your subscription.");
                Logging.WritePluginError("Account is disabled. Renew your subscription.", "[Remote Control]");
            }
            if (fbEx != null && fbEx.Reason == AuthErrorReason.WrongPassword)
            {
                MessageBox.Show("Wrong password.");
                Logging.WritePluginError("Wrong password.", "[Remote Control]");
            }
            // else is missing here because other exceptions are swallowed on purpose..
        }
    }

    private void GoToMainFormIfAuthed()
    {
        if (Settings.Authed)
        {
            BeginInvoke(new MethodInvoker(Hide));
            MainForm MainForm = new MainForm();
            MainForm.Show();
            Logging.WritePluginDebug("Already logged in, showing main form..", "[Remote Control]");
        }
    }

}


