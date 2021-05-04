namespace API.DTOs
{
    public class MemberUpdateDto
    {
        // the folowing properties are not going to be validated
        // because this is a DTO => going to map into User Entity => go 2 AutoMapperProfiles.cs
        public string Introduction { get; set; }
        public string Lookingfor { get; set; }
        public string Interests { get; set; }
        public string Hobbies { get; set; }

        public string City { get; set; }
        public string Country { get; set; }
    }
}