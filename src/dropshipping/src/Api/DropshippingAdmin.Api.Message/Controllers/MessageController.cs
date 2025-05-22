using Microsoft.AspNetCore.Mvc;
using DropshippingAdmin.Core.Contracts;

namespace DropshippingAdmin.Api.Message.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MessageController : ControllerBase
    {
        private readonly IEmailService _emailService;
        private readonly IWhatsAppService _whatsAppService;
        private readonly ITelegramService _telegramService;
        private readonly IPushNotificationService _pushNotificationService;

        public MessageController(
            IEmailService emailService,
            IWhatsAppService whatsAppService,
            ITelegramService telegramService,
            IPushNotificationService pushNotificationService)
        {
            _emailService = emailService;
            _whatsAppService = whatsAppService;
            _telegramService = telegramService;
            _pushNotificationService = pushNotificationService;
        }

        [HttpPost("send-email")]
        public async Task<IActionResult> SendEmail([FromBody] SendEmailRequest request)
        {
            await _emailService.SendEmailAsync(request.To, request.Subject, request.Body);
            return Ok(new { sent = true, type = "email", to = request.To });
        }

        [HttpPost("send-whatsapp")]
        public async Task<IActionResult> SendWhatsApp([FromBody] SendWhatsAppRequest request)
        {
            await _whatsAppService.SendMessageAsync(request.UserId, request.Message);
            return Ok(new { sent = true, type = "whatsapp", userId = request.UserId });
        }

        [HttpPost("send-telegram")]
        public async Task<IActionResult> SendTelegram([FromBody] SendTelegramRequest request)
        {
            await _telegramService.SendMessageAsync(request.ChatId, request.Message);
            return Ok(new { sent = true, type = "telegram", chatId = request.ChatId });
        }

        [HttpPost("send-push")]
        public async Task<IActionResult> SendPush([FromBody] SendPushRequest request)
        {
            await _pushNotificationService.SendPushAsync(request.DeviceToken, request.Title, request.Body);
            return Ok(new { sent = true, type = "push", deviceToken = request.DeviceToken });
        }
    }

    public class SendEmailRequest
    {
        public string To { get; set; } = string.Empty;
        public string Subject { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
    }
    public class SendWhatsAppRequest
    {
        public Guid UserId { get; set; }
        public string Message { get; set; } = string.Empty;
    }
    public class SendTelegramRequest
    {
        public long ChatId { get; set; }
        public string Message { get; set; } = string.Empty;
    }
    public class SendPushRequest
    {
        public string DeviceToken { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
    }
}
