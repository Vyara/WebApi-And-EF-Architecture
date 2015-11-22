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

        //for one user
        //public string UserId { get; set; }

        //public virtual User User { get; set; }

            //for two users(if we don't want a collection of users)
        public string FirstUserId { get; set; }

        public virtual User FirstUser { get; set; }

        public string SecondUserId { get; set; }

        public virtual User SecondUser { get; set; }

        public virtual ICollection<OtherDefaultModel> OtherDefaults { get; set; }

    }
}
