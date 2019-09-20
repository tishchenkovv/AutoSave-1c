using System;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Web;
using System.Web.Script.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace AutoSave_1c
{
    class Cloud_Yandex
    {

        string id_yandex = string.Empty;
        string token_yandex = string.Empty;

        public Cloud_Yandex() { }

        public Cloud_Yandex(string id_yandex)
        {
            this.id_yandex = id_yandex;
        }

        public Cloud_Yandex(string id_yandex, string token_yandex)
        {

            this.id_yandex = id_yandex;
            this.token_yandex = token_yandex;

        }

        public string ID_YANDEX { get => id_yandex; set => id_yandex = value; }

        public string TOKEN_YANDEX { get => token_yandex; set => token_yandex = value; }

        public void CreateApp()
        {
            string url = "https://oauth.yandex.ru/client/new";

            try
            {
                System.Diagnostics.Process.Start(url);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public void GetToken()
        {
            string url = string.Format("https://oauth.yandex.ru/authorize?response_type=token&client_id={0}", id_yandex);

            try
            {
                System.Diagnostics.Process.Start(url);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public void TestConnect()
        {

            decimal totalSpaceGB    = 0;
            decimal usedSpaceGB     = 0;
            string account          = string.Empty;
            byte answerServer       = 0;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://cloud-api.yandex.net/v1/disk/");
                request.Headers.Add(HttpRequestHeader.Authorization, token_yandex);
                request.Method = "GET";
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {

                   answerServer      = (byte)response.StatusCode;

                    using (Stream stream = response.GetResponseStream())
                    {
                        using(StreamReader streamReader = new StreamReader(stream))
                        {
                            string reader = streamReader.ReadToEnd();
                            dynamic array = JsonConvert.DeserializeObject(reader);

                            foreach (var str in array)
                            {

                                string name = ((Newtonsoft.Json.Linq.JProperty)str).Name;

                                if (name == "total_space")
                                {
                                    totalSpaceGB = decimal.Round((decimal)((Newtonsoft.Json.Linq.JProperty)str).Value / 1024 /1024 / 1024); 
                                }

                                if (name == "used_space")
                                {
                                    usedSpaceGB =   decimal.Round((decimal)((Newtonsoft.Json.Linq.JProperty)str).Value / 1024 / 1024 / 1024 ,2);
                                }

                                if (name == "user")
                                {
                                    foreach (var st in ((Newtonsoft.Json.Linq.JContainer)((Newtonsoft.Json.Linq.JProperty)str).Value))
                                    {
                                        string nameUser = ((Newtonsoft.Json.Linq.JProperty)st).Name;

                                        if (nameUser == "login")
                                        {
                                            account = (string)((Newtonsoft.Json.Linq.JProperty)st).Value;
                                        }

                                    }

                                }

                            }

                        }

                    }
                   
                }

                string MessageResult = $" Пользователь: {account}\n Объем диска: {totalSpaceGB} GB \n Занято место: {usedSpaceGB} GB\n Ответ сервера: {answerServer}";
                MessageBox.Show(MessageResult,"Информация",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            catch (WebException e)
            {
                MessageBox.Show(e.Status.ToString());
            }

        }

        public void UploadFile()
        {

            //string dstfile = "myfile.txt";
            //string srcfile = @"C:\myfile.txt";


        }

    }
}
