namespace Project.Web.Wcf
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.ServiceModel;
    using System.ServiceModel.Web;
    using System.Text;


    public class Service1 : IUsers
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }
    }
}
