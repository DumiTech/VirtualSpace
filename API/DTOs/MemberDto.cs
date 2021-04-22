using System;
using System.Collections.Generic;

namespace API.DTOs
{
    public class MemberDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string PhotoUrl { get; set; }    //we'll use this property to use as the main photo that we send back for a user
        public int Age { get; set; }
        public string KnownAs { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        public string Gender { get; set; }  //  optionally, there should be an option: not specified.
        public string Introduction { get; set; }    //  a brief description (x < 500 char)
        public string Favorites { get; set; }   // about different products/items available in the shop
        public string Hobbies { get; set; }
        public string Interests { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public ICollection<PhotoDto> Photos { get; set; } 
    }
}