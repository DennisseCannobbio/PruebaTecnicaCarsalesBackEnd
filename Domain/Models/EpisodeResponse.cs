using System.Runtime.Serialization;
using System.Text;

namespace BackendAPI.Domain.Models
{
    [DataContract]
    public class EpisodeResponse
    {
        [DataMember(Name = "Id")]
        public int Id { get; set; }

        [DataMember(Name = "Name")]
        public string Name { get; set; }

        [DataMember(Name = "AirDate")]
        public string AirDate { get; set; }

        [DataMember(Name = "Episode")]
        public string Episode { get; set; }


        [DataMember(Name = "Characters")]
        public List<string> Characters { get; set; }

        [DataMember(Name = "Url")]
        public string Url { get; set; }

        [DataMember(Name = "Created")]
        public DateTime Created { get; set; }


    }
}
