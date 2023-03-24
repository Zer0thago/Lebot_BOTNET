using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lebot_Starter
{
    public partial class Form1 : Form
    {
        public bool a_bord {get;set;}
    public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Lebot_starter");
            Environment.Exit(0);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string path_dir = Directory.GetCurrentDirectory();
            try
            {
                if(File.Exists(path_dir + "\\modules\\modules.json"))
                {
                    File.Delete(path_dir + "\\modules\\modules.json");
                }
                writee();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void writee()
        {
            string path_dir = Directory.GetCurrentDirectory();
            using (StreamWriter writetext = new StreamWriter(path_dir + "\\modules\\modules.json"))
            {
                writetext.WriteLine("{ \"method\": \"" + guna2ComboBox1.SelectedItem + "\", \"proto\": \" " + guna2ComboBox2.SelectedItem + "\", \"l4_pdm\": \"" + guna2NumericUpDown1.Value + "\", \"port\": \"" + guna2NumericUpDown2.Value + "\", \"count\": \"" + guna2NumericUpDown3.Value + "\",\"useragent\": \"" + guna2TextBox1.Text + "\" }");


            }
            Environment.Exit(0);
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            a_bord = false;
        }
    }
}
