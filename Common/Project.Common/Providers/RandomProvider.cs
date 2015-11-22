namespace Project.Web.Api.Infrastructure.Providers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class RandomProvider : IRandomProvider
    {
        private static readonly Random random = new Random();

        public int GetRandomNumber(int min, int max)
        {
            return random.Next(min, max + 1);
        }
    }
}