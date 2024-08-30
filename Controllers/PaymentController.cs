
using Microsoft.AspNetCore.Mvc;

namespace SecurePayWebApp.Controllers
{
    public class PaymentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ProcessPayment(string cardNumber, string expiration, string cvv, decimal amount)
        {
            // Simulate payment processing logic here
            ViewBag.Message = "Payment processed successfully!";
            return View("Index");
        }
    }
}
