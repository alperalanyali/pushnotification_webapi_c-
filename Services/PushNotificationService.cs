using pushnotification_webapi.Enums;


namespace pushnotification_webapi.Services;

public class PushNotificationService{

    public static async Task<string> SendPushNotificationAsync(PushNotificationType type,string title,string body){
            
            string result = "";

            try{
                var apiKey = "YOUR_FIREBASE_API_KEY";
        var fcmEndpoint = "https://fcm.googleapis.com/fcm/send";

        // Push bildirim oluşturun
        var notification = new FcmNotification
        {
            Title = "Başlık",
            Body = "Bildirim İçeriği"
        };

        // Alıcı cihazın FCM token'ı
        var deviceToken = "ALICI_CIHAZIN_FCM_TOKENI";

        // Push bildirimi gönder
        try
        {
            var sender = new FcmSender(apiKey, fcmEndpoint);
            var response = sender.SendAsync(deviceToken, notification).Result;

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Push bildirimi başarıyla gönderildi.");
            }
            else
            {
                Console.WriteLine("Push bildirimi gönderirken hata oluştu. HTTP Durumu: " + response.StatusCode);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Push bildirimi gönderirken bir hata oluştu: " + ex.Message);
        }

            }catch(Exception ex){
                Console.WriteLine(ex);
            }

            return result;
    }
}