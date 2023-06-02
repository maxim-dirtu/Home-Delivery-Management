using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LivrariLaDomiciliu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.SelectionLength = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formComenziFacturi = new FormComenziFacturi();
            formComenziFacturi.Show();
        }

        private void btnFormClienti_Click(object sender, EventArgs e)
        {
            var formClienti = new FormClienti();
            formClienti.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
