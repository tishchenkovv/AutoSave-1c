﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace AutoSave_1c
{
    public partial class MainForm : Form
    {
        OneC oneC;

        public MainForm()
        {
            InitializeComponent();
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

            List<Process> collectionProces  = ProcessOneS.GetProcess1c();

            if (dgvPr.Rows.Count > 1)
            {

                dgvPr.Rows.Clear();

            }

            if (collectionProces.Count != 0)
            {
                foreach (Process str in collectionProces)
                {
                    var newstr = dgvPr.Rows.Add();
                    dgvPr.Rows[newstr].Cells["id"].Value        = str.Id;
                    dgvPr.Rows[newstr].Cells["start"].Value     = str.StartTime;
                    dgvPr.Rows[newstr].Cells["name"].Value      = str.ProcessName;
                    
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

            oneC.CreateBackup();

        }
    }
}
