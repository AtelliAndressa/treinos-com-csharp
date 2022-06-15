using BaltaPoo.SharedContext;
using System.Collections.Generic;

using System;
using BaltaPoo.NotificationContext;

namespace BaltaPoo.SubscriptionContext
{
    public class Student : Base
    {
        public Student()
        {
            Subscriptions = new List<Subscription>();
        }

        public User User { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public IList<Subscription> Subscriptions { get; set; }

        //método para validação de assinatura
        public void CreateSubscription(Subscription subscription)
        {
            if (IsPremium)
            {
                AddNotification(new Notification("Premium", "O Aluno já tem uma assinatura ativa."));
                return;
            }
            Subscription.Add(subscription);

        }

        public bool IsPremium => Subscriptions.Any(x => !x.IsInactive);
    }
}
