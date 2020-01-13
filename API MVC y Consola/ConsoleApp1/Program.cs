using System;


using System.IO;
using System.Net;
using System.Text;
using System.Web;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(call1());
            Console.WriteLine(call2());
           
        }


        static string call1()
        {
            try
            { 
                WebRequest request = WebRequest.Create("http://localhost:59904/api/test1");
                WebResponse response = request.GetResponse();

                Stream str = response.GetResponseStream();
                StreamReader reader = new StreamReader(str);
                string resp = reader.ReadToEnd();
                return resp;
            }
            catch (Exception)
            {

                throw;
            }
        }

       
       static string call2()
        {
            WebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost:59904/api/test2");
            request.Headers.Add("headervalue", "headerval");
            request.ContentType = "application/x-www-form-urlencoded";
            request.Method = "POST";
            StringBuilder postData = new StringBuilder();
            postData.Append("formvalue1=" + HttpUtility.UrlEncode("val1") + "&");
            postData.Append("formvalue2=" + HttpUtility.UrlEncode("val2"));

            var dat = System.Text.Encoding.UTF8.GetBytes(postData.ToString());
            using (var stream = request.GetRequestStream())
            {
                stream.Write(dat, 0, dat.Length);
            }

            WebResponse response = request.GetResponse();
            Stream str = response.GetResponseStream();
            StreamReader reader = new StreamReader(str);
            string resp = reader.ReadToEnd();
            return resp;
        }
    }
}
