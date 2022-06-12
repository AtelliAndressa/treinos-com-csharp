
namespace BaltaPoo.ContentContext {
    /// <summary>
    /// Essas propriedades serão herdadas pelas outras classes
    /// </summary>
    public abstract class Content
    {
        /// <summary>
        /// O Id é gerado automaticamente aqui no construtor, colocamos os parâmetros indispensáveis.
        /// </summary>
        public Content(string title, string url)
        {
            Id = Guid.NewGuid();
            Title = title;
            Url = url;
        }

        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Url { get; set; }
    }
}