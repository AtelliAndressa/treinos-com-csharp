using System.Collections.Generic;

namespace BaltaPoo.ContentContext {
    /// <summary>
    /// Items dentro de uma carreira.
    /// </summary>
    public class Career : Content
    {
        public Career(string title, string url) : base(title, url)
        {
            Items = new List<CareerItem> ();
        }

        public IList<CareerItem> Items { get; set; }



        /// <summary>
        /// Essa propriedade usa apenas o get, somando a quantidade de items.
        /// Essa forma de usar o get é chamada de Expression body.
        /// </summary>
        public int TotalCourses => Items.Count;
    }

}