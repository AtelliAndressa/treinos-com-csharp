using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaltaPoo.ContentContext
{
    public class CareerItem
    {
        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="order"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="course"></param>
        public CareerItem(int order, string title, string description, Course course)
        {
            Order = order;
            Title = title;
            Description = description;
            Course = course;
        }

        public int Order { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public Course Course { get; set; }
    }
}
