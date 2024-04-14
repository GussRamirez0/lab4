using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface INotificable
{
    void Notificar(string mensaje);
}


public class NotificacionEmail : INotificable
{
    private string direccionCorreo;

    public NotificacionEmail(string correo)
    {
        direccionCorreo = correo;
    }

    public void Notificar(string mensaje)
    {
        Console.WriteLine($"Enviando correo electrónico a {direccionCorreo}: {mensaje}");
    }
}


public class NotificacionWhatsapp : INotificable
{
    private string numeroTelefono;

    public NotificacionWhatsapp(string telefono)
    {
        numeroTelefono = telefono;
    }

    public void Notificar(string mensaje)
    {
        Console.WriteLine($"Enviando mensaje al WhatsApp del número {numeroTelefono}: {mensaje}");
    }
}

public class NotificacionSMS : INotificable
{
    private string numeroTelefono;

    public NotificacionSMS(string telefono)
    {
        numeroTelefono = telefono;
    }

    public void Notificar(string mensaje)
    {
        Console.WriteLine($"Enviando sms al número {numeroTelefono}: {mensaje}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        NotificacionEmail emailNotificacion = new NotificacionEmail("correo@example.com");
        emailNotificacion.Notificar("¡Hola! Este es un mensaje de prueba.");

        NotificacionWhatsapp whatsappNotificacion = new NotificacionWhatsapp("+502 47916251");
        whatsappNotificacion.Notificar("¡Hola! Este es un mensaje de prueba.");

        NotificacionSMS smsNotificacion = new NotificacionSMS("+502 47916251");
        smsNotificacion.Notificar("¡Hola! Este es un mensaje de prueba.");

    }
}