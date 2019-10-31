using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using System.Threading;
using AutoSave_1c.Properties;

namespace AutoSave_1c
{
    public partial class MainForm : Form
    {
        OneC oneC;
        Cloud_Yandex Yandex;
        Data data;
        bool AutoSave;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
  
            string[] lineArg = Environment.GetCommandLineArgs();

            int arg = (from i in lineArg where i == "/AutoSave" select i).Count();

            AutoSave = arg != 0?true:false;

        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            data = Data.GetSettingDefault();

            if (data != null && data is Data)
            {
                txtLogin.Text       = data.Login;
                txtPassword.Text    = data.Password;
                txtDataBase.Text    = data.Patch;
                txtSaveCatalog.Text = data.PatchSave;
                txbIDYandex.Text    = data.ID;
                txbTokenYandex.Text = data.TOKEN;

                if (AutoSave)
                {
                    AutoSaveCloud();
                }

            }
        }

        private void SelectFolder_Click(object sender, EventArgs e)
        {

            if (txtDataBase.Text != string.Empty)
            {

                DialogResult selectEventFolder = MessageBox.Show("Очитсть путь ?", "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (selectEventFolder == DialogResult.No) return;
                else txtDataBase.Text = string.Empty;
            }

            SelectDataBase.Description = "Выберите каталог с базой 1с";

            if (SelectDataBase.ShowDialog() == DialogResult.OK)
            {
                txtDataBase.Text = SelectDataBase.SelectedPath;
            }

        }

        private void BtnGetProcess_Click(object sender, EventArgs e)
        {

            List<Process> collectionProces = ProcessOneS.GetProcess1c();

            if (dgvPr.Rows.Count > 1)
            {

                dgvPr.Rows.Clear();

            }

            if (collectionProces.Count != 0)
            {
                foreach (Process str in collectionProces)
                {
                    var newstr = dgvPr.Rows.Add();
                    dgvPr.Rows[newstr].Cells["id"].Value = str.Id;
                    dgvPr.Rows[newstr].Cells["start"].Value = str.StartTime;
                    dgvPr.Rows[newstr].Cells["name"].Value = str.ProcessName;

                }
            }
        }

        private void BtnKillProces_Click(object sender, EventArgs e)
        {

            int[] ID_Process = new int[dgvPr.Rows.Count];
            int index = 0;

            foreach (DataGridViewRow row in dgvPr.Rows)
            {
                ID_Process[index] = (int)row.Cells["id"].Value;
                index++;
            }

            if (ID_Process.Length != 0)
            {
                ProcessOneS.KillProces(ID_Process);
                dgvPr.Rows.Clear();
            }
        }

        private void BtnConnect1c_Click(object sender, EventArgs e)
        {

            // Проверка заполнения
            if (txtLogin.Text == string.Empty || txtDataBase.Text == string.Empty || txtSaveCatalog.Text == string.Empty)
            {
                MessageBox.Show("Не все поля заполненны для подключения");
                return;

            }

            oneC = new OneC(txtLogin.Text, txtPassword.Text, txtDataBase.Text, txtSaveCatalog.Text);

            bool res = oneC.TestConnect();

            if (res)
            {
                MessageBox.Show("Успешно");
            }
            else
            {
                MessageBox.Show("Не удалось подключится");
            }

        }

        private void BtnSelectSaveCatalog_Click(object sender, EventArgs e)
        {

            txtSaveCatalog.Text = string.Empty;
            FolderBrowserDialog fp = new FolderBrowserDialog();
            fp.ShowNewFolderButton = false;

            if (fp.ShowDialog() == DialogResult.OK)
            {
                txtSaveCatalog.Text = fp.SelectedPath;
            }

        }

        private void BtnCreateBackup_Click(object sender, EventArgs e)
        {

            if (oneC == null)
            {
                // Проверка заполнения
                if (txtLogin.Text == string.Empty || txtDataBase.Text == string.Empty || txtSaveCatalog.Text == string.Empty)
                {
                    MessageBox.Show("Не все поля заполненны для подключения");
                    return;

                }

                oneC = new OneC(txtLogin.Text, txtPassword.Text, txtDataBase.Text, txtSaveCatalog.Text);
            }

            oneC.CreateBackup(AutoSave);

        }

        private void BtnCloudUpload_Click(object sender, EventArgs e)
        {

            if (oneC == null)
            {
                MessageBox.Show("Нет данных для выгрузки");
                return;

            }

            if (Yandex != null)
            {
                Yandex.UploadFile(oneC.NameFile,oneC.PatchBackup,AutoSave);
            }
            else
                if (txbIDYandex.Text != string.Empty && txbTokenYandex.Text != string.Empty)
            {
                Yandex = new Cloud_Yandex(txbIDYandex.Text, txbTokenYandex.Text);
                Yandex.UploadFile(oneC.NameFile,oneC.PatchBackup, AutoSave);

            }
            else
            {
                MessageBox.Show("Не заполненны данные для яндекс диска");
                return;
            }
          

        }

        private void BtnGetToken_Click(object sender, EventArgs e)
        {

            if (txbIDYandex.Text == string.Empty)
            {
                MessageBox.Show("Введите ID для получения токена");
                return;
            }

            if (Yandex == null)
            {
                Yandex = new Cloud_Yandex(txbIDYandex.Text);
            }
            else
            {
                Yandex.ID_YANDEX = txbIDYandex.Text;
            }
            Yandex.GetToken();
        }

        private void BtnCreateAppYandex_Click(object sender, EventArgs e)
        {

            if (Yandex == null)
            {
                Yandex = new Cloud_Yandex();
                Yandex.CreateApp();

            }
            else
            {
                Yandex.CreateApp();
            }

        }

        private void BtnConnectYandex_Click(object sender, EventArgs e)
        {

            if (txbTokenYandex.Text == string.Empty)
            {
                MessageBox.Show("Введите токен");
                return;
            }

            if (Yandex == null)
            {
                Yandex = new Cloud_Yandex(txbIDYandex.Text, txbTokenYandex.Text);
            }
            else
            {
                Yandex.TOKEN_YANDEX = txbTokenYandex.Text;
            }

             Yandex.TestConnect();

        }

        private void СохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data data = new Data(txtLogin.Text, txtPassword.Text, txtDataBase.Text,txtSaveCatalog.Text, txbIDYandex.Text, txbTokenYandex.Text);
            Data.Save(data);
        }

        private void СброситьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Settings.Default.Login      = "";
            Settings.Default.Password   = "";
            Settings.Default.Patch      = "";
            Settings.Default.PatchSave  = "";
            Settings.Default.ID         = "";
            Settings.Default.TOKEN      = "";
            Settings.Default.Save();

        }

        private  void  AutoSaveCloud()
        {
            try
            {
                Thread.Sleep(5000);
                BtnGetProcess_Click(null, null);
                BtnKillProces_Click(null, null);
                Cloud_Yandex.DeleteBackupCloud(txbTokenYandex.Text.Trim(),AutoSave);
                BtnCreateBackup_Click(null, null);
                BtnCloudUpload_Click(null, null);
                Environment.Exit(0);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
       
    }
}
