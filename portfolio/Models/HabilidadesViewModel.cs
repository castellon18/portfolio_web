namespace portfolio.Models;

public class HabilidadesViewModel
{
    public string Titulo { get; set; } = string.Empty;
    public HabilidadViewModel[] Habilidad { get; set; } = [];
}

public class HabilidadViewModel
{
    public string Nombre { get; set; } = string.Empty;
    public string[] Lista { get; set; } = [];
}
