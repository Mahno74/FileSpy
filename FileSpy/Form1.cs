using FileSpy;
using FileSpy.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FileSpy
{
    public partial class Form1 : Form
    {

        public readonly string logString = " (" + DateTime.Now.ToString("dd.MM.yyyy (HH:mm)") + ")" + "\r\n"; //временная строка для лога
        public string filePath;
        private List<string> historyList = new List<string>(); //список последних каталогов наблюдаемых каталогов
        private List<string> default_FileCollection = new List<string>(); //начальный список файлов
        private List<string> changed_FileCollection = new List<string>(); //измененный список файлов

        public Form1()
        {
            InitializeComponent();
            //подготовка для иконки в трее
            notifyIcon1.Visible = false;
            this.notifyIcon1.MouseDoubleClick += new MouseEventHandler(notifyIcon1_MouseDoubleClick);  //событие при двойном клике на иконку в трее
            this.Resize += new System.EventHandler(this.Form1_Resize); //событие при изменение размера окна в часности свертывания
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "FileSpy v1.2 (c) Юрасов В.В.";
            ReadSettings(); //получаем первоначальные настройки
            filePath = @"log.txt";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DirectoryInfo dir;
            try { dir = new DirectoryInfo(comboBox1.Text); }
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
                button1.Text = "STOP";
                timer1.Enabled = true;
                comboBox1.Enabled = false;
                return;
            }
            if (timer1.Enabled == true)
            {
                button1.Text = "START";
                timer1.Enabled = false;
                comboBox1.Enabled = true;
                return;
            }
        }
        private void Comprase(List<string> base_FileCollection) //сравнием старый и новый список
        {
            changed_FileCollection = ListGenerator(); //получаем новый список файлов
            if (changed_FileCollection.SequenceEqual(base_FileCollection)) return; //если список не изменился то ничего не делаем

            if (changed_FileCollection.Count > base_FileCollection.Count) //если файлов стало больше (добавление)
            {
                var result = changed_FileCollection.Except(base_FileCollection); //формируем список из новых файлов
                foreach (var i in result) Logging("+ " + i + logString); //логирум
            }
            if (changed_FileCollection.Count < base_FileCollection.Count) //если файлов стало меньше (удаление)
            {
                var result = base_FileCollection.Except(changed_FileCollection); //формируем список из пропавших файлов
                foreach (var i in result) Logging("- " + i + logString); //логируем
            }
            default_FileCollection = changed_FileCollection; //обновляем дефорлтный список файлов
        }
        private void Logging(string save) //Логирование путем добавления в TextBox и записи в файл лога
        {
            textBox_Log.Text += save;
            textBox_Log.SelectionStart = textBox_Log.Text.Length; textBox_Log.ScrollToCaret(); //перемотка в конец
            using (StreamWriter sw = new StreamWriter("log.txt", true, System.Text.Encoding.GetEncoding(1251)))
            {
                sw.Write(save);
            }
        }

        public List<string> ListGenerator() //получает список файлов из указаной папки
        {
            List<string> list = new List<string>();
            DirectoryInfo dir = new DirectoryInfo(comboBox1.Text);
            FileInfo[] fileColection = dir.GetFiles(); //получаем набор файлов в папке
            foreach (var f in fileColection)
                list.Add(f.Name);
            return list;
        }

        private void Button_Click_ClearLog(object sender, EventArgs e) //отчистка файла с логами и текстбокса
        {
            textBox_Log.Clear();
            using (StreamWriter sw = new StreamWriter(filePath, false, System.Text.Encoding.GetEncoding(1251)))
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
        private void Timer1_Tick(object sender, EventArgs e) //проверка каталога по таймеру
        {
            Comprase(default_FileCollection);
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
                historyList.Add(newPath);
                comboBox1.DataSource = null;
                comboBox1.DataSource = historyList;
            }
        }
        private void ReadSettings() //чтение настроек
        {
            FileInfo fi = new FileInfo(Application.StartupPath + "\\history.txt");
            if (!fi.Exists)
            {
                FileStream fs = fi.Create();
                fs.Close();
            }
            else
            {
                StreamReader sr = new StreamReader(Application.StartupPath + "\\history.txt", System.Text.Encoding.GetEncoding(1251));
                while (!sr.EndOfStream)
                {
                    historyList.Add(sr.ReadLine());
                }
                sr.Close();
                comboBox1.DataSource = historyList;
                comboBox1.Text = Settings.Default.savedDir;
            }

        }

        private void ОПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разработано Юрасовым В.В. \r\nв 2019 году");
        }
        private void Form1_Resize(object sender, EventArgs e) //изменение размера окна (сворачивание)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e) //двойной клик по иконке в трее
        {
            this.Show();
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void отчиститьИсториюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox1.DataSource = null;
            FileInfo fi = new FileInfo(Application.StartupPath + "\\history.txt");
            if (fi.Exists) fi.Delete();

        }

        private void НаблюдаемыйКаталогToolStripMenuItem_Click(object sender, EventArgs e) //выбор каталога для наблюдения
        {
            folderBrowserDialog1.Description = "Выберите каталог для отслеживания";
            folderBrowserDialog1.ShowNewFolderButton = false;
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.Cancel) return;
            string newPath = folderBrowserDialog1.SelectedPath; //выбранный путь
            comboBox1.Text = newPath;
            SaveSettings(newPath);
        }
        private void comboBox1_DropDownClosed(object sender, EventArgs e) //сохраняем последний выбранный каталог
        {
            if(comboBox1.Text == "") return;
            SaveSettings(comboBox1.Text); 
        }
    }
}
