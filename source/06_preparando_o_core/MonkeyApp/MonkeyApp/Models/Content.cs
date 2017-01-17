using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyApp.Models
{
    public class Content : BaseModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PostedIn { get; set; }
        public string ImageUrl { get; set; }
        public string ThumbnailUrl { get; set; }
        public string Url { get; set; }
    }
}
