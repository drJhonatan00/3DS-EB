using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        string cam = @"WindowsFormsApp10.config";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string beta = File.ReadAllText(cam);
            
            if(beta == "")
            {
                this.Hide();
                Form2 form = new Form2();
                form.ShowDialog();
                this.Close();
            }
            else
            {
                this.Hide();
                Form3 form = new Form3();
                form.ShowDialog();
                this.Close();
            }
        }
    }
}
