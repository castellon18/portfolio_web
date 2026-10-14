namespace portfolio.Models;

public class CurriculumViewModel
{
    public IEnumerable<FormacionAcademicaViewModel> FormacionAcademica { get; set; } = [];
    public IEnumerable<HabilidadesViewModel> Habilidades { get; set; } = [];
    public IEnumerable<ExperienciaLaboralViewModel> ExperienciaLaboral { get; set; } = [];
}
