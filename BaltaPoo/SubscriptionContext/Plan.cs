using BaltaPoo.SharedContext;


namespace BaltaPoo.SubscriptionContext
{
    /// <summary>
    /// Plano de assinatura
    /// </summary>
    public class Plan : Base
    {
        public string Title { get; set; }

        public decimal Price { get; set; }
    }
}
