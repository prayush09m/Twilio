using System.Configuration;
using System.Web.Mvc;
using TwilioCheckout.Models;
using Twilio;

namespace TwilioCheckout.Controllers
{
    public class KeyController : Controller
    {
        // GET: Key
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(KeyModels model, string returnUrl)
        {
            string AccountSID = ConfigurationManager.AppSettings["AccountSID"];
            string AuthToken = ConfigurationManager.AppSettings["AuthToken"];
            string phoneNumber = ConfigurationManager.AppSettings["phoneNumber"];

            var client = new TwilioRestClient(AccountSID, AuthToken);
            client.SendMessage(phoneNumber, model.PhoneNumber, model.Message);
            return View("Success");
        }
    }
}