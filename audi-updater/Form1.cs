using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace audi_updater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                string filePath = openFileDialog1.FileName;

                textBox1.Text = filePath;
                System.Diagnostics.Process.Start("javaws", filePath);

                Task.Delay(5000);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Keine oder inkompatible Datei ausgewählt!");
            }
        }
    }
}
