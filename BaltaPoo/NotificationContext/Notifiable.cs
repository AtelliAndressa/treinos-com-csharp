using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaltaPoo.NotificationContext
{
    public abstract class Notifiable
    {
        public List<Notification> Notifications { get; set; }
        //inicializando a lista para não gerar erro
        public Notifiable()
        {
            Notifications = new List<Notification>();
        }

        /// <summary>
        /// Método que recebe uma notificação.
        /// </summary>
        /// <param name="notification"></param>
        public void AddNotification(Notification notification)
        {
            Notifications.Add(notification);
        }

        /// <summary>
        /// Método que recebe várias notificações.
        /// </summary>
        /// <param name="notifications"></param>
        public void AddNotifications(IEnumerable<Notification> notifications)
        {
            Notifications.AddRange(notifications);
        }

        /// <summary>
        /// Propriedade usando o get em forma de expression body.
        /// Se houver algum erro na execução ele retorna true, objeto inválido.
        /// </summary>
        public bool IsInvalid => Notifications.Any();
    }
}
