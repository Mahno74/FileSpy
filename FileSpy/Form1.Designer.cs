namespace FileSpy
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox_Log = new System.Windows.Forms.TextBox();
            this.button_Start_Stop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_ClearLog = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.наблюдаемыйКаталогToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прописатьПутьККаталогуВручнуюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчиститьИсториюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.comboBox_Path = new System.Windows.Forms.ComboBox();
            this.textBox_wait = new System.Windows.Forms.TextBox();
            this.checkBox_Observer = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_waiter = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Log
            // 
            this.textBox_Log.Location = new System.Drawing.Point(12, 54);
            this.textBox_Log.Multiline = true;
            this.textBox_Log.Name = "textBox_Log";
            this.textBox_Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Log.Size = new System.Drawing.Size(483, 316);
            this.textBox_Log.TabIndex = 0;
            // 
            // button_Start_Stop
            // 
            this.button_Start_Stop.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Start_Stop.Location = new System.Drawing.Point(12, 376);
            this.button_Start_Stop.Name = "button_Start_Stop";
            this.button_Start_Stop.Size = new System.Drawing.Size(75, 23);
            this.button_Start_Stop.TabIndex = 1;
            this.button_Start_Stop.Text = "START";
            this.button_Start_Stop.UseVisualStyleBackColor = true;
            this.button_Start_Stop.Click += new System.EventHandler(this.Button_Start_Stop_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // button_ClearLog
            // 
            this.button_ClearLog.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ClearLog.Location = new System.Drawing.Point(385, 376);
            this.button_ClearLog.Name = "button_ClearLog";
            this.button_ClearLog.Size = new System.Drawing.Size(110, 23);
            this.button_ClearLog.TabIndex = 2;
            this.button_ClearLog.Text = "CLEAR LOG";
            this.button_ClearLog.UseVisualStyleBackColor = true;
            this.button_ClearLog.Click += new System.EventHandler(this.Button_Click_ClearLog);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(794, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.наблюдаемыйКаталогToolStripMenuItem,
            this.прописатьПутьККаталогуВручнуюToolStripMenuItem,
            this.отчиститьИсториюToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuToolStripMenuItem.Image = global::FileSpy.Properties.Resources.user1;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.menuToolStripMenuItem.Text = "Настройки";
            // 
            // наблюдаемыйКаталогToolStripMenuItem
            // 
            this.наблюдаемыйКаталогToolStripMenuItem.Image = global::FileSpy.Properties.Resources.connect;
            this.наблюдаемыйКаталогToolStripMenuItem.Name = "наблюдаемыйКаталогToolStripMenuItem";
            this.наблюдаемыйКаталогToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.наблюдаемыйКаталогToolStripMenuItem.Text = "Выбрать папку для наблюдения";
            this.наблюдаемыйКаталогToolStripMenuItem.Click += new System.EventHandler(this.НаблюдаемыйКаталогToolStripMenuItem_Click);
            // 
            // прописатьПутьККаталогуВручнуюToolStripMenuItem
            // 
            this.прописатьПутьККаталогуВручнуюToolStripMenuItem.Image = global::FileSpy.Properties.Resources.user;
            this.прописатьПутьККаталогуВручнуюToolStripMenuItem.Name = "прописатьПутьККаталогуВручнуюToolStripMenuItem";
            this.прописатьПутьККаталогуВручнуюToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.прописатьПутьККаталогуВручнуюToolStripMenuItem.Text = "Указать папку вручную";
            this.прописатьПутьККаталогуВручнуюToolStripMenuItem.Click += new System.EventHandler(this.ПрописатьПутьККаталогуВручнуюToolStripMenuItem_Click);
            // 
            // отчиститьИсториюToolStripMenuItem
            // 
            this.отчиститьИсториюToolStripMenuItem.Image = global::FileSpy.Properties.Resources.exit;
            this.отчиститьИсториюToolStripMenuItem.Name = "отчиститьИсториюToolStripMenuItem";
            this.отчиститьИсториюToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.отчиститьИсториюToolStripMenuItem.Text = "Отчистить историю";
            this.отчиститьИсториюToolStripMenuItem.Click += new System.EventHandler(this.ОтчиститьИсториюToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Image = global::FileSpy.Properties.Resources.about_3697;
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.ОПрограммеToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // comboBox_Path
            // 
            this.comboBox_Path.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Path.FormattingEnabled = true;
            this.comboBox_Path.Location = new System.Drawing.Point(12, 27);
            this.comboBox_Path.Name = "comboBox_Path";
            this.comboBox_Path.Size = new System.Drawing.Size(302, 21);
            this.comboBox_Path.TabIndex = 6;
            this.comboBox_Path.DropDownClosed += new System.EventHandler(this.ComboBoxPath_DropDownClosed);
            // 
            // textBox_wait
            // 
            this.textBox_wait.Location = new System.Drawing.Point(320, 27);
            this.textBox_wait.Name = "textBox_wait";
            this.textBox_wait.Size = new System.Drawing.Size(85, 20);
            this.textBox_wait.TabIndex = 7;
            this.toolTip1.SetToolTip(this.textBox_wait, "часть название ожидаемого файла");
            // 
            // checkBox_Observer
            // 
            this.checkBox_Observer.AutoSize = true;
            this.checkBox_Observer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_Observer.Location = new System.Drawing.Point(411, 27);
            this.checkBox_Observer.Name = "checkBox_Observer";
            this.checkBox_Observer.Size = new System.Drawing.Size(85, 20);
            this.checkBox_Observer.TabIndex = 8;
            this.checkBox_Observer.Text = "ждем =>";
            this.toolTip1.SetToolTip(this.checkBox_Observer, "При включении уведомить о появлении файла");
            this.checkBox_Observer.UseVisualStyleBackColor = true;
            this.checkBox_Observer.CheckedChanged += new System.EventHandler(this.СheckBoxObserver_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox1.Controls.Add(this.textBox_waiter);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(523, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 368);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Лист ожидания";
            // 
            // textBox_waiter
            // 
            this.textBox_waiter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_waiter.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_waiter.Location = new System.Drawing.Point(7, 20);
            this.textBox_waiter.Multiline = true;
            this.textBox_waiter.Name = "textBox_waiter";
            this.textBox_waiter.Size = new System.Drawing.Size(246, 342);
            this.textBox_waiter.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(794, 411);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox_Observer);
            this.Controls.Add(this.textBox_wait);
            this.Controls.Add(this.comboBox_Path);
            this.Controls.Add(this.button_ClearLog);
            this.Controls.Add(this.button_Start_Stop);
            this.Controls.Add(this.textBox_Log);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Log;
        private System.Windows.Forms.Button button_Start_Stop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_ClearLog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem наблюдаемыйКаталогToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ComboBox comboBox_Path;
        private System.Windows.Forms.ToolStripMenuItem отчиститьИсториюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прописатьПутьККаталогуВручнуюToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_wait;
        private System.Windows.Forms.CheckBox checkBox_Observer;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_waiter;
    }
}

