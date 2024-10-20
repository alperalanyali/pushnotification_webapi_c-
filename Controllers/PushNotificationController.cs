using CorePush.Firebase;
using Microsoft.AspNetCore.Mvc;
using pushnotification_webapi.Enums;

namespace pushnotification_webapi.Controllers;

[ApiController]
[Route("[controller]")]
public class PushNotificationController : ControllerBase
{


    [HttpPost]
    [Route("/SendPushNotification")]
    public async Task<string> SendPushNotification(PushNotificationType type,string title,string body)
    {
        var result = await Services.PushNotificationService.SendPushNotificationAsync(type,title,body);
        return result;
    }
}
