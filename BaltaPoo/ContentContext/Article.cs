namespace BaltaPoo.ContentContext 
{
    /// <summary>
    /// Apenas para criação de artigo, ficará vazia.
    /// </summary>
    public class Article : Content 
    {
        /// <summary>
        /// Construtor usando herança.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="url"></param>
        public Article(string title, string url) : base(title, url)
        {
        }
    }
}