using BaltaPoo.ContentContext.Enums;

namespace BaltaPoo.ContentContext {
    public class Course : Content  
    {
        /// <summary>
        /// Construtor inicializando para não dar erro.
        /// </summary>
        public Course(string title, string url) : base(title, url)
        {
            Modules = new List<Module>(); 
        }

        public string Tag { get; set; }

        public IList<Module> Modules { get; set; }

        public int durationInMinutes { get; set; }  

        public EContentLevel Level { get; set; }
    }



}