using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test02_SOLID_Cognos.solid
{
    public class NotificationSmsService : INotification
    {
        private readonly string phoneNumber;
        private readonly string text;

        public NotificationSmsService(string phoneNumber, string text)
        {
            this.phoneNumber = phoneNumber;
            this.text = text;
        }

        public void Notify()
        {
            // Logica para enviar mensajes de texto
            string x = "notificacion por sms";

        }
    }
}
