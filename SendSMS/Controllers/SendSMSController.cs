using SendSMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Twilio;
using System;

namespace SendSMS.Controllers
{
    public class SendSMSController : Controller
    {
        // GET: SendSMS
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index(SMSContent SMSObj)
        {
            try
            {
                string AccountSid = "AC9907acab2004e948831f1d2b80828168";
                string AuthToken = "60bb8d9e225d1d8091902a7a8578241e";
                var ReciverNumber = "+91" + SMSObj.PhoneNumber;
                var MessageBody = SMSObj.Message;
                var twilio = new TwilioRestClient(AccountSid, AuthToken);
                var Message = twilio.SendMessage("+19793530236", ReciverNumber, MessageBody);
                if (Message.RestException != null)
                {
                    var error = Message.RestException.Message;
                    return Content(error);
                }
                return Content("Done");
            }
            catch (System.Exception)
            {
                return Content("Error");
                throw;
            }
            
        }
    }

}