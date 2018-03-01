/*
 * User: drptbl
 * Date: 2017-01-14
 * Time: 22:53
 */

using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;

using RestSharp;

using nManager.Helpful;
using nManager.Plugins;

#region Interface

// ReSharper disable once CheckNamespace
public class Main : IPlugins
{
    private bool _checkFieldRunning;

    public bool Loop
    {
        get { return RemoteControl.InternalLoop; }
        set { RemoteControl.InternalLoop = value; }
    }

    public string Name => RemoteControl.Name;

    public string Author => RemoteControl.Author;

    public string Description => RemoteControl.Description;

    public string TargetVersion => RemoteControl.TargetVersion;

    public string Version => RemoteControl.Version;

    public bool IsStarted => Loop && !_checkFieldRunning;

    public void Dispose()
    {
        Loop = false;
    }

    public void Initialize()
    {
        Logging.WriteDebug($"{Name} is loading.");
        Initialize(false);
    }

    public void ShowConfiguration()
    {
        Logging.WriteDebug($"{Name} settings opened.");
        RemoteControl.ShowConfiguration();
    }

    public void ResetConfiguration()
    {
        // If you have a configuration form, please create/call RemoteControl.ResetConfiguration();
        Logging.WriteDebug($"{Name} doesn't support reset configuration yet.");
        MessageBox.Show($"{Name} doesn't support reset configuration yet.");
    }

    public void CheckFields()
    {
        _checkFieldRunning = true;
        Loop = true;
        while (Loop)
        {
            Thread.Sleep(1000);
        }
    }

    private void Initialize(bool configOnly, bool resetSettings = false)
    {
        try
        {
            if (!configOnly && !resetSettings)
                Loop = true;
            RemoteControl.Init();
        }
        catch (Exception e)
        {
            Logging.WriteError("IPlugins.Main.Initialize(bool configOnly, bool resetSettings = false): " + e);
        }
        Logging.WriteDebug($"{Name} has stopped.");
    }
}

#endregion

#region Plugin

public static class RemoteControl
{
    public static bool InternalLoop = true;
    public const string Author = "drptbl";
    public const string Name = "Remote Control";
    public const string TargetVersion = "6.4.x";
    public const string Version = "0.0.4";
    public const string Description = "Plugin used for saving character and bot details to *.json file which can be processed further.";

    public static void Init()
    {
        if (Settings.Authed)
        {
            MainLoop();
        }
    }

    private static void MainLoop()
    {

        while (InternalLoop)
        {
            var info = new Info();

            Logging.WritePlugin("Monitoring..", "[Remote Control]");

            var infoJson = JsonConvert.SerializeObject(info);

            if (Settings.SendNotifications)
            {
                Notify.send();
            }

            if (Settings.DebugSentJSONData)
            {
                Logging.WritePluginDebug("JSON data sent: '" + infoJson, "[Remote Control]");
            }

            if (Settings.SaveJSONDataToFile)
            {
                File.WriteAllText("info.json", infoJson);
                Logging.WritePluginDebug("Data saved to info.json file.", "[Remote Control]");
            }

            if (Settings.ExecuteHttpRequests)
            {
                if (AuthService.Auth.IsExpired())
                {
                    try
                    {
                        Logging.WritePluginDebug("Token expired, refreshing..", "[Remote Control]");
                        AuthService.Auth = AuthService.Auth.GetFreshAuthAsync().Result;
                        AuthService.SetDetailsFromAuth();
                    }
                    catch (Exception e)
                    {
                        Logging.WritePluginError("Something went wrong while refreshing access token.", "[Remote Control]");
                    }
                }
                else
                {
                    try
                    {
                        var client = new RestClient(PrivateSettings.FirebaseUrl);
                        var request = new RestRequest("users/" + Settings.UserId + "/characterData.json?auth=" + Settings.AccessToken,
                            Method.PUT);

                        request.AddHeader("Accept", "application/json");
                        request.Parameters.Clear();
                        request.AddParameter("application/json", infoJson, ParameterType.RequestBody);

                        if (Settings.ExecuteHttpRequestsSync)
                        {
                            var response = client.Execute(request);
                            var content = response.Content;
                            // Logging.WritePluginDebug("Content sent: " + content, "[Remote Control]");
                        }
                        else
                        {
                            client.ExecuteAsync(request, response =>
                            {
                                var content = response.Content;
                                Logging.WritePluginDebug("Content sent: " + content, "[Remote Control]");
                            });
                        }
                    }
                    catch (Exception e)
                    {
                        Logging.WritePluginError("Something went wrong while sending data to server.", "[Remote Control]");
                    }

                }
            }

            Thread.Sleep(PrivateSettings.SendJSONDataDelay);

        }
    }

    public static void ShowConfiguration()
    {
        var LoginForm = new LoginForm();
        LoginForm.ShowDialog();
    }

}

#endregion