using System;
using System.Windows.Forms;
using System.IO;

namespace PrintMarge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void createMt85()
        {
            int u = Convert.ToInt32(nznamenaka.Value);
            StreamWriter sw = new StreamWriter("C:\\Users\\Kristijan\\Documents\\" + filenameText.Text + "MT85" + ".txt");
            for (int n = Convert.ToInt32(numeric1.Value); n < Convert.ToInt32(numeric1.Value) + Convert.ToInt32(numeric2.Value); n++)
            {
                string s = n.ToString("d" + u);
                sw.WriteLine(s);
            }
            sw.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label5.Text = "";
                int u = Convert.ToInt32(nznamenaka.Value);
                //if 
                StreamWriter sw = new StreamWriter("C:\\Users\\Kristijan\\Documents\\" + filenameText.Text + ".txt");
                //StreamWriter sw = new StreamWriter(filenameText.Text);
                sw.WriteLine("1");
                sw.WriteLine("\\" + "S1" + "\\");
                for (int n = Convert.ToInt32(numeric1.Value); n < Convert.ToInt32(numeric1.Value) + Convert.ToInt32(numeric2.Value); n++)
                {
                    string s = n.ToString("d" + u);
                    sw.WriteLine("\\" + s + "\\");
                }
                sw.Close();
                if (checkBox1.Checked == true)
                {
                    createMt85();
                }
                label5.Text = "uspješno generirano";

            }

            catch (Exception ex)
            {
                MessageBox.Show("greska" + ex.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numeric1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Form.ActiveForm.Text = "Corel Generator v" + ProductVersion.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg_save = new SaveFileDialog();
            dlg_save.Filter = "text documents (.txt) | *.txt";
            Nullable<bool> result = Convert.ToBoolean(dlg_save.ShowDialog());
            if (result == true)
            {
                string filename = dlg_save.FileName;
                filenameText.Text = filename;
            }
        }

        private void filenameText_DoubleClick(object sender, EventArgs e)
        {
            button2_Click(button2, null);
        }
    }
}