﻿using System;
namespace PocketCloset.Models
{
    public class User
    {
        public int userId { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string userType { get; set; } //user type: store or user
        public string gender { get; set; }
        public string dob { get; set; } //date of birth

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }


        public bool checkInformation()  //verifies login information
        {
            if (username == null || password == null)
            {
                return false;
            }
            if (!this.username.Equals("") && !this.password.Equals(""))
            {
                return true;
            }
            else
                return false;
        }
    }
}
