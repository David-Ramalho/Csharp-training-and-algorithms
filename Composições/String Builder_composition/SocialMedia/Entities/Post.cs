using System;
using System.Collections.Generic;
using System.Text;

namespace SocialMedia.Entities
{
     class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string content { get; set; }
        public int Likes { get; set; }
    }
}
