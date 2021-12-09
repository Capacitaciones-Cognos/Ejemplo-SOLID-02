using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test02_SOLID_Cognos
{
    public class Notification
    {

        public string Type { get; set; } // email o whatsapp
        
        // dos propiedades que no deberian estar acopladas
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int skypeId { get; set; }

        public string Subject { get; set; }
    }
}
