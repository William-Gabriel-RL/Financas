using EntityLayer.Models.Base;

namespace EntityLayer.Models
{
    public class Account : Identifier
    {
        public string Name { get; set; }
        public string? Bank { get; set; }
        public string Type { get; set; }
        public decimal Balance { get; set; } = 0M;
        public int IdUser { get; set; }
        public virtual User User { get; set; }
    }
}
