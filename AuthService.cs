using Firebase.Auth;
using nManager.Helpful;

// ReSharper disable once CheckNamespace
public class AuthService
{

    public static readonly FirebaseAuthProvider AuthProvider = new FirebaseAuthProvider(new FirebaseConfig(PrivateSettings.FirebaseApiKey));
    public static FirebaseAuthLink Auth;

    public static void SetDetailsFromAuth()
    {
        Settings.AccessToken = Auth.FirebaseToken;
        Settings.AccessTokenCreated = Auth.Created;
        Settings.UserId = Auth.User.LocalId;
        Settings.UserEmail = Auth.User.Email;
        Settings.EmailVerified = Auth.User.IsEmailVerified;
        Settings.Authed = !Auth.IsExpired();

        Logging.WritePluginDebug("Access token: " + Settings.AccessToken, "[Remote Control]");
        Logging.WritePluginDebug("Token created at: " + Settings.AccessTokenCreated, "[Remote Control]");
        Logging.WritePluginDebug("User id: " + Settings.UserId, "[Remote Control]");
        Logging.WritePluginDebug("User email: " + Settings.UserEmail, "[Remote Control]");
        Logging.WritePluginDebug("User verified: " + Settings.EmailVerified, "[Remote Control]");
        Logging.WritePluginDebug("Authed: " + Settings.Authed, "[Remote Control]");
    }

}