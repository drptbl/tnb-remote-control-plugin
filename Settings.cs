using System;

// ReSharper disable once CheckNamespace
public class Settings
{
    public static string Username;
    public static string Password;
    public static bool Authed;
    public static string UserId;
    public static string AccessToken;
    public static DateTime AccessTokenCreated;
    public static string UserEmail;
    public static bool EmailVerified;











    public const bool SendNotifications = true;
    public const bool ExecuteHttpRequests = true;
    public const bool ExecuteHttpRequestsSync = true;
    public const bool DebugSentJSONData = false;
    public const bool SaveJSONDataToFile = false;
    public const bool SendSensitiveData = false;

}