using BaltaPoo.SharedContext;
using System.Collections.Generic;


namespace BaltaPoo.ContentContext
{
    public class Module : Base
    {
        /// <summary>
        /// inicializando o objeto no construtor
        /// </summary>
        public Module()
        {
            Lectures = new List<Lecture>();
        }

        public int Order { get; set; }

        public string Title { get; set; }

        public IList<Lecture> Lectures { get; set; }

    }

}
