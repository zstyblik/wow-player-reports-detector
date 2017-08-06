using System;
using System.IO;
using System.Windows.Forms;
using Styx;
using Styx.Common;

namespace PlayerReportsDetector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Word();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Word();
        }
        public void Word()
        {
             string FileLocation = @"Plugins\PlayerReportsDetector\" + StyxWoW.Me.RealmName + @"\" + StyxWoW.Me.Name + ".txt";

            try
            {
                var fs = new FileStream(FileLocation, FileMode.Append);
                var sw = new StreamWriter(fs);
                sw.Close();
                dataGridView1.Rows.Clear();
                var sr = new StreamReader(FileLocation);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    dataGridView1.Rows.Add(line.Split('|'));
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Logging.Write(e.Message);
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
