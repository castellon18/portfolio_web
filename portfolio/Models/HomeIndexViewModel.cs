namespace portfolio.Models;

public class HomeIndexViewModel
{
    public IEnumerable<HabilidadesViewModel> Habilidades { get; set; } = [];
    public IEnumerable<ExperienciaLaboralViewModel> ExperienciasLaborales { get; set; } = [];
}
