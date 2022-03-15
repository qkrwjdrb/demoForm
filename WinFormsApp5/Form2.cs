using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp5.Forms;

namespace WinFormsApp5
{
    public partial class Form2 : Form
    {
        private Form activeForm;
        screen.UserControl9 UserControl9 = new screen.UserControl9();
        screen.UserControl1 UserControl1 = new screen.UserControl1();
        public Form2()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm,object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(childForm);
            this.panel3.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormChart(), sender);
        }
     
        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Formc(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Formc>().Any())
            {
                button3.Text = "asdfadsf";
            }
            else
            {
                button3.Text = "1213241235234";
            }
        }
    }
}