using System;
namespace PocketCloset.Models
{
    public class Cloth
    {
        public Cloth()
        {
        }

        public int clothId { get; set; }
        public int userId { get; set; }
        public string clothType { get; set; }
        public string clothPicture { get; set; }
        public string color { get; set; }
        public string material { get; set; }
        public string season { get; set; }

//        Cloth_id: int[AI][PK][NN]
//User_id: int
//Type: string
//Picture: string/ blob(clob)
//Color: string
//Material: string
//Season: string

    }
}
