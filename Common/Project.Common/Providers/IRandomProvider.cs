namespace Project.Web.Api.Infrastructure.Providers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IRandomProvider
    {
        int GetRandomNumber(int min, int max);
    }
}
