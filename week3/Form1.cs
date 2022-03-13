using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week3
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            if (tBoxInput.Text.Substring(0, 4).ToUpper() == "ISI:")
            {
                labelJawaban.Text = tBoxInput.Text.Substring(4);

            }
            else if (tBoxInput.Text.ToUpper() == "HIDE")
            {
                labelJawaban.Hide();
            }
            else if (tBoxInput.Text.ToUpper() == "SHOWN")
            {
                labelJawaban.Show();
            }
            else if (tBoxInput.Text.Substring (0,6).Equals("WARNA:"))
            {
                if (tBoxInput.Text.Contains("DEFAULT"))
                {
                    labelJawaban.ForeColor = Color.Black;
                }
                else if (tBoxInput.Text.Contains("BIRU"))
                {
                    labelJawaban.ForeColor = Color.Blue;
                }
                else if (tBoxInput.Text.Contains("HIJAU"))
                {
                    labelJawaban.ForeColor = Color.Green;
                }
                else if (tBoxInput.Text.Contains("MERAH"))
                {
                    labelJawaban.ForeColor = Color.Red;
                }
            }
            else if (tBoxInput.Text.ToUpper() == "RESTART")
            {
                labelJawaban.Text = "[EMPTY]";
                labelJawaban.ForeColor = Color.Black;
                labelJawaban.Font = new Font(labelJawaban.Font.FontFamily,15);
            }
            else if (tBoxInput.Text.ToUpper() == "BESARKAN")
            {
                var trial = labelJawaban.Font.Size;
                trial++;
                labelJawaban.Font = new Font(labelJawaban.Font.FontFamily,trial);
            }
            else if (tBoxInput.Text.ToUpper() == "KECILKAN")
            {
                var trial = labelJawaban.Font.Size;
                trial--;
                labelJawaban.Font = new Font(labelJawaban.Font.FontFamily, trial);
            }

            else
            {
                MessageBox.Show("Syntax tidak terdaftar!!");
            }

        }
    }
}
