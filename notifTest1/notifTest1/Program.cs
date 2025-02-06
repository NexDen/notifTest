using System.Collections.Generic;
using System.Diagnostics;
using OneSignalApi.Api;
using OneSignalApi.Client;
using OneSignalApi.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {
            var appConfig = new Configuration();
            appConfig.BasePath = "https://api.onesignal.com";
            appConfig.AccessToken = "os_v2_app_yheoof2scvdp3gyiz34r6vlvd2vfmosjdy4ux5nq23pljzygokrdbifra4f56q3kuemxqxpdadrmbje3czsnkcclv7pxr3wg3kz5hwq";
            
            var apiInstance = new DefaultApi(appConfig);
            
            var appId = "c1c8e717-5215-46fd-9b08-cef91f55751e";  // string | 
            
            var notification = new Notification(appId: appId, includedSegments: ["Total Subscriptions"], contents: new StringMap("Test Bildirimi"));
            try
            {
                CreateNotificationSuccessResponse result = apiInstance.CreateNotification(notification);
                Console.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Console.WriteLine("Exception when calling DefaultApi.CreateNotification: " + e.Message );
                Console.WriteLine("Status Code: "+ e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}