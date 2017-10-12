using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo02_GetTimeFromBaidu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        /// <summary>  
        /// 获取国家授时中心网提供的时间。（授时中心连接经常出状况，暂时用百度网代替）  
        /// 通过分析网页报头，查找Date对应的值，获得GMT格式的时间。可通过GMT2Local(string gmt)方法转化为本地时间格式。  
        /// 用法 DateTime netTime = GetNetTime.GMT2Local(GetNetTime.GetNetDate());  
        /// </summary>  
        /// <returns></returns>  
        public static string GetNetDate()
        {
            try
            {
                //WebRequest request = WebRequest.Create("http://www.time.ac.cn");//国家授时中心经常连接不上  
                WebRequest request = WebRequest.Create("http://www.baidu.com");
                request.Credentials = CredentialCache.DefaultCredentials;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                WebHeaderCollection myWebHeaderCollection = response.Headers;
                for (int i = 0; i < myWebHeaderCollection.Count; i++)
                {
                    string header = myWebHeaderCollection.GetKey(i);
                    string[] values = myWebHeaderCollection.GetValues(header);
                    if (header.Length <= 0 || header == null)
                    {
                        return null;
                    }
                    else if (header == "Date")
                    {
                        return values[0];
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btn_getTime_Click(object sender, EventArgs e)
        {
            string dt = GetNetDate();
            tb_log.Text += Convert.ToDateTime(dt).Year.ToString() + Convert.ToDateTime(dt).Month.ToString() + Convert.ToDateTime(dt).Day.ToString() + Convert.ToDateTime(dt).Hour.ToString() + "\r\n";
        }
    }
}
