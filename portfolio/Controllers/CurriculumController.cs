using Microsoft.AspNetCore.Mvc;
using portfolio.Models;
using portfolio.Services;

namespace portfolio.Controllers;

public class CurriculumController(IHabilidadRepository habilidadRepository, IFormacionAcademicaRepository formacionAcademicaRepository, IExperienciaLaboralRepository experienciaLaboralRepository) : Controller
{
    private readonly IHabilidadRepository habilidadRepository = habilidadRepository;
    private readonly IFormacionAcademicaRepository formacionAcademicaRepository = formacionAcademicaRepository;
    private readonly IExperienciaLaboralRepository experienciaLaboralRepository = experienciaLaboralRepository;


    [HttpGet]
    public IActionResult Index()
    {
        CurriculumViewModel curriculumViewModel = new()
        {
            Habilidades = habilidadRepository.GetHabilidades(),
            FormacionAcademica = formacionAcademicaRepository.GetFormacionAcademica(),
            ExperienciaLaboral = experienciaLaboralRepository.GetExperienciasLaborales()
        };

        return View(curriculumViewModel);
    }
}
