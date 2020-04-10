using System;
namespace PocketCloset.Models
{
    public class ProfilePicture
    {
        public ProfilePicture()
        {
        }

        public int userId { get; set; }
        public byte[] profilePicture { get; set; }

    }
}
