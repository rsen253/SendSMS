using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SendSMS.Models
{
    public class SMSContent
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
    }
}