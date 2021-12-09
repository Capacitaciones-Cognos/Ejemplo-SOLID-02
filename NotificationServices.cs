using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test02_SOLID_Cognos
{
    public class NotificationServices
    {
        public void Send(List<Notification> notifications)
        {
            foreach (var notification in notifications)
            {
                if (notification.Type.Equals("sms"))
                {
                    SendbySMS(notification.PhoneNumber, notification.Subject);
                }

                if (notification.Type.Equals("email"))
                {
                    SendbyEmail(notification.Email, notification.Subject);
                }
                // ampliar la funcionalidad para mandar mensajes por whatsapp, telegram, skype, etc.
                if (notification.Type.Equals("whatsapp"))
                {
                    SendbyWhatsApp(notification.PhoneNumber, notification.Subject);
                }

                if (notification.Type.Equals("telegram"))
                {
                    SendbyTelegram(notification.PhoneNumber, notification.Subject);
                }

                if (notification.Type.Equals("skype"))
                {
                    SendbySkype(notification.skypeId, notification.Subject);
                }

            }
        }

        private void SendbySkype(int skypeId, string subject)
        {

        }

        private void SendbyTelegram(string phoneNumber, string subject)
        {

        }

        private void SendbyWhatsApp(string phoneNumber, string subject)
        {

        }

        private void SendbySMS(string phoneNumber, string subject)
        {
            // Logica para mandar el SMS
        }

        private void SendbyEmail(string to, string subject)
        {
            // Logica para mandar el email
        }

    }
}
