using SolarEdgeGadget;
using SolarEdgeGagdet.Properties;
using System;
using System.Configuration;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;

namespace SolarEdgeGagdet
{
    public class SolarEdge
    {

        public SolarEdgeData GetData()
        {
            var cookiejar = new CookieContainer();
            Login(ref cookiejar);

            var request = (HttpWebRequest)WebRequest.Create("https://monitoring.solaredge.com/solaredge-web/p/dashboard_data?fieldId=" + Settings.Default.SiteId);
            request.CookieContainer = cookiejar;

            var response = (HttpWebResponse)request.GetResponse();
            var data = response.GetResponseStream();
            var reader = new StreamReader(data);
            var result = reader.ReadToEnd();

            result = Regex.Replace(result, @"GMTOffset:new Date\(\d+\)\.getTimezoneOffset\(\)\*60000", "GMTOffset: " + TimeZoneInfo.Local.GetUtcOffset(DateTime.Now).Hours);
            var parsedData = new JavaScriptSerializer().Deserialize<SolarEdgeData>(result);

            reader.Close();
            data.Close();
            response.Close();
            return parsedData;
        }

        void Login(ref CookieContainer cookiejar)
        {
            var request = (HttpWebRequest)WebRequest.Create("https://monitoring.solaredge.com/solaredge-web/p/submitLogin");
            request.CookieContainer = cookiejar;
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
            using (var writer = new StreamWriter(request.GetRequestStream()))
            {
                writer.Write("cmd=login&demo=false&username={0}&password={1}", HttpUtility.UrlEncode(Settings.Default.Username), Encryption.ToInsecureString(Encryption.DecryptString(Settings.Default.Password)));
                writer.Flush();
            }
            

            using (var response = (HttpWebResponse)request.GetResponse())
            {
                var data = response.GetResponseStream();
                using (var reader = new StreamReader(data))
                {
                    var result = reader.ReadToEnd();
                    reader.Close();
                    data.Close();
                    response.Close();
                    if (Regex.Match(result, "Failure", RegexOptions.IgnoreCase).Success)
                    {
                        throw new Exception("Login Failure");
                    }
                }
            }
        }
    }
}
