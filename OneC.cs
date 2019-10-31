using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using AutoSave_1c.Properties;

namespace AutoSave_1c
{
    class OneC
    {

        string login            = string.Empty;
        string password         = string.Empty;
        string patch            = string.Empty;
        string patchDatabase    = string.Empty;
        string catalogSave      = string.Empty;
        string nameFile         = string.Empty;
        string patchBackup      = string.Empty;
        string stringConnect    = string.Empty;

        public OneC(string login, string password, string patch, string catalogSave)
        {
            this.login = login;
            this.password = password;
            this.patch = patch;
            this.catalogSave = catalogSave;

            // Формирование строки подключения
            stringConnect = $"file={patch}; usr={login}; pwd={password};";

        }

        public string Login { get => this.login; set => this.login = value; }

        public string Password { get => this.password; set => this.password = value; }

        public string Patch { get => this.patch; set => this.patch = value; }

        public string CatalogSave { get => catalogSave; set => catalogSave = value; }

        public string NameFile { get => this.nameFile;}

        public string PatchBackup { get => this.patchBackup; }

        public bool TestConnect()
        {

            bool result = false;

            V83.COMConnector connector = new V83.COMConnector();
            try
            {
                connector.Connect(stringConnect);
                result      = true;
                connector   = null;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                result = false;
            }

            return result;
        }

        public void CreateBackup(bool AutoSave)
        {

            // определить версию 1с x32 или x64
            bool isOneCx32 = false;
            bool isOneCx64 = false;

            string OneCx32 = @"C:\Program Files (x86)\1cv8\common\1cestart.exe";
            string OneCx64 = @"C:\Program Files\1cv8\common\1cestart.exe";

            if (File.Exists(OneCx32))
            {
                isOneCx32 = true;
            }

            if (File.Exists(OneCx64))
            {
                isOneCx64 = true;
            }


            if (isOneCx32 == false && isOneCx64 == false)
            {
                MessageBox.Show("Не обнаружена программа 1с");
                return;
            }

            var CurrentDate = DateTime.Now;
            string NameBackup           = @"Database_" + CurrentDate.ToString("yyyy/MM/dd_HH_mm") + ".dt";
            string FullPatchBackup      = catalogSave +"\\" + NameBackup;
            string patchQuote           = @"" + patch + "";
            string loginQuote           = @"" + login + "";
            string passwordQuote        = @"" + password + "";
            string FullPatchBackupQuote = @"" + FullPatchBackup + "";
            string arg                  = string.Empty;

            if (passwordQuote == string.Empty)
            {
                arg = $"CONFIG /F{patchQuote} /N {loginQuote} /DumpIB {FullPatchBackupQuote}";
            }
            else
            {
                arg = $"CONFIG /F{patchQuote} /N {loginQuote} /P {passwordQuote} /DumpIB {FullPatchBackupQuote}";
            }
            string RunArg = string.Empty;

            if (isOneCx32)
            {
                RunArg = OneCx32;
            }
            else
            {
                RunArg = OneCx64;
            }

            try
            {
                var pr = System.Diagnostics.Process.Start(RunArg, arg);
                pr.WaitForExit();

                while (System.Diagnostics.Process.GetProcessesByName("1cv8").Length != 0)
                {
                    Thread.Sleep(20000);
                    continue;
                }

                this.nameFile               = NameBackup;
                this.patchBackup            = FullPatchBackup;


                if (!AutoSave)
                {
                    MessageBox.Show("База успешно сохранена");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }

    }
}
