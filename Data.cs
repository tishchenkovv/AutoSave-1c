using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace AutoSave_1c
{
    public  class Data
    {

        string login        = string.Empty;
        string password     = string.Empty;
        string patch        = string.Empty;
        string patchSave    = string.Empty;
        string id           = string.Empty;
        string token        = string.Empty;

        public Data(string login, string password, string patch, string patchSave, string id, string token)
        {

            this.login      = login;
            this.password   = password;
            this.patch      = patch;
            this.patchSave  = patchSave;
            this.id         = id;
            this.token      = token;

        }

        public string Login { get => this.login; set => this.login = value;}
        public string Password { get => this.password; set => this.password = value;}
        public string Patch { get => this.patch; set => this.patch = value;}
        public string PatchSave { get => this.patchSave; set => this.patchSave = value; }
        public string ID { get => this.id; set => this.id = value; }
        public string TOKEN { get => this.token; set => this.token = value; }

        public static void SaveToJson(Data data)
        {

            try
            {
                string patchSetting = "setting.json";
                using (File.Exists(patchSetting) ? File.Open(patchSetting, FileMode.Open) : File.Create(patchSetting)) { }

                string dataJson = JsonConvert.SerializeObject(data);

                using (StreamWriter sw = new StreamWriter(patchSetting, false, System.Text.Encoding.UTF8))
                {
                    sw.WriteLine(dataJson);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        public static void DeleteJson()
        {
            try
            {
                string patchSetting = "setting.json";
                File.Delete(patchSetting);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static Data GetSetting()
        {

            Data data = null;

            try
            {
                string patchSetting = "setting.json";

                using (StreamReader stream = new StreamReader(patchSetting, System.Text.Encoding.UTF8))
                {

                    string dataJson = stream.ReadToEnd();

                    if (dataJson != string.Empty)
                    {
                        data = (Data)JsonConvert.DeserializeObject<Data>(dataJson);
                    }

                }

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return data;

        }

    }
}
