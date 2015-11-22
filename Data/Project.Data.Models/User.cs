namespace Project.Data.Models
{
    using System.Security.Claims;
    using System.Threading.Tasks;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Collections.Generic;

    //using Microsoft.AspNet.Identity.Owin;

    public class User : IdentityUser
    {
        //for relation if needed(if a Model has userId and user)
        private ICollection<OtherDefaultModel> otherDefaulModels;

        public User()
        {
            this.otherDefaulModels = new HashSet<OtherDefaultModel>();
        }

        public virtual ICollection<OtherDefaultModel> OtherDefaulModels
        {
            get { return this.otherDefaulModels; }
            set { this.otherDefaulModels = value; }
        }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager, string authenticationType)
        {
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            return userIdentity;
        }

    }
}
