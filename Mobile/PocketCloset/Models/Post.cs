using System;
namespace PocketCloset.Models
{
    public class Post
    {
        public Post()
        {
        }

        public int userId { get; set; }
        public int postId { get; set; }
        public int clothId { get; set; }
        public double price { get; set; }
        public string url { get; set; } //url to buy clothing article
        public bool isModelPresent { get; set; } //is model present in picture
      

    }
}
