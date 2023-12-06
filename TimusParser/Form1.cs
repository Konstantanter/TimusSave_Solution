using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection.Emit;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace TimusParser
{
    public partial class Form1 : Form
    {
        int state = 3;
        int index = 0;
        int done = 0, prob = 1000;
        HtmlDocument tdoc;
        string bpath = "C:\\Users\\BRONUF\\Desktop\\" + "\\timus\\";
        int subc = 0;
        string JudgeID;
        public Form1()
        {
            InitializeComponent();
        }
        class AppendClass
        {
            public string Task;
            public string Link;
            public AppendClass(string task, string link)
            {
                Task = task;
                Link = link;
            }
        }
        List<AppendClass> appensClass = new List<AppendClass>();
       

        Submission[] subs = new Submission[1000];

        private void buttonStart_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://acm.timus.ru/authedit.aspx");
        }
       
        

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            HtmlDocument doc = null;
            switch (state)
            {
                case 3:
                    JudgeID = textBoxJUDGE.Text.Substring(0, textBoxJUDGE.Text.Length - 2);
                    webBrowser1.Navigate("http://acm.timus.ru/status.aspx?space=1&num=" + prob.ToString().Trim() + "&author=" + JudgeID + "&refresh=0&count=1000");
                    state = 4;
                    break;
                case 4:
                    doc = webBrowser1.Document;
                    tdoc = doc;
                    work();
                    //System.Threading.Thread th = new System.Threading.Thread(work);
                    //th.Start();
                    break;
                case 8:
                    if (prob < Convert.ToInt32(textTaskCount.Text)+1)
                    {
                        foreach(var el in appensClass)
                        {
                            fin(System.IO.Path.GetFileName(el.Link));
                        }
                        state = 3;
                        prob++;
                        webBrowser1.Navigate("about:blank"); 
                    }
                    else
                    {
                        MessageBox.Show("Скачивание завершено");
                    }
                    break;
            }
        }
        

       

        bool IsNumeric(string value)
        {
            return value.All(char.IsNumber);
        }

     
        async void fin(string filename)
        {
            using (HttpClient client = new HttpClient())
            {
                // Устанавливаем базовый URL
                client.BaseAddress = new Uri("https://acm.timus.ru/");
                // Создаем параметры запроса
                var parameters = new Dictionary<string, string>{
                         { "Action", "getsubmit" },
                         { "JudgeID", textBoxJUDGE.Text},
                       { "Password", textBoxPass.Text }
                };
                // Создаем кодированный контент из параметров
                var content = new FormUrlEncodedContent(parameters);
                // Отправляем POST-запрос и получаем ответ
                var response = await client.PostAsync($"/getsubmit.aspx/{filename}", content);
                // Читаем содержимое ответа
                var responseContent = await response.Content.ReadAsStringAsync();
                string file = $"{prob-1}_{filename}";  
                string bpath = "C:\\timus\\";
                bpath = System.IO.Path.Combine(bpath, file);
                System.IO.File.WriteAllText(bpath, responseContent, Encoding.Default);

            }
        }
        void work()
        {
            appensClass = new List<AppendClass>();
            var els = tdoc.GetElementsByTagName("tr");
            subc = 0;
            foreach (HtmlElement el in els)
            {
                if (el.GetAttribute("className") == "even" || el.GetAttribute("className") == "odd")
                {
                    foreach (HtmlElement ch in el.Children)
                    {
                        switch (ch.GetAttribute("className"))
                        {
                            case "id":
                                subs[subc].ID = ch.FirstChild.InnerText;
                                subs[subc].Link = ch.FirstChild.GetAttribute("href");
                                break;
                            case "date":
                                subs[subc].Dat = ch.Children[0].InnerText + " " + ch.Children[2].InnerText;
                                break;
                            case "language":
                                subs[subc].Language = ch.InnerText;
                                break;
                            case "test":
                                if (ch.InnerText != null && ch.InnerText != "")
                                {
                                    subs[subc].Test = IsNumeric(ch.InnerText) ? ch.InnerText : "";
                                }
                                break;
                            default:
                                if (ch.GetAttribute("className").StartsWith("verdict"))
                                {
                                    subs[subc].Result = ch.InnerText;
                                }
                                break;
                        }
                    }
                    subc++;
                }
            }
           
            try
            {
                Directory.Delete(bpath, true);
            }
            catch (Exception)
            {

            }

            HttpWebRequest req = null;

            for (int i = 0; i < subc; i++)
            {

                if (subs[i].Result == "Accepted")
                {
                    
                   appensClass.Add(new AppendClass(prob.ToString(), subs[i].Link));
                    // state = 6;
                    // massString.Add(subs[i].Link);

                }
            }
            state = 8;
           // MessageBox.Show("!");
            //state = 3;
            //prob++;
            webBrowser1.Navigate("about:blank");

            // webBrowser1.Navigate(subs[0].Link);


            //for (int i = 0; i < subc; i++)
            //{

            //    req = (HttpWebRequest)HttpWebRequest.Create(subs[i].Link);

            //    req.Method = "GET";
            //    CookieContainer cookies = new CookieContainer();
            //    req.CookieContainer = cookies;
            //    req.GetResponse().Close();
            //    Application.DoEvents();
            //    req = (HttpWebRequest)HttpWebRequest.Create(subs[i].Link);
            //    req.Method = "POST";
            //    req.ContentType = "application/x-www-form-urlencoded";
            //    req.ContentLength = postdata.Length;
            //    req.GetRequestStream().Write(postdata, 0, postdata.Length);
            //    req.Accept = "*/*";
            //    req.Referer = subs[i].Link;
            //    req.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/37.0.2062.124 Safari/537.36";
            //    req.CookieContainer = cookies;
            //    HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            //    Application.DoEvents();
            //    StreamReader reader = new StreamReader(resp.GetResponseStream());
            //    string ts = reader.ReadToEnd();
            //    reader.Close();
            //    resp.Close();



            //    string fname = "{prob}.{fmt}";
            //    fname = fname.Replace("{prob}", prob.ToString().Trim());
            //    fname = fname.Replace("{fmt}", findExt(subs[i].Link));


            //    //bpath = 

            //    // fname = fname.Replace("{fmt}", IsNumeric(subs[i]));
            //    File.WriteAllText(bpath + "\\" + fname, ts);

            //}
            // ProgressBar2.Value = (int)(100.0 * (i + 1) / subc > 100 ? 100 : 100.0 * (i + 1) / subc);


        }
    }
}
