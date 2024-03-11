using BusinessLayer.Abstrack;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace KişiselSitem.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IMailServices _mailServices;
        private readonly ISenderServices _emailSenderService;

        public DefaultController(IMailServices mailServices, ISenderServices emailSenderService)
        {
            _mailServices = mailServices;
            _emailSenderService = emailSenderService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult SendMessage(Mail mail)
        {
            _mailServices.Createmail(mail);
            _emailSenderService.SenderEmail(mail.NameandSurname, mail.Email, mail.Title, mail.Message);
            return RedirectToAction("Index", "Default");
        }
    }

}
