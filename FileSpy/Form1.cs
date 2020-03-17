using FileSpy.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSpy
{
    public partial class Form1 : Form
    {

        public readonly string logString = " (" + DateTime.Now.ToString("dd.MM.yyyy (HH:mm)") + ")" + "\r\n"; //временная строка для лога
        public string logFileName = "log.txt";
        public static string dirPath; //переменная для обмена данными между формами
        private List<string> historyList = new List<string>(); //список последних каталогов наблюдаемых каталогов

        private List<string> default_FileCollection = new List<string>(); //начальный список файлов
        private List<string> changed_FileCollection = new List<string>(); //измененный список файлов

        public Form1()
        {
            InitializeComponent();
            //подготовка для иконки в трее
            notifyIcon1.Visible = false;
            this.notifyIcon1.MouseDoubleClick += new MouseEventHandler(NotifyIcon1_MouseDoubleClick);  //событие при двойном клике на иконку в трее
            this.Resize += new System.EventHandler(this.Form1_Resize); //событие при изменение размера окна в часности свертывания
            this.Text = "FileSpy v2.0 (c) Юрасов В.В.";
            ReadSettings(); //получаем первоначальные настройки
        }
        private void SaveSettings(string newPath) //сохрание настроек
        {
            Settings.Default.savedDir = newPath;
            Settings.Default.Save();
            if (!historyList.Contains(newPath)) //если такого каталога еще не выбиралось записываем его в историю
            {
                StreamWriter sw = new StreamWriter("history.txt", true, System.Text.Encoding.GetEncoding(1251));
                sw.WriteLine(newPath);
                sw.Close();
                //и вносим в комбобокс
                historyList.Add(newPath);
                comboBox_Path.DataSource = null; comboBox_Path.DataSource = historyList; //обновляем записи в комбобоксе
            }
            comboBox_Path.Text = newPath; //ставим выбранный пусть  
            if (timer1.Enabled) Button_Start_Stop_Click(null, null); //если процес был запущен, останавливаем
        }
        private void ReadSettings() //чтение настроек при запуске
        {
            this.Size = new System.Drawing.Size(520, 450);
            FileInfo fi = new FileInfo(Application.StartupPath + "\\history.txt"); //проверка файла с иторией
            if (!fi.Exists) //если файла нет то создаем
            {
                FileStream fs = fi.Create();
                fs.Close();
            }
            else //если есть то читаем и запихиваем в комбобокс
            {
                StreamReader sr = new StreamReader(Application.StartupPath + "\\history.txt", System.Text.Encoding.GetEncoding(1251));
                while (!sr.EndOfStream)
                {
                    historyList.Add(sr.ReadLine());
                }
                sr.Close();
                comboBox_Path.DataSource = historyList;
                comboBox_Path.Text = Settings.Default.savedDir; 
            }
        }
        //основная логика
        private void Timer1_Tick(object sender, EventArgs e) //проверка каталога по таймеру
        {
            Comprase(default_FileCollection);
        }
        private void Comprase(List<string> base_FileCollection) //сравнием старый и новый список
        {
            changed_FileCollection = ListGenerator(); //получаем новый список файлов
            if (changed_FileCollection.SequenceEqual(base_FileCollection)) return; //если список не изменился то ничего не делаем

            if (changed_FileCollection.Count > base_FileCollection.Count) //если файлов стало больше (добавление)
            {
                var result = changed_FileCollection.Except(base_FileCollection); //формируем список из новых файлов
                foreach (var i in result)
                {
                    Logging("+ " + i + logString); //логирум
                    if (checkBox_Observer.Checked)
                    {
                        if (i.Contains(textBox_wait.Text))
                        {
                            textBox_waiter.AppendText(i + logString);
                            this.Size = new System.Drawing.Size(810, 450);
                        }
                    }
                }

            }
            if (changed_FileCollection.Count < base_FileCollection.Count) //если файлов стало меньше (удаление)
            {
                var result = base_FileCollection.Except(changed_FileCollection); //формируем список из пропавших файлов
                foreach (var i in result) Logging("- " + i + logString); //логируем
            }
            default_FileCollection = changed_FileCollection; //обновляем дефорлтный список файлов
        }
        public List<string> ListGenerator() //получает список файлов из указаной папки
        {
            List<string> list = new List<string>();
            DirectoryInfo dir = new DirectoryInfo(comboBox_Path.Text);
            FileInfo[] fileColection = dir.GetFiles(); //получаем набор файлов в папке
            foreach (var f in fileColection)
                list.Add(f.Name);
            return list;
        }
        private void Logging(string save) //Логирование путем добавления в TextBox и записи в файл лога
        {
            textBox_Log.Text += save;
            textBox_Log.SelectionStart = textBox_Log.Text.Length; textBox_Log.ScrollToCaret(); //перемотка в конец
            using (StreamWriter sw = new StreamWriter(logFileName, true, System.Text.Encoding.GetEncoding(1251)))
            {
                sw.Write(save);
            }
        }
        //работа с меню и элементами управления
        private void ОтчиститьИсториюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox_Path.DataSource = null;
            FileInfo fi = new FileInfo(Application.StartupPath + "\\history.txt");
            if (fi.Exists) fi.Delete();
        }
        private void НаблюдаемыйКаталогToolStripMenuItem_Click(object sender, EventArgs e) //выбор каталога для наблюдения
        {
            folderBrowserDialog1.Description = "Выберите каталог для отслеживания";
            folderBrowserDialog1.ShowNewFolderButton = false;
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer; //корневой каталог
            if (folderBrowserDialog1.ShowDialog() == DialogResult.Cancel) return;
            string newPath = folderBrowserDialog1.SelectedPath; //выбранный путь
            SaveSettings(newPath);
        }
        private void ОПрограммеToolStripMenuItem_Click(object sender, EventArgs e) => MessageBox.Show("Разработано Юрасовым В.В. \r\nв 2020 году (2665603@gmail.com)", "О программе");
        private void ПрописатьПутьККаталогуВручнуюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string temp = dirPath; //сохраняем первоначальный путь
            FormManualPathSet f = new FormManualPathSet(); f.ShowDialog();
            if (temp == dirPath) return; //если в новой форме ничего не менялось то и мы ничего не делаеем
            SaveSettings(dirPath); //сохраняем новый путь
        }
        private void Button_Start_Stop_Click(object sender, EventArgs e)
        {
            DirectoryInfo dir;
            try { dir = new DirectoryInfo(comboBox_Path.Text); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            if (!dir.Exists) //проверяем существует ли выбранный каталог
            {
                MessageBox.Show("Выбранного каталога не существует!"); return;
            }
            default_FileCollection = ListGenerator(); //получаем список файлов
            if (timer1.Enabled == false)
            {
                button_Start_Stop.Text = "STOP";
                timer1.Enabled = true;
                comboBox_Path.Enabled = false;
                return;
            }
            if (timer1.Enabled == true)
            {
                button_Start_Stop.Text = "START";
                timer1.Enabled = false;
                comboBox_Path.Enabled = true;
                return;
            }
        }
        private void Button_Click_ClearLog(object sender, EventArgs e) //отчистка файла с логами и текстбокса
        {
            textBox_Log.Clear();
            using (StreamWriter sw = new StreamWriter(logFileName, false, System.Text.Encoding.GetEncoding(1251)))
            {
                try
                {
                    sw.WriteLine();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        private void СheckBoxObserver_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox_Observer.Checked) this.Size = new System.Drawing.Size(527, 446); //скрываем окно лога
            textBox_waiter.Clear(); //очищаем дополнительный лог
            if (checkBox_Observer.Checked && !timer1.Enabled) //если процес ожидания не запущен запускаем
            {
                Button_Start_Stop_Click(null, null);
            }
        }
        private void ComboBoxPath_DropDownClosed(object sender, EventArgs e) //сохраняем последний выбранный каталог
        {
            if (comboBox_Path.Text == "") return;
            SaveSettings(comboBox_Path.Text);
        }
        //Работа в трее
        private void Form1_Resize(object sender, EventArgs e) //изменение размера окна (сворачивание)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;
            }
        }
        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e) //двойной клик по иконке в трее
        {
            this.Show();
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }

    }
}
