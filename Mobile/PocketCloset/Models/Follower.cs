using System;
namespace PocketCloset.Models
{
    public class Follower
    {
        public Follower()
        {
        }


        public int followId { get; set; }
        public int followerUserId { get; set; } //Id of person who is following 
        public int followedUserId { get; set; } //id of person who is being followed
    
    }
}
