// ReSharper disable once CheckNamespace

using System;
using nManager.Helpful;
using nManager.Plugins;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Deserializers;

public class notification
{
    public string title { get; set; }
    public string body { get; set; }
}

public class RequestObject
{
    public string to { get; set; }
    public notification notification { get; set; }
}

public class Notify
{
    public static bool Died;
    public static bool Deaths;
    public static bool BagSlots;
    public static bool Latency;
    public static bool Stucks;
    public static bool HealthPercent;

    public static int DeathsCount;
    public static int BagSlotsCount;
    public static int LatencyCount;
    public static int StucksCount;
    public static int HealthPercentCount;

    // todo
    public static void getFcmToken()
    {
        Logging.WritePluginDebug("Getting fcm token..", "[Remote Control]");
        var client = new RestClient("http://myurl.com/api/");

        client.ClearHandlers();
        var jsonDeserializer = new JsonDeserializer();
        client.AddHandler("application/json", jsonDeserializer);

        var request = new RestRequest("getCatalog?token=saga001");

        var queryResult = client.Execute(request);

        Console.WriteLine(queryResult);
    }

    public static void send()
    {
        if (Info.IsDead && Died)
        {
            try
            {

                var notifyObject = new RequestObject
                {
                    to = "fcmTokenHere",
                    notification = new notification
                    {
                        title = "Title example",
                        body = "Body example"
                    },
                };

                // todo
                var notifyJson = JsonConvert.SerializeObject(notifyObject);
                //var json = request.JsonSerializer.Serialize(yourobject);

                var client = new RestClient(PrivateSettings.FcmUrl);
                var request = new RestRequest(Method.POST);

                request.AddHeader("Accept", "application/json");
                request.AddHeader("Authorization", "key=" + PrivateSettings.FirebaseApiKey);
                request.Parameters.Clear();
                request.AddParameter("application/json", notifyJson, ParameterType.RequestBody);

                // executed request is here
                var response = client.Execute(request);
                var content = response.Content;
                Logging.WritePluginDebug("Content sent: " + content, "[Remote Control]");
            }
            catch (Exception e)
            {
                Logging.WritePluginError("Something went wrong while sending push notification.", "[Remote Control]");
            }
        }
    }

}