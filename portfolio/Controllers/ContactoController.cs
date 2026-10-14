using Microsoft.AspNetCore.Mvc;
using portfolio.Models;
using portfolio.Services;

namespace portfolio.Controllers;

public class ContactoController(IEmailGmailService emailGmailService) : Controller
{
    private readonly IEmailGmailService emailGmailService = emailGmailService;

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Index(ContactoViewModel viewModel)
    {
        if (viewModel == null)
        {
            ModelState.AddModelError(string.Empty, "Los datos del formulario no se han recibido correctamente.");
            return View(viewModel);
        }

        if (!ModelState.IsValid)
        {
            return View(viewModel);
        }

        bool sendEmail = await emailGmailService.SendEmailAsync(viewModel);

        if (!sendEmail)
        {
            ModelState.AddModelError(string.Empty, "Ocurrió un error al enviar el mensaje. Por favor, inténtalo de nuevo más tarde.");
            return View(viewModel);
        }

        return RedirectToAction(nameof(ThanksMessage));
    }

    public IActionResult ThanksMessage()
    {
        ViewBag.Message = "Te responderé a la mayor brevedad posible, será un gusto poder trabajar contigo.";
        return View();
    }
}
