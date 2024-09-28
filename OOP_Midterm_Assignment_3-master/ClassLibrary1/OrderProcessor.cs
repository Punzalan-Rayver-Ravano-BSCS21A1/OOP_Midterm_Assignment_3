using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class OrderProcessor
    {
        private EmailSender _emailSender;

        public OrderProcessor(EmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        public string ProcessOrder(Order order)
        {
            string email = "customer@example.com";
            string message = "Your order has been processed.";
            return _emailSender.SendEmail(email, message);
        }
    }
}
