using log4net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Shared_Novel_Reader.Tools
{
    /// <summary>
    /// 静态的客户端HTTP类
    /// </summary>
    internal class MyClient
    {
        private static RestClient client = null;
        private static string Authorization = "";// 用户Token
        private static ILog log = LogManager.GetLogger(typeof(Tools.MyClient));
        private static bool IsInit = false;

        /// <summary>
        /// 用户凭证
        /// </summary>
        public static string Token
        {
            get { 
                return Authorization; 
            }
            set
            {
                Authorization = value;
                MessageBox.Show("用户凭证更新为 : " + Authorization);
            }
        }

        /// <summary>
        /// 请求超时时间
        /// </summary>
        public static int TimeOut = 1000 * 5;
        // public static string IP = "http://192.168.174.132:8080";

        /// <summary>
        /// 服务器IP地址
        /// </summary>
        public static string IP = "http://47.98.122.86:8080";



        /// <summary>
        /// 检查用户Token是否有效
        /// </summary>
        /// <returns></returns>
        public static bool CheckOnline()
        {
            init();
            if (client == null)
                return false;

            if (Authorization == "")
                return false;

            return true;
        }


        public static bool CheckStatus(in System.Threading.Tasks.Task< RestResponse > response)
        {
            init();
            var ResponseStatus = response.Result.ResponseStatus;
            var ResponseErrorMsg = response.Result.ErrorMessage;
            var ResponseErrorException = response.Result.ErrorException;
            var ResponseHttpStatus = response.Result.StatusCode;
            var ResponseStatusDescription = response.Result.StatusDescription;
            var IsSuccessful = response.Result.IsSuccessful;
            /*
                None,
                Completed,
                Error,
                TimedOut,
                Aborted
             */
            /*
                在RestSharp的HttpResponse 类型中定义了两个有关Http状态的字段分别为：
                1：System.Net.HttpStatusCode枚举类型的StatusCode
                2:RestSharp.ResponseStatus枚举类型的ResponseStatus
                除网络连接失败，DNS请求失败等原因ResponseStatus均为 Completed。
             */
            if (ResponseStatus != ResponseStatus.Completed)
            {
                log.Info("网络瘫痪,请检查网络!");
                log.Info("ResponseStatus : " + ResponseStatus + "\nResponseErrorMsg : " + ResponseErrorMsg + "\nResponseErrorException : " + ResponseErrorException);
                return false;
            }

            if(ResponseHttpStatus != System.Net.HttpStatusCode.OK)
            {
                log.Info("Http状态错误");
                log.Info("ResponseHttpStatus : " + ResponseHttpStatus + "\nResponseStatusDescription : " + ResponseStatusDescription + "\nResponseErrorMsg : " + ResponseErrorMsg + "\nResponseErrorException : " + ResponseErrorException);
                return false;
            }

            if (!IsSuccessful)
            {
                log.Info("Http请求失败");
                log.Info("ResponseErrorMsg : " + ResponseErrorMsg + "\nResponseErrorException : " + ResponseErrorException);
                return false;
            }


            return true;
        }

        


        /// <summary>
        /// 初始化
        /// </summary>
        public static void init()
        {
            if (IsInit) return;
            client = new RestClient(IP);
            client.UseJson();
            IsInit = true;  
        }


        /// <summary>
        /// 登入接口
        /// </summary>
        /// <param name="url">接口地址</param>
        /// <param name="jsonStr">Json数据</param>
        /// <returns></returns>
        public static JObject LoginRequests(string jsonStr,in CancellationToken CancelLogin)
        {
            init();
            string url = "Gpi/Login";
            log.Info("地址：" + url + "调用api json:" + jsonStr);
            string resResult = string.Empty;

            if (string.IsNullOrEmpty(url) || string.IsNullOrEmpty(jsonStr))
            {
                log.Info("URL或Json为空");
                return null;
            }
            // 请求登入
            var request = new RestRequest(url, Method.Post);

            // request.AddJsonBody(jobj);
            request.AddStringBody(jsonStr, DataFormat.Json);
            request.Timeout = TimeOut;
            var response = client.ExecuteAsync(request, CancelLogin);

            if (!CheckStatus(in response))
            {
                if (!string.IsNullOrEmpty(response.Result.Content))
                {
                    log.Info("调用推送数据接口异常:" + response.Result.Content);
                }
                else
                {
                    log.Info("调用推送数据接口异常:" + response.Result.ErrorMessage);
                }
                return null;
            }

            /// RestClient _restClient = new RestClient(GatewayUrl + url);

            resResult = response.Result.Content;
            JObject res = JObject.Parse(resResult);

            return res;
        }




        /// <summary>
        /// 请求接口
        /// </summary>
        /// <param name="url">接口地址</param>
        /// <param name="jsonStr">Json数据</param>
        /// <returns>失败则返回null</returns>
        public static JObject PushRequests(string url, string jsonStr)
        {
            init();
            if(!CheckOnline())return null;
            log.Info("地址：" + url + "调用api json:" + jsonStr);
            string resResult = string.Empty;

            if (string.IsNullOrEmpty(url) || string.IsNullOrEmpty(jsonStr))
            {
                log.Info("URL或Json为空");
                return null;
            }
            // 请求登入
            var request = new RestRequest(url, Method.Post);

            // request.AddJsonBody(jobj);
            request.AddStringBody(jsonStr, DataFormat.Json);
            request.Timeout = TimeOut;
            request.AddHeader("Authorization", Authorization);
            var response = client.ExecuteAsync(request);

            if (!CheckStatus(in response))
            {
                if (!string.IsNullOrEmpty(response.Result.Content))
                {
                    log.Info("调用推送数据接口异常:" + response.Result.Content);
                }
                else
                {
                    log.Info("调用推送数据接口异常:" + response.Result.ErrorMessage);
                }
                return null;
            }

            /// RestClient _restClient = new RestClient(GatewayUrl + url);

            resResult = response.Result.Content;
            return JObject.Parse(resResult);
        }



    }
}
