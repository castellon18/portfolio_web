namespace portfolio.Models;

public class ExperienciaLaboralViewModel
{
    public string Empresa { get; set; } = string.Empty;
    public string Posicion { get; set; } = string.Empty;
    public string Years { get; set; } = string.Empty;
    public string[] Responsabilidades { get; set; } = [];
    public string Localidad { get; set; } = string.Empty;
    public TecnologiaUsadaViewModel[] TecnologiasUsadas { get; set; } = [];
}

public class TecnologiaUsadaViewModel
{
    public string Nombre { get; set; } = string.Empty;
    public string Version { get; set; } = string.Empty;
}
