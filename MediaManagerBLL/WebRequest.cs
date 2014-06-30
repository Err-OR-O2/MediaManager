using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Threading.Tasks;

namespace MediaManagerBLL
{
    public class WebRequest
    {

        /// <summary>  
        /// 设置主机ip地址  
        /// </summary>  
        private string strHost;
        public string Host
        {
            get
            {
                return strHost;

            }
            set
            {
                strHost = value;
            }
        }
        /// <summary>  
        /// httpwebrequest类中的一些属性的集合  
        /// </summary>  
        public struct RequestPPT
        {
            private string strAccept;
            /// <summary>  
            /// 获取或设置request类中的Accept属性  
            /// 用以设置接受的文件类型  
            /// </summary>              
            public string Accept
            {
                get
                {
                    return strAccept;
                }
                set
                {
                    strAccept = value;
                }
            }
            private string strContentType;
            /// <summary>  
            /// 获取或设置request类中的ContentType属性  
            /// 用以设置请求的媒体类型  
            /// </summary>            
            public string ContentType
            {
                get
                {
                    return strContentType;
                }
                set
                {
                    strContentType = value;
                }
            }
            /// <summary>  
            /// 获取或设置request类中的UserAgent属性  
            /// 用以设置请求的客户端信息  
            /// </summary>  
            private string strUserAgent;
            public string UserAgent
            {
                get
                {
                    return strUserAgent;
                }
                set
                {
                    strUserAgent = value;
                }
            }
            private string strMethod;
            /// <summary>  
            /// 获取或设置request类中的Method属性  
            /// 可以将 Method 属性设置为任何 HTTP 1.1 协议谓词：GET、HEAD、POST、PUT、DELETE、TRACE 或 OPTIONS。  
            /// 如果 ContentLength 属性被设置为 -1 以外的任何值，则必须将 Method 属性设置为上载数据的协议属性。  
            /// </summary>              
            public string Method
            {
                get
                {
                    return strMethod;
                }
                set
                {
                    strMethod = value;
                }
            }
        }
        /// <summary>  
        /// 根据泛型来构建字符串用于post  
        /// </summary>  
        /// <param name="dir">带有键值对的泛型</param>  
        /// <returns>构建完毕的字符串</returns>  
        private string funMakePost(Dictionary<string, string> dir)
        {
            string strPost = "";
            foreach (KeyValuePair<string, string> kvp in dir)
            {
                strPost += kvp.Key + "=";
                if (kvp.Value == "")
                {
                    strPost += "''";
                }
                else
                {
                    strPost += kvp.Value;
                }
                strPost += "&";
            }
            strPost = strPost.Substring(0, strPost.Length - 1);
            return strPost;
        } 
        /// <summary>  
        /// 获取目标登录链接的cookies  
        /// </summary>  
        /// <param name="url">目标的登录链接</param>  
        /// <param name="dir">构造头的泛型键值对</param>  
        /// <param name="strHtml">登录后返回的页面内容</param>  
        /// <returns>登录后的cookies</returns>  
        public CookieCollection funGetCookie(string url, Dictionary<string, string> dir, out string strHtml)
        {
            CookieCollection cc = new CookieCollection();
            RequestPPT rppt = new RequestPPT();

            //构建post内容  
            string strPost = funMakePost(dir);
            byte[] post = Encoding.Default.GetBytes(strPost);

            //设置标头属性  
            rppt.Accept = "image/gif, image/x-xbitmap, image/jpeg, image/pjpeg, application/x-shockwave-flash, application/vnd.ms-excel, application/vnd.ms-powerpoint, application/msword, */*";
            rppt.ContentType = "application/x-www-form-urlencoded";
            rppt.Method = "Post";
            rppt.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; SV1; .NET CLR 1.1.4322; InfoPath.1; .NET CLR 2.0.50727; .NET CLR 3.0.04506.648; .NET CLR 3.5.21022)";
            string server = "http://" + new Uri(url).Host;
            return cc = funGetCookie(url, post, out strHtml, rppt, server);
        }
        /// <summary>  
        /// 构建一个httt请求以获取目标链接的cookies,需要传入目标的登录地址和相关的post信息,返回完成登录的cookies,以及返回的html内容  
        /// </summary>  
        /// <param name="url">登录页面的地址  
        /// <param name="post">post信息  
        /// <param name="strHtml">输出的html代码  
        /// <param name="rppt">请求的标头所需要的相关属性设置  
        /// <returns>请求完成后的cookies</returns>  
        public CookieCollection funGetCookie(string url, byte[] post, out string strHtml, RequestPPT rppt, string server)
        {

            CookieCollection ckclReturn = new CookieCollection();
            CookieContainer cc = new CookieContainer();
            HttpWebRequest hwRequest;
            HttpWebResponse hwResponse;
            //请求cookies的格式  
            //hwRequest = (HttpWebRequest)HttpWebRequest.Create(new Uri(url));  
            //hwResponse = (HttpWebResponse)hwRequest.GetResponse();  
            //string cookie = hwResponse.Headers.Get("Set-Cookie");  
            //cookie = cookie.Split(';')[0];  
            //hwRequest = null;  
            //hwResponse = null;  
            //构建即将发送的包头  
            //cc.SetCookies(new Uri(server), cookie);             
            hwRequest = (HttpWebRequest)HttpWebRequest.Create(new Uri(url));
            hwRequest.CookieContainer = cc;
            hwRequest.Accept = rppt.Accept;
            hwRequest.ContentType = rppt.ContentType;
            hwRequest.UserAgent = rppt.UserAgent;
            hwRequest.Method = rppt.Method;
            hwRequest.ContentLength = post.Length;
            //写入标头  
            Stream stream;
            stream = hwRequest.GetRequestStream();
            stream.Write(post, 0, post.Length);
            stream.Close();
            //发送请求获取响应内容  
            try
            {
                hwResponse = (HttpWebResponse)hwRequest.GetResponse();
            }
            catch
            {
                strHtml = "";
                return ckclReturn;
            }
            stream = hwResponse.GetResponseStream();
            StreamReader sReader = new StreamReader(stream, Encoding.Default);
            strHtml = sReader.ReadToEnd();
            sReader.Close();
            stream.Close();
            //获取缓存内容  
            ckclReturn = hwResponse.Cookies;
            return ckclReturn;
        }
        /// <summary>  
        /// 根据已经获取到cookies来获取目标链接的内容  
        /// </summary>  
        /// <param name="strUri">目标的url</param>  
        /// <param name="ccl">已经获取好的cookies</param>  
        /// <returns>目标url的纯文本:"txt/html"</returns>  
        public string funGetHtmlByCookies(string strUri, CookieCollection ccl)
        {

            RequestPPT rppt = new RequestPPT();
            //设置头属性  
            rppt.Accept = "txt/html";
            rppt.ContentType = "application/x-www-form-urlencoded";
            rppt.Method = "Post";
            rppt.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; SV1; .NET CLR 1.1.4322; InfoPath.1; .NET CLR 2.0.50727; .NET CLR 3.0.04506.648; .NET CLR 3.5.21022)";
            return funGetHtmlByCookies(strUri, ccl, rppt);
        }
        /// <summary>  
        /// 根据已经获取的有效cookies来获取目标链接的内容  
        /// </summary>  
        /// <param name="strUri">目标链接的url  
        /// <param name="ccl">已经获取到的有效cookies  
        /// <param name="rppt">头属性的相关设置  
        /// <returns>目标连接的纯文本:"txt/html"</returns>  
        public string funGetHtmlByCookies(string strUri, CookieCollection ccl, RequestPPT rppt)
        {
            CookieContainer cc = new CookieContainer();
            HttpWebRequest hwRequest;
            HttpWebResponse hwResponse;

            //构建即将发送的包头         
            hwRequest = (HttpWebRequest)HttpWebRequest.Create(new Uri(strUri));
            cc.Add(ccl);
            hwRequest.CookieContainer = cc;
            hwRequest.Accept = rppt.Accept;
            hwRequest.ContentType = rppt.ContentType;
            hwRequest.UserAgent = rppt.UserAgent;
            hwRequest.Method = rppt.Method;
            hwRequest.ContentLength = 0;

            //发送请求获取响应内容  
            try
            {
                hwResponse = (HttpWebResponse)hwRequest.GetResponse();
            }
            catch
            {
                return "";
            }

            Stream stream;
            stream = hwResponse.GetResponseStream();
            StreamReader sReader = new StreamReader(stream, Encoding.Default);
            string strHtml = sReader.ReadToEnd();
            sReader.Close();
            stream.Close();

            //返回值            
            return strHtml;
        }
        /// <summary>  
        /// 根据已经获取的有效cookies来获取目标链接的内容  
        /// </summary>  
        /// <param name="strUri">目标链接的url  
        ///<param name="post">post的byte信息  
        /// <param name="ccl">已经获取到的有效cookies  
        /// <param name="rppt">头属性的相关设置  
        /// <returns>目标连接的纯文本:"txt/html"</returns>  
        public string funGetHtmlByCookies(string strUri, byte[] post, CookieCollection ccl, RequestPPT rppt)
        {
            CookieContainer cc = new CookieContainer();
            HttpWebRequest hwRequest;
            HttpWebResponse hwResponse;

            //构建即将发送的包头         
            hwRequest = (HttpWebRequest)HttpWebRequest.Create(new Uri(strUri));
            cc.Add(ccl);
            hwRequest.CookieContainer = cc;
            hwRequest.Accept = rppt.Accept;
            hwRequest.ContentType = rppt.ContentType;
            hwRequest.UserAgent = rppt.UserAgent;
            hwRequest.Method = rppt.Method;
            hwRequest.ContentLength = post.Length;
            //写入post信息  
            Stream stream;
            stream = hwRequest.GetRequestStream();
            stream.Write(post, 0, post.Length);
            stream.Close();
            //发送请求获取响应内容  
            try
            {
                hwResponse = (HttpWebResponse)hwRequest.GetResponse();
            }
            catch
            {
                return "";
            }

            stream = hwResponse.GetResponseStream();
            StreamReader sReader = new StreamReader(stream, Encoding.Default);
            string strHtml = sReader.ReadToEnd();
            sReader.Close();
            stream.Close();

            //返回值            
            return strHtml;
        }

    }
}
