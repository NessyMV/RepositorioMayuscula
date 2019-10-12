using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace mayuS
{
    public class Imayu1 : Imayu
    {
         public string minu(string value)
        {
            return value.ToLower();
            
        }
        public string mayu(string value)
        {
            return value.ToUpper();

        }

}
}