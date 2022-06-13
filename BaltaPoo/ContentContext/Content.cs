
namespace BaltaPoo.ContentContext {
    /// <summary>
    /// Essas propriedades serão herdadas pelas outras classes
    /// </summary>
    public abstract class Content : Base
    {
        /// <summary>
        /// O Id é gerado automaticamente aqui no construtor, colocamos os parâmetros indispensáveis.
        /// </summary>
        public Content(string title, string url)
        {
            Title = title;
            Url = url;
        }        

        public string Title { get; set; }

        public string Url { get; set; }
    }
}