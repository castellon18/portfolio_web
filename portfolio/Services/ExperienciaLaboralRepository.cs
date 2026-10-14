using portfolio.Models;

namespace portfolio.Services;

public interface IExperienciaLaboralRepository
{
    IEnumerable<ExperienciaLaboralViewModel> GetExperienciasLaborales();
}

public class ExperienciaLaboralRepository : IExperienciaLaboralRepository
{
    public IEnumerable<ExperienciaLaboralViewModel> GetExperienciasLaborales()
    {
        return
        [
            new ExperienciaLaboralViewModel {
                Empresa = "Industrias Magaña",
                Posicion = "Cartera y Cobro",
                Years = "2014 - Actual",
                Localidad = "Managua - Nicaragua"
            },
            new ExperienciaLaboralViewModel {
                Empresa = "Humberto Alvarez",
                Posicion = "Administradora",
                Years = "2010 - 2013",
                Localidad = "Managua - Nicaragua"
            },
            new ExperienciaLaboralViewModel {
                Empresa = "Hotel Estrella",
                Posicion = "Secretaria",
                Years = "2005 - 2009",
                Localidad = "Managua - Nicaragua"
            },
            new ExperienciaLaboralViewModel {
                Empresa = "Mafisa",
                Posicion = "Auxiliar Contable",
                Years = "2000 - 2008",
                Localidad = "Managua - Nicaragua"
            },
        ];
    }
}
