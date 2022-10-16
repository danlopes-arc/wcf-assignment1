using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfAssignment1.Server
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        bool IsPrimeNumber(int value);

        [OperationContract]
        int SumDigits(int value);

        [OperationContract]
        string ReverseString(string value);

        [OperationContract]
        string MakeHtmlTag(string tag, string value);

        [OperationContract]
        List<int> Sort(List<int> value);
    }
}
