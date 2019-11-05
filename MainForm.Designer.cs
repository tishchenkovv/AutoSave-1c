namespace AutoSave_1c
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPr = new System.Windows.Forms.DataGridView();
            this.start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSelectSaveCatalog = new System.Windows.Forms.Button();
            this.txtSaveCatalog = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SelectFolder = new System.Windows.Forms.Button();
            this.txtDataBase = new System.Windows.Forms.TextBox();
            this.lblDataBase = new System.Windows.Forms.Label();
            this.btnConnect1c = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.btnGetProcess = new System.Windows.Forms.Button();
            this.btnKillProcess = new System.Windows.Forms.Button();
            this.btnCreateBackup = new System.Windows.Forms.Button();
            this.btnCloudUpload = new System.Windows.Forms.Button();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сброситьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectDataBase = new System.Windows.Forms.FolderBrowserDialog();
            this.grbCloudYandex = new System.Windows.Forms.GroupBox();
            this.btnConnectYandex = new System.Windows.Forms.Button();
            this.btnCreateAppYandex = new System.Windows.Forms.Button();
            this.btnGetToken = new System.Windows.Forms.Button();
            this.txbTokenYandex = new System.Windows.Forms.TextBox();
            this.txbIDYandex = new System.Windows.Forms.TextBox();
            this.lblPasswordYandex = new System.Windows.Forms.Label();
            this.lblLoginYandex = new System.Windows.Forms.Label();
            this.lblDeveloper = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPr)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.grbCloudYandex.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvPr);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Запущенные процессы 1с";
            // 
            // dgvPr
            // 
            this.dgvPr.AllowUserToAddRows = false;
            this.dgvPr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.start,
            this.id,
            this.name});
            this.dgvPr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPr.Location = new System.Drawing.Point(3, 16);
            this.dgvPr.Name = "dgvPr";
            this.dgvPr.Size = new System.Drawing.Size(644, 163);
            this.dgvPr.TabIndex = 0;
            // 
            // start
            // 
            this.start.HeaderText = "start";
            this.start.Name = "start";
            this.start.ReadOnly = true;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnSelectSaveCatalog);
            this.groupBox2.Controls.Add(this.txtSaveCatalog);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.SelectFolder);
            this.groupBox2.Controls.Add(this.txtDataBase);
            this.groupBox2.Controls.Add(this.lblDataBase);
            this.groupBox2.Controls.Add(this.btnConnect1c);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.txtLogin);
            this.groupBox2.Location = new System.Drawing.Point(12, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(650, 156);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Авторизация 1c";
            // 
            // btnSelectSaveCatalog
            // 
            this.btnSelectSaveCatalog.Location = new System.Drawing.Point(379, 117);
            this.btnSelectSaveCatalog.Name = "btnSelectSaveCatalog";
            this.btnSelectSaveCatalog.Size = new System.Drawing.Size(24, 23);
            this.btnSelectSaveCatalog.TabIndex = 10;
            this.btnSelectSaveCatalog.Text = "...";
            this.btnSelectSaveCatalog.UseVisualStyleBackColor = true;
            this.btnSelectSaveCatalog.Click += new System.EventHandler(this.BtnSelectSaveCatalog_Click);
            // 
            // txtSaveCatalog
            // 
            this.txtSaveCatalog.Location = new System.Drawing.Point(91, 120);
            this.txtSaveCatalog.Name = "txtSaveCatalog";
            this.txtSaveCatalog.Size = new System.Drawing.Size(312, 20);
            this.txtSaveCatalog.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Каталог сох..";
            // 
            // SelectFolder
            // 
            this.SelectFolder.Location = new System.Drawing.Point(378, 91);
            this.SelectFolder.Name = "SelectFolder";
            this.SelectFolder.Size = new System.Drawing.Size(25, 20);
            this.SelectFolder.TabIndex = 7;
            this.SelectFolder.Text = "...";
            this.SelectFolder.UseVisualStyleBackColor = true;
            this.SelectFolder.Click += new System.EventHandler(this.SelectFolder_Click);
            // 
            // txtDataBase
            // 
            this.txtDataBase.Location = new System.Drawing.Point(91, 91);
            this.txtDataBase.Name = "txtDataBase";
            this.txtDataBase.Size = new System.Drawing.Size(312, 20);
            this.txtDataBase.TabIndex = 6;
            // 
            // lblDataBase
            // 
            this.lblDataBase.AutoSize = true;
            this.lblDataBase.Location = new System.Drawing.Point(6, 91);
            this.lblDataBase.Name = "lblDataBase";
            this.lblDataBase.Size = new System.Drawing.Size(77, 13);
            this.lblDataBase.TabIndex = 5;
            this.lblDataBase.Text = "Каталог базы";
            // 
            // btnConnect1c
            // 
            this.btnConnect1c.Location = new System.Drawing.Point(474, 32);
            this.btnConnect1c.Name = "btnConnect1c";
            this.btnConnect1c.Size = new System.Drawing.Size(161, 95);
            this.btnConnect1c.TabIndex = 4;
            this.btnConnect1c.Text = "Проверить подключения";
            this.btnConnect1c.UseVisualStyleBackColor = true;
            this.btnConnect1c.Click += new System.EventHandler(this.BtnConnect1c_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(91, 59);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(312, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(91, 28);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(312, 20);
            this.txtLogin.TabIndex = 0;
            // 
            // btnGetProcess
            // 
            this.btnGetProcess.Location = new System.Drawing.Point(369, 216);
            this.btnGetProcess.Name = "btnGetProcess";
            this.btnGetProcess.Size = new System.Drawing.Size(137, 32);
            this.btnGetProcess.TabIndex = 2;
            this.btnGetProcess.Text = "Получить процессы 1с";
            this.btnGetProcess.UseVisualStyleBackColor = true;
            this.btnGetProcess.Click += new System.EventHandler(this.BtnGetProcess_Click);
            // 
            // btnKillProcess
            // 
            this.btnKillProcess.Location = new System.Drawing.Point(512, 216);
            this.btnKillProcess.Name = "btnKillProcess";
            this.btnKillProcess.Size = new System.Drawing.Size(141, 32);
            this.btnKillProcess.TabIndex = 3;
            this.btnKillProcess.Text = "Завершить процессы 1с";
            this.btnKillProcess.UseVisualStyleBackColor = true;
            this.btnKillProcess.Click += new System.EventHandler(this.BtnKillProces_Click);
            // 
            // btnCreateBackup
            // 
            this.btnCreateBackup.Location = new System.Drawing.Point(318, 532);
            this.btnCreateBackup.Name = "btnCreateBackup";
            this.btnCreateBackup.Size = new System.Drawing.Size(137, 23);
            this.btnCreateBackup.TabIndex = 4;
            this.btnCreateBackup.Text = "Созать копию базы";
            this.btnCreateBackup.UseVisualStyleBackColor = true;
            this.btnCreateBackup.Click += new System.EventHandler(this.BtnCreateBackup_Click);
            // 
            // btnCloudUpload
            // 
            this.btnCloudUpload.Location = new System.Drawing.Point(473, 532);
            this.btnCloudUpload.Name = "btnCloudUpload";
            this.btnCloudUpload.Size = new System.Drawing.Size(183, 23);
            this.btnCloudUpload.TabIndex = 5;
            this.btnCloudUpload.Text = "Выгрузить в облако";
            this.btnCloudUpload.UseVisualStyleBackColor = true;
            this.btnCloudUpload.Click += new System.EventHandler(this.BtnCloudUpload_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(674, 24);
            this.MainMenu.TabIndex = 6;
            this.MainMenu.Text = "Главное меню";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.сброситьToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.СохранитьToolStripMenuItem_Click);
            // 
            // сброситьToolStripMenuItem
            // 
            this.сброситьToolStripMenuItem.Name = "сброситьToolStripMenuItem";
            this.сброситьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.сброситьToolStripMenuItem.Text = "Сбросить";
            this.сброситьToolStripMenuItem.Click += new System.EventHandler(this.СброситьToolStripMenuItem_Click);
            // 
            // SelectDataBase
            // 
            this.SelectDataBase.ShowNewFolderButton = false;
            // 
            // grbCloudYandex
            // 
            this.grbCloudYandex.Controls.Add(this.btnConnectYandex);
            this.grbCloudYandex.Controls.Add(this.btnCreateAppYandex);
            this.grbCloudYandex.Controls.Add(this.btnGetToken);
            this.grbCloudYandex.Controls.Add(this.txbTokenYandex);
            this.grbCloudYandex.Controls.Add(this.txbIDYandex);
            this.grbCloudYandex.Controls.Add(this.lblPasswordYandex);
            this.grbCloudYandex.Controls.Add(this.lblLoginYandex);
            this.grbCloudYandex.Location = new System.Drawing.Point(13, 416);
            this.grbCloudYandex.Name = "grbCloudYandex";
            this.grbCloudYandex.Size = new System.Drawing.Size(640, 109);
            this.grbCloudYandex.TabIndex = 7;
            this.grbCloudYandex.TabStop = false;
            this.grbCloudYandex.Text = "Яндекс";
            // 
            // btnConnectYandex
            // 
            this.btnConnectYandex.Location = new System.Drawing.Point(473, 76);
            this.btnConnectYandex.Name = "btnConnectYandex";
            this.btnConnectYandex.Size = new System.Drawing.Size(161, 23);
            this.btnConnectYandex.TabIndex = 6;
            this.btnConnectYandex.Text = "Проверить подключение";
            this.btnConnectYandex.UseVisualStyleBackColor = true;
            this.btnConnectYandex.Click += new System.EventHandler(this.BtnConnectYandex_Click);
            // 
            // btnCreateAppYandex
            // 
            this.btnCreateAppYandex.Location = new System.Drawing.Point(473, 13);
            this.btnCreateAppYandex.Name = "btnCreateAppYandex";
            this.btnCreateAppYandex.Size = new System.Drawing.Size(161, 23);
            this.btnCreateAppYandex.TabIndex = 5;
            this.btnCreateAppYandex.Text = "Регистрация приложения";
            this.btnCreateAppYandex.UseVisualStyleBackColor = true;
            this.btnCreateAppYandex.Click += new System.EventHandler(this.BtnCreateAppYandex_Click);
            // 
            // btnGetToken
            // 
            this.btnGetToken.Location = new System.Drawing.Point(473, 45);
            this.btnGetToken.Name = "btnGetToken";
            this.btnGetToken.Size = new System.Drawing.Size(161, 21);
            this.btnGetToken.TabIndex = 4;
            this.btnGetToken.Text = "Получить токен";
            this.btnGetToken.UseVisualStyleBackColor = true;
            this.btnGetToken.Click += new System.EventHandler(this.BtnGetToken_Click);
            // 
            // txbTokenYandex
            // 
            this.txbTokenYandex.Location = new System.Drawing.Point(90, 55);
            this.txbTokenYandex.Name = "txbTokenYandex";
            this.txbTokenYandex.Size = new System.Drawing.Size(312, 20);
            this.txbTokenYandex.TabIndex = 3;
            // 
            // txbIDYandex
            // 
            this.txbIDYandex.Location = new System.Drawing.Point(90, 22);
            this.txbIDYandex.Name = "txbIDYandex";
            this.txbIDYandex.Size = new System.Drawing.Size(312, 20);
            this.txbIDYandex.TabIndex = 2;
            // 
            // lblPasswordYandex
            // 
            this.lblPasswordYandex.AutoSize = true;
            this.lblPasswordYandex.Location = new System.Drawing.Point(7, 62);
            this.lblPasswordYandex.Name = "lblPasswordYandex";
            this.lblPasswordYandex.Size = new System.Drawing.Size(38, 13);
            this.lblPasswordYandex.TabIndex = 1;
            this.lblPasswordYandex.Text = "Токен";
            // 
            // lblLoginYandex
            // 
            this.lblLoginYandex.AutoSize = true;
            this.lblLoginYandex.Location = new System.Drawing.Point(7, 30);
            this.lblLoginYandex.Name = "lblLoginYandex";
            this.lblLoginYandex.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblLoginYandex.Size = new System.Drawing.Size(18, 13);
            this.lblLoginYandex.TabIndex = 0;
            this.lblLoginYandex.Text = "ID";
            // 
            // lblDeveloper
            // 
            this.lblDeveloper.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDeveloper.AutoSize = true;
            this.lblDeveloper.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblDeveloper.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDeveloper.Location = new System.Drawing.Point(577, 564);
            this.lblDeveloper.Name = "lblDeveloper";
            this.lblDeveloper.Size = new System.Drawing.Size(94, 13);
            this.lblDeveloper.TabIndex = 8;
            this.lblDeveloper.Text = "Tischenko Vitaly©";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 591);
            this.Controls.Add(this.lblDeveloper);
            this.Controls.Add(this.grbCloudYandex);
            this.Controls.Add(this.btnCloudUpload);
            this.Controls.Add(this.btnCreateBackup);
            this.Controls.Add(this.btnKillProcess);
            this.Controls.Add(this.btnGetProcess);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.MaximumSize = new System.Drawing.Size(690, 630);
            this.MinimumSize = new System.Drawing.Size(690, 630);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoSave 1c";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPr)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.grbCloudYandex.ResumeLayout(false);
            this.grbCloudYandex.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvPr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Button btnGetProcess;
        private System.Windows.Forms.Button btnKillProcess;
        private System.Windows.Forms.Button btnCreateBackup;
        private System.Windows.Forms.Button btnCloudUpload;
        private System.Windows.Forms.Button btnConnect1c;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сброситьToolStripMenuItem;
        private System.Windows.Forms.Label lblDataBase;
        private System.Windows.Forms.TextBox txtDataBase;
        private System.Windows.Forms.FolderBrowserDialog SelectDataBase;
        private System.Windows.Forms.Button SelectFolder;
        private System.Windows.Forms.DataGridViewTextBoxColumn start;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.GroupBox grbCloudYandex;
        private System.Windows.Forms.Button btnGetToken;
        private System.Windows.Forms.TextBox txbTokenYandex;
        private System.Windows.Forms.TextBox txbIDYandex;
        private System.Windows.Forms.Label lblPasswordYandex;
        private System.Windows.Forms.Label lblLoginYandex;
        private System.Windows.Forms.Button btnSelectSaveCatalog;
        private System.Windows.Forms.TextBox txtSaveCatalog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCreateAppYandex;
        private System.Windows.Forms.Button btnConnectYandex;
        private System.Windows.Forms.Label lblDeveloper;
    }
}

