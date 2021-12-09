using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test02_SOLID_Cognos.solid
{
    public class NotificationEmailService : INotification
    {
        private readonly string to;
        private readonly string subject;

        public NotificationEmailService(string to, string subject)
        {
            this.to = to;
            this.subject = subject;
        }

        public void Notify()
        {
            // Logica para mandar emails
            string x = "notificacion por emails";
        }

        
    }
}
