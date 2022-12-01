using EntityLayer.Models.Base;
using System.Text.Json.Serialization;

namespace EntityLayer.Models
{
    public class User : Identifier
    {
        public string Name { get; set; }
        public string Email { get; set; }
        [JsonIgnore]
        public string Password { get; set; }
    }
}
