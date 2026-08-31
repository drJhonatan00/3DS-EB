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
    public partial class Form2 : Form
    {
        string cam = @"WindowsFormsApp10.config";
        string lang = "";
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText(cam, "EN");
            this.Hide();
            Form3 form = new Form3();
            form.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.WriteAllText(cam, "ES");
            this.Hide();
            Form3 form = new Form3();
            form.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            File.WriteAllText(cam, "PT");
            this.Hide();
            Form3 form = new Form3();
            form.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           File.WriteAllText(cam, "KO");
            this.Hide();
            Form3 form = new Form3();
            form.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            File.WriteAllText(cam, "JA");
            this.Hide();
            Form3 form = new Form3();
            form.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            File.WriteAllText(cam, "AL");
            this.Hide();
            Form3 form = new Form3();
            form.ShowDialog();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            File.WriteAllText(cam, "IT");
            this.Hide();
            Form3 form = new Form3();
            form.ShowDialog();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            File.WriteAllText(cam, "FR");
            this.Hide();
            Form3 form = new Form3();
            form.ShowDialog();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            File.WriteAllText(cam, "CH");
            this.Hide();
            Form3 form = new Form3();
            form.ShowDialog();
            this.Close();
        }
    }
}
