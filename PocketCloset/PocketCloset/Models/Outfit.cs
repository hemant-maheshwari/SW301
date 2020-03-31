using System;
using System.Collections.Generic;

namespace PocketCloset.Models
{
    public class Outfit
    {
        public Outfit()
        {
        }

        public int outfitId { get; set; }
        public int userId { get; set; }
        public string outfitName { get; set; }
        public List<string> clothList { get; set; } //list of cloth ids



    }
}
