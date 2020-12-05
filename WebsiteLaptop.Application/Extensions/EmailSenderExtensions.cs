using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using WebsiteLaptop.Application.Services;

namespace WebsiteLaptop.Application.Extensions
{
    public static class EmailSenderExtensions
    {
        public static Task SendEmailConfirmationAsync(this IEmailSender emailSender, string email, string link)
        {
            return emailSender.SendEmailAsync(email, "Xác nhận email của bạn",
                $"Cảm ơn bạn đã đăng kí tài khoản tại Website Laptop. Để hoàn tất quá trình đăng kí, hãy nhấn vào link: <a href='{HtmlEncoder.Default.Encode(link)}'>link</a>");
        }
    }
}
