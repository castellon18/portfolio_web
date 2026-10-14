using portfolio.Models;

namespace portfolio.Services;

public interface IFormacionAcademicaRepository
{
    IEnumerable<FormacionAcademicaViewModel> GetFormacionAcademica();
}

public class FormacionAcademicaRepository : IFormacionAcademicaRepository
{
    public IEnumerable<FormacionAcademicaViewModel> GetFormacionAcademica()
    {
        return
        [
            new FormacionAcademicaViewModel
            {
                Titulo = "Ingeniería en Informática",
                Institucion = "Universidad Nacional de La Plata",
                Year = "2015 - 2020",
                Instructor = "Dr. Juan Pérez"
            },
            new FormacionAcademicaViewModel
            {
                Titulo = "Máster en Desarrollo de Software",
                Institucion = "Instituto Tecnológico de Buenos Aires",
                Year = "2021 - 2023",
                Instructor = "Dra. María Gómez"
            }
        ];
    }
}
