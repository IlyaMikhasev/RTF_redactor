using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTF_redactor
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void radioButton_CheckedChanged()
        {
            if (rb_winForm.Checked)
            {
                WinWorms winForm = new WinWorms();
                winForm.Size = this.Size;
                winForm.Text = $"Обычная форма";
                winForm.Show();
            }
            else if (rb_mdiForm.Checked) {
                this.IsMdiContainer = true;
                MDI_Forms MDIForm = new MDI_Forms();
                MDIForm.MdiParent = this;
                MDIForm.Size = new Size(this.Width-40,this.Height-50);
                MDIForm.Location = new Point(0, 0 + panel1.Size.Height);
                MDIForm.Text = $"MDI форма";
                MDIForm.Show();
            }
        }

        private void b_create_Click(object sender, EventArgs e)
        {
            radioButton_CheckedChanged();
        }

      
    }
   
}
