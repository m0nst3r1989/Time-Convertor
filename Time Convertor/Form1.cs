using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Convertor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertor_Click(object sender, EventArgs e)
        {
                int seconds = Convert.ToInt32(textBoxSeconds.Text);

                if (seconds >= 86400)
                {
                    int days = seconds / 86400;
                    timeConverted.Text = days + " days";
                }
                else if (seconds >= 3600)
                {
                    int hours = seconds / 3600;
                    timeConverted.Text = hours + " hours";
                }
                else if (seconds >= 60)
                {
                    int minutes = seconds / 60;
                    timeConverted.Text = minutes + " minutes";
                }
                else
                {
                    timeConverted.Text = seconds + " seconds";
                }
            }


        }

  
}
