using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTF_redactor
{
    public partial class MDI_Forms : Form
    {
        public MDI_Forms()
        {
            InitializeComponent();
            
        }
        private void btnSave_MouseClick(object sender, MouseEventArgs e)
        {
            richTextBox1.SaveFile("Dock.rtf");
            MessageBox.Show($"Файл сохранен в {Environment.CurrentDirectory.ToString()}") ;
        }

        private string OpenFile()
        {
            using (OpenFileDialog of = new OpenFileDialog())
            {
                of.Filter = "RTF files (*.rtf)|*.rtf";
                of.InitialDirectory = Environment.CurrentDirectory;

                if (of.ShowDialog() == DialogResult.OK)
                {
                    return of.FileName;
                }
            }
            return "none";
        }
       
        private void b_color_Click(object sender, EventArgs e)
        {
            // расширенное окно для выбора цвета
            colorDialog1.FullOpen = true;
            // установка начального цвета для colorDialog
            colorDialog1.Color = this.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // установка цвета формы
            richTextBox1.BackColor = colorDialog1.Color;
        }

        private void b_font_Click(object sender, EventArgs e)
        {
            // добавляем возможность выбора цвета шрифта
            fontDialog1.ShowColor = true;
            if (fontDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // установка шрифта
            richTextBox1.SelectionFont = fontDialog1.Font;
            // установка цвета шрифта
            richTextBox1.SelectionColor = fontDialog1.Color;
        }

        private void btnLoad_MouseClick(object sender, EventArgs e)
        {
            string result = OpenFile();
            if (result != "none")
            {
                richTextBox1.LoadFile(result);
            }
        }
    }
}
