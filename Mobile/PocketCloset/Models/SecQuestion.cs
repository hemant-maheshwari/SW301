﻿using System;
namespace PocketCloset.Models
{
    public class SecQuestion
    {
        public SecQuestion()
        {
        }

        public int userId { get; set; }
        public int queId { get; set; }
        public string question { get; set; } //security question
        public string answer { get; set; }


    }
}
