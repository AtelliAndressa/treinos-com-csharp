using BaltaPoo.NotificationContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaltaPoo.ContentContext
{
    public class CareerItem : Base
    {
        /// <summary>
        /// Construtor
        /// </summary>
        public CareerItem(int order, string title, string description, Course course)
        {
            if(course == null)
            {
                AddNotification(new Notification("Course", "curso inválido"));
            }

            Order = order;
            Title = title;
            Description = description;
            Course = course;
            //Course = course ?? throw new Exception("curso inválido");
        }

        //Propriedades:
        public int Order { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public Course Course { get; set; }
    }
}
