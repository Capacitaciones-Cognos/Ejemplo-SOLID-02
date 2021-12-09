using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test02_SOLID_Cognos.solid;

namespace Test02_SOLID_Cognos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var emailNotification = new Notification
            {
                Type = "email",
                Email = "algo@gmail.com",
                Subject = "Ref. Algo"
            };

            var smsNotification = new Notification
            {
                Type = "sms",
                PhoneNumber = "+5917414748",
                Subject = "Este es el mensaje de texto donde no deberia ir"
            };

            var notificationServices = new NotificationServices();

            List<Notification> notifications = new List<Notification>();
            notifications.Add(emailNotification);
            notifications.Add(smsNotification);

            notificationServices.Send(notifications);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var notifications = new List<INotification>();

            NotificationEmailService emailNotification = new NotificationEmailService("test@gmail.com", "motivo de correo");

            NotificationSmsService smsNotification = new NotificationSmsService("+5917251492", "mensaje de texto de prueba");
            
            notifications.Add(emailNotification);
            notifications.Add(smsNotification);

            var notificationServices = new NotificationServicesOpenClosed();

            notificationServices.Send(notifications);

            
        }
    }
}
