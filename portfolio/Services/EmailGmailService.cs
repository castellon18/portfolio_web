using portfolio.Models;
using System.Net;
using System.Net.Mail;

namespace portfolio.Services;

/// <summary>
/// Envía un correo electrónico de forma asíncrona.
/// </summary>
/// <param name="contacto">Datos del contacto.</param>
/// <returns>True si el correo se envió con éxito, False en caso contrario.</returns>

public interface IEmailGmailService
{
    Task<bool> SendEmailAsync(ContactoViewModel contacto);
}

public class EmailGmailService(IConfiguration configuration, ILogger<EmailGmailService> logger) : IEmailGmailService
{
    private readonly IConfiguration configuration = configuration;
    private readonly ILogger<EmailGmailService> logger = logger;

    public async Task<bool> SendEmailAsync(ContactoViewModel contacto)
    {
        string emailEmisor = configuration.GetValue<string>("CONFIGURACIONES_EMIAL:EMAIL") ?? string.Empty;
        string password = configuration.GetValue<string>("CONFIGURACIONES_EMIAL:PASSWORD") ?? string.Empty;
        string host = configuration.GetValue<string>("CONFIGURACIONES_EMIAL:HOST") ?? string.Empty;
        int puerto = configuration.GetValue<int?>("CONFIGURACIONES_EMIAL:PORT") ?? 587;

        if (string.IsNullOrEmpty(emailEmisor) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(host))
        {
            logger.LogError("Error de configuración de email: EMAIL, PASSWORD o HOST no pueden ser nulos o vacíos.");
            return false;
        }

        try
        {
            using SmtpClient smtpCliente = new(host, puerto)
            {
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(emailEmisor, password)
            };
            string subject = $"Cliente: {contacto.Nombres} {contacto.Apellidos}";
            string body = $"Correo del cliente: {contacto.Email} \r\n {contacto.Mensaje}";
            using MailMessage mensaje = new(emailEmisor, emailEmisor, subject, body);
            await smtpCliente.SendMailAsync(mensaje);
            logger.LogInformation("Correo enviado exitosamente a {EmailEmisor} desde {EmailCliente}", emailEmisor, contacto.Email);
            return true;
        }
        catch (SmtpException smtpEx)
        {
            // Errores específicos de SMTP (ej. autenticación fallida, servidor no disponible)
            logger.LogError(smtpEx, "Error SMTP al enviar correo: {SmtpErrorCode} - {SmtpErrorDescription}", smtpEx.StatusCode, smtpEx.Message);
            return false;
        }
        catch (Exception ex)
        {
            // Cualquier otro tipo de error inesperado
            logger.LogError(ex, "Error inesperado al enviar correo.");
            return false;
        }
    }
}
