using BaltaPoo.SharedContext;

namespace BaltaPoo.SubscriptionContext
{
    /// <summary>
    /// Assinatura
    /// </summary>
    public class Subscription : Base
    { 
    
        /// <summary>
        /// A assinatura sempre terá um plano atrelado a ela.
        /// </summary>
        public Plan Plan { get; set; }

        /// <summary>
        /// Data final da assinatura
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Estará inativo se essa propriedade retornar true, data final da assinatura menor que data atual
        /// </summary>
        public bool IsInactive => EndDate <= DateTime.Now;

        public static void Add(Subscription subscription)
        {
            throw new NotImplementedException();
        }
    } 
}
