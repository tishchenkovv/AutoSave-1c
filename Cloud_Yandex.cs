using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace AutoSave_1c
{
     class Cloud_Yandex
    {

        string id_yandex = string.Empty;

        public Cloud_Yandex() { }

        public Cloud_Yandex(string id_yandex)
        {
            this.id_yandex = id_yandex;
        }

        public string ID_YANDEX { get => id_yandex; set => id_yandex = value;}

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

        public  void GetToken()
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

        public void UploadFile()
        {

            //string dstfile = "myfile.txt";
            //string srcfile = @"C:\myfile.txt";

            //string oauthToken = "AgAEA7qi591KAAXgJtRz2Q3k-EjBo5YeZC5yhOQ";

            //try
            //{
            //   // YandexDiskRest disk = new YandexDiskRest(oauthToken);
            //    //disk.CreateFolder("tt");
            //}
            //catch (Exception e)
            //{
            //    MessageBox.Show(e.Message);

            //}


//const string clientId = "4bf7d46404fa48dda7a5138434bae682";
//const string clientSecret = "6ccbc166f9d6465eacd8e31a210c4359";




        }

    }
}
