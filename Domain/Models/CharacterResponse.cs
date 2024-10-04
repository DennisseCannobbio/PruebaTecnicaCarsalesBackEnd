using System.Runtime.Serialization;

namespace BackendAPI.Domain.Models
{
    [DataContract]
    public class CharacterResponse
    {
        [DataMember(Name = "Id")]
        public int Id { get; set; }

        [DataMember(Name = "Name")]
        public string Name { get; set; }

        [DataMember(Name = "Url")]
        public string Url { get; set; }
    }
}
