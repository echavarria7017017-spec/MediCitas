using System;

namespace MediCitas.Patterns
{
    // 1. Interfaz de la Estrategia
    public interface INotificacionStrategy
    {
        void EnviarMensaje(string destinatario, string mensaje);
    }

    // 2. Estrategia Concreta: Correo Electrónico (SMTP)
    public class SmtpEmailStrategy : INotificacionStrategy
    {
        public void EnviarMensaje(string destinatario, string mensaje)
        {
            Console.WriteLine($"[EMAIL SMTP] Para: {destinatario} | Mensaje: {mensaje}");
        }
    }

    // 3. Estrategia Concreta: WhatsApp
    public class WhatsAppStrategy : INotificacionStrategy
    {
        public void EnviarMensaje(string destinatario, string mensaje)
        {
            Console.WriteLine($"[WHATSAPP] Para: {destinatario} | Mensaje: {mensaje}");
        }
    }

    // 4. Contexto: Gestor de Notificaciones de Citas
    public class GestorNotificacionesCita
    {
        private INotificacionStrategy _estrategia;

        public GestorNotificacionesCita(INotificacionStrategy estrategiaInicial)
        {
            _estrategia = estrategiaInicial;
        }

        public void CambiarEstrategia(INotificacionStrategy nuevaEstrategia)
        {
            _estrategia = nuevaEstrategia;
        }

        public void NotificarPaciente(string destinatario, string detalleCita)
        {
            string mensaje = $"Recordatorio/Confirmación MediCitas: {detalleCita}";
            _estrategia.EnviarMensaje(destinatario, mensaje);
        }
    }
}
