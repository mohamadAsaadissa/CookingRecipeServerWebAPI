using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingRecipesWebAPI.Models
{
    public class Video
    {
        public string VideoId { get; set; }

        public string Title { get; set; }
        public string Summary { get; set; }
        public DateTime dateTime { get; set; }
    }
}
