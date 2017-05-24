using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace KBA.Etjanster.Lovskola
{
    [ServiceContract]
    public interface IRapport
    {

        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetData", Method = "POST")]
        string GetData(int value);

        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetInfo", Method = "GET")]
        string GetInfo();

        [OperationContract]
        [WebInvoke(Method = "OPTIONS", UriTemplate = "*")]
        void GetOptions();

    }

}
