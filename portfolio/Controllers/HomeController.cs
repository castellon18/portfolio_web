using Microsoft.AspNetCore.Mvc;
using portfolio.Models;
using portfolio.Services;
using System.Diagnostics;

namespace portfolio.Controllers;

public class HomeController(IHabilidadRepository habilidadRepository, IExperienciaLaboralRepository experienciaLaboralRepository) : Controller
{
    private readonly IHabilidadRepository habilidadRepository = habilidadRepository;
    private readonly IExperienciaLaboralRepository experienciaLaboralRepository = experienciaLaboralRepository;

    [HttpGet]
    public IActionResult Index()
    {
        IEnumerable<HabilidadesViewModel> habilidades = habilidadRepository.GetHabilidades();
        IEnumerable<ExperienciaLaboralViewModel> experiencias = experienciaLaboralRepository.GetExperienciasLaborales();
        HomeIndexViewModel model = new()
        {
            Habilidades = habilidades,
            ExperienciasLaborales = experiencias
        };
        return View(model);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
