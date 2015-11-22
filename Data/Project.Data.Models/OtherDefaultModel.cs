namespace Project.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class OtherDefaultModel
    {
        [Key]
        public int Id { get; set; }

        public string Number { get; set; }

        public string UserId { get; set; }

        public virtual User User { get; set; }
    }
}
