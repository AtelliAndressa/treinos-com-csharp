
using BaltaPoo.ContentContext.Enums;

namespace BaltaPoo.ContentContext
{
    /// <summary>
    /// essa classe refê-se a aula
    /// </summary>
    public class Lecture
    {
        public int Order { get; set; }

        public string Title { get; set; }

        public int DurationInMinutes { get; set; }

        public EContentLevel Level { get; set; }
    }
}
