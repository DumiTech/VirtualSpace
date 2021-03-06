using System;
using System.Collections.Generic;

namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string KnownAs { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime LastActive { get; set; } = DateTime.Now;
        public string Gender { get; set; }  //  optionally, there should be an option: not specified.
        public string Introduction { get; set; }    //  a brief description (x < 500 char)
        public string Favorites { get; set; }   // about different products/items available in the shop
        public string Hobbies { get; set; }
        public string Interests { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public ICollection<Photo> Photos { get; set; }  // type of relationship: one to many (one user can have multiple photos)

        // public int GetAge()
        // {
        //     return DateOfBirth.CalculateAge();
        // }
    }
}