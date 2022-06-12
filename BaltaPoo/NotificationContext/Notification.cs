using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaltaPoo.NotificationContext
{
    public class Notification
    {
        public Notification()
        {
        }

        public Notification(string property, string message)
        {
            Property = property;
            Message = message;
        }

        /// <summary>
        /// Propriedade que apresentou o erro.
        /// </summary>
        public string Property { get; set; }

        public string Message { get; set; }
    }
}
