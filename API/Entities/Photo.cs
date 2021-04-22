using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    [Table("Photos")]
    public class Photo
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public bool IsMain { get; set; }
        public string PublicId { get; set; }
        
        // We need to fully defining the relationship and tell it to API.Entities.Photo about AppUSer class
        public AppUser AppUser { get; set; }
        public int AppUserID { get; set; }
    }
}