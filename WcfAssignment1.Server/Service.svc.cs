using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfAssignment1.Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service : IService
    {
        public bool IsPrimeNumber(int value)
        {
            for (int i = value - 1; i > 1; i--)
            {
                if (value % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public string MakeHtmlTag(string tag, string value)
        {
            return $"<{tag}>{value}</{tag}>";
        }

        public string ReverseString(string value)
        {
            return String.Join("", value.Reverse());
        }

        public List<int> Sort(List<int> value, bool isDescending)
        {
            if (isDescending)
            {
                return value.OrderByDescending(n => n).ToList();
            }

            return value.OrderBy(n => n).ToList();
        }

        public int SumDigits(int value)
        {
            return value
                .ToString()
                .ToArray()
                .Select(caracter => caracter.ToString())
                .Aggregate(0, (int sum, string current) => sum + int.Parse(current));
        }
    }
}
