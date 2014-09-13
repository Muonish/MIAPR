using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAppK_srednih
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            int Npoint = 0;
            int Nclass = 0;

            panelHolst.Refresh();
            if (comboBox1.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Enter the numbers.");
            }
            else
            {
                try
                {
                    Npoint = Convert.ToInt32(comboBox1.Text);
                }
                catch
                {
                    MessageBox.Show("Error! Out of int32!");
                }
                try
                {
                    Nclass = Convert.ToInt32(comboBox2.Text);
                }
                catch
                {
                    MessageBox.Show("Error! Out of int32!");
                }
                ClassKmeans Kmeans = new ClassKmeans(Npoint, Nclass, panelHolst, label3);
            }
        }
    }
}
