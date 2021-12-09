using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test02_SOLID_Cognos.solid
{
    public class NotificationServicesOpenClosed
    {
        public void Send(List<INotification> notifications)
        {
            foreach (var notification in notifications)
            {
                notification.Notify();
            }
        }

    }
}
