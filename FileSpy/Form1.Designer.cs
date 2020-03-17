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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.наблюдаемыйКаталогToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прописатьПутьККаталогуВручнуюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчиститьИсториюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Log
            // 
            this.textBox_Log.Location = new System.Drawing.Point(12, 54);
            this.textBox_Log.Multiline = true;
            this.textBox_Log.Name = "textBox_Log";
            this.textBox_Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Log.Size = new System.Drawing.Size(483, 312);
            this.textBox_Log.TabIndex = 0;
            // 
            // button_Start_Stop
            // 
            this.button_Start_Stop.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Start_Stop.Location = new System.Drawing.Point(12, 372);
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
            this.button_ClearLog.Location = new System.Drawing.Point(385, 372);
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
            this.menuStrip1.Size = new System.Drawing.Size(511, 24);
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
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(483, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.DropDownClosed += new System.EventHandler(this.comboBox1_DropDownClosed);
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
            this.прописатьПутьККаталогуВручнуюToolStripMenuItem.Click += new System.EventHandler(this.прописатьПутьККаталогуВручнуюToolStripMenuItem_Click);
            // 
            // отчиститьИсториюToolStripMenuItem
            // 
            this.отчиститьИсториюToolStripMenuItem.Image = global::FileSpy.Properties.Resources.exit;
            this.отчиститьИсториюToolStripMenuItem.Name = "отчиститьИсториюToolStripMenuItem";
            this.отчиститьИсториюToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.отчиститьИсториюToolStripMenuItem.Text = "Отчистить историю";
            this.отчиститьИсториюToolStripMenuItem.Click += new System.EventHandler(this.отчиститьИсториюToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Image = global::FileSpy.Properties.Resources.about_3697;
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.ОПрограммеToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 407);
            this.Controls.Add(this.comboBox1);
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStripMenuItem отчиститьИсториюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прописатьПутьККаталогуВручнуюToolStripMenuItem;
    }
}

