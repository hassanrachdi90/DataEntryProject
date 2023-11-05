using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataEntryProject
{
    public partial class FmrDataEntry : Form
    {
        TimeSpan time;
        DateTime datime;
        public FmrDataEntry()
        {
            InitializeComponent();
        }

        private void b5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            //tb1.Clear();
            //tb2.Clear();
            //tb3.Clear();
            //tb4.Clear();
            //tb5.Clear();
            //tb1.Focus();

            
            TextBox[] textBoxes = { tb1, tb2, tb3, tb4, tb5 };

            
            foreach (TextBox textBox in textBoxes)
            {
                textBox.Clear();
            }

            tb1.Focus();
        }

        private void tim_Tick(object sender, EventArgs e)
        {
            time += DateTime.Now - datime;
            datime = DateTime.Now;
            tb6.Text=Convert.ToString(new TimeSpan(time.Hours,time.Minutes,time.Seconds));
        }

        private void b3_Click(object sender, EventArgs e)
        {
            b3.Enabled = false;
            b4.Enabled = true;
            tim.Enabled = true;
            gb1.Enabled = true;
            tb1.Focus();
            datime= DateTime.Now;
        }

        private void b4_Click(object sender, EventArgs e)
        {
            b3.Enabled = true;
            b4.Enabled = false;
            tim.Enabled = false;
            gb1.Enabled = false;
            
        }

        private void b1_Click(object sender, EventArgs e)
        {
            string dataEntry;
            if(tb1.Text.Equals("")|| tb2.Text.Equals("") || tb3.Text.Equals("") || tb4.Text.Equals("") || tb5.Text.Equals(""))
            {
                MessageBox.Show("Chaque case doit avoir une entrée", "Erreur Message", MessageBoxButtons.OK,MessageBoxIcon.Error) ;
                tb1.Focus();
                return;
            }
            dataEntry=tb1.Text +"\r\n" + tb2.Text + "\r\n"+ tb3.Text + "\r\n" + tb4.Text + "\r\n" + tb5.Text ;
            MessageBox.Show(dataEntry,"Data Entry",MessageBoxButtons.OK);
            b2.PerformClick();
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            string textBoxSender = ((TextBox)sender).Name;
            if (e.KeyChar == 13)
            {
                switch(textBoxSender)
                {
                    case "tb1":tb2.Focus(); break;
                    case "tb2":tb3.Focus(); break;
                    case "tb3": tb4.Focus(); break;
                    case "tb4": tb5.Focus(); break;
                    case "tb5": b1.Focus(); break;


                }
            }
            if (textBoxSender.Equals("tb5"))
            {
                if((e.KeyChar>='0'&& e.KeyChar <= '9')|| e.KeyChar==8)
                {
                    e.Handled = false;
                }
                else { e.Handled = true; }
            }
        }

        private void btnAccept_Hover(object sender, EventArgs e)
        {
           // b1.BackColor= Color.Green; //Non Generic
           ((Button)sender).BackColor = Color.Green;//Generic
        }

        private void btnAccept_Leave(object sender, EventArgs e)
        {
            // b1.BackColor = SystemColors.Control;//Non Generic
            ((Button)sender).BackColor = SystemColors.Control;//Generic
        }
    }
}
