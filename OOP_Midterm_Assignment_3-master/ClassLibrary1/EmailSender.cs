using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class EmailSender
    {
        public string SendEmail(string email, string message)
        {
            return $"Email sent to {email}: {message}";
        }
    }
}
