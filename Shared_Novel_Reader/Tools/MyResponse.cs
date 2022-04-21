using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared_Novel_Reader.Tools
{
    internal class MyResponse
    {
        public bool Result;
        public string Message;
        public JObject Data;


        public MyResponse(JObject responseJson)
        {
            if(MyJson.CheckColAndType(responseJson,"Result",JTokenType.Boolean))
            {
                Result = (Boolean)responseJson["Result"];
            }
            if (MyJson.CheckColAndType(responseJson, "Message", JTokenType.String))
            {
                Message = responseJson["Message"].ToString();
            }
            if (MyJson.CheckColAndType(responseJson, "Data", JTokenType.Object))
            {
                Data = (JObject)responseJson["Data"];
            }
        }
    }
}
