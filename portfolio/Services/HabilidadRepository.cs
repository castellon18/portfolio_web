using portfolio.Models;

namespace portfolio.Services;

public interface IHabilidadRepository
{
    IEnumerable<HabilidadesViewModel> GetHabilidades();
}

public class HabilidadRepository : IHabilidadRepository
{
    public IEnumerable<HabilidadesViewModel> GetHabilidades()
    {
        return
        [
            new HabilidadesViewModel
            {
                Titulo = "Planificación Estratégica",
            },
            new HabilidadesViewModel
            {
                Titulo = "Gestión Financiera",
            },
            new HabilidadesViewModel
            {
                Titulo = "Liderazgo de Equipos",
            },
            new HabilidadesViewModel
            {
                Titulo = "Negociación Empresarial",
            },
            new HabilidadesViewModel
            {
                Titulo = "Marketing Corporativo",
            },
            new HabilidadesViewModel
            {
                Titulo = "Transformación Digital",
            },
        ];
    }
}
