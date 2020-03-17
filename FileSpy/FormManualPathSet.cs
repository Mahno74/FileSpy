using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSpy
{
    public partial class FormManualPathSet : Form
    {
        public FormManualPathSet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length < 3)  return; //небольшая проверка на правильность пути
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(textBox1.Text);
            if(!di.Exists)
                MessageBox.Show("Указанного каталога не существует!", "Ошибка");
            else
            {
                Form1.dirPath = textBox1.Text;
                this.Close();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) //нажатие кнопок в поле
        {
            if(e.KeyChar == (char)Keys.Enter) button1_Click(sender, e); //по ентер отправляем нажатие кнопки
            if (e.KeyChar == (char)Keys.Escape) this.Close(); //о Esc  выходим
        }
    }
}
