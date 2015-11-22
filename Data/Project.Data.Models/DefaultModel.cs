namespace Project.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Common.Constants;

    public class DefaultModel
    {
        public DefaultModel()
        {
            this.OtherDefaults = new HashSet<OtherDefaultModel>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(ValidationConstants.NameMinLength)]
        [MaxLength(ValidationConstants.NameMaxLength)]
        public string Title { get; set; }

        [Required]
        [MinLength(20)]
        [MaxLength(150)]
        public string Description { get; set; }

        public DateTime DateCreated { get; set; }

        public bool IsDeleted { get; set; }

        [Required]
        public string UserId { get; set; }

        public virtual User User { get; set; }


        public virtual ICollection<OtherDefaultModel> OtherDefaults { get; set; }

    }
}
